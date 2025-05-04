using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Laborat1.JSONWorks;
using System.Collections.Concurrent;

internal class SaveData
{
    private static readonly string DataDirectory = Path.Combine(Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "Data");
    private static readonly string FilePath = Path.Combine(DataDirectory, "data.json");
    private static readonly object FileLock = new object();
    private static readonly ConcurrentQueue<(List<TestCase>? testCases, string? testName, int? actualIndex, int? actualValue, long? actualSum, long? actualCube, int[]? actualTransformedArray, List<string>? actualErrors)> WriteQueue = new();
    private static bool isInitialized = false;
    private static List<TestCase> testCasesCache = new();
    private static Task? writeTask;

    internal static void WriteDataToJson(
        List<TestCase>? testCases = null,
        string? testName = null,
        int? actualIndex = null,
        int? actualValue = null,
        long? actualSum = null,
        long? actualCube = null,
        int[]? actualTransformedArray = null,
        List<string>? actualErrors = null)
    {
        if (testName == null && testCases == null)
        {
            Console.WriteLine("Предупреждение: WriteDataToJson вызван с testName = null и testCases = null. Данные не будут добавлены.");
            return;
        }

        // Добавляем задачу в очередь
        WriteQueue.Enqueue((testCases, testName, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors));
        Console.WriteLine($"Добавлено в очередь: testName={testName}, testCases.Count={(testCases != null ? testCases.Count : 0)}");

        // Запускаем обработку очереди, если она еще не запущена
        if (writeTask == null || writeTask.IsCompleted)
        {
            writeTask = Task.Run(() => ProcessWriteQueue());
        }
    }

    private static void ProcessWriteQueue()
    {
        while (WriteQueue.TryDequeue(out var item))
        {
            lock (FileLock)
            {
                try
                {
                    // Инициализация: создание директории и загрузка кэша
                    if (!isInitialized)
                    {
                        if (!Directory.Exists(DataDirectory))
                        {
                            Directory.CreateDirectory(DataDirectory);
                            Console.WriteLine($"Создана директория: {DataDirectory}");
                        }

                        if (File.Exists(FilePath))
                        {
                            int retryCount = 5;
                            int retryDelay = 500;

                            while (retryCount > 0)
                            {
                                try
                                {
                                    string json = File.ReadAllText(FilePath);
                                    testCasesCache = JsonConvert.DeserializeObject<List<TestCase>>(json) ?? new List<TestCase>();
                                    Console.WriteLine($"Загружен кэш из {FilePath}: {testCasesCache.Count} элементов");
                                    break;
                                }
                                catch (IOException ex)
                                {
                                    retryCount--;
                                    Console.WriteLine($"Ошибка при чтении файла {FilePath}. Попытка {6 - retryCount} из 5. Ошибка: {ex.Message}");
                                    Task.Delay(retryDelay).Wait();
                                }
                                catch (JsonException ex)
                                {
                                    retryCount--;
                                    Console.WriteLine($"Ошибка десериализации JSON из {FilePath}. Попытка {6 - retryCount} из 5. Ошибка: {ex.Message}");
                                    Task.Delay(retryDelay).Wait();
                                }
                            }

                            if (retryCount == 0)
                            {
                                Console.WriteLine($"Не удалось прочитать файл {FilePath}. Используется пустой кэш.");
                                testCasesCache = new List<TestCase>();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Файл {FilePath} не существует. Создается новый кэш.");
                        }

                        isInitialized = true;
                    }

                    // Обработка данных
                    var (testCases, testName, actualIndex, actualValue, actualSum, actualCube, actualTransformedArray, actualErrors) = item;

                    if (!string.IsNullOrEmpty(testName))
                    {
                        var testCase = testCasesCache.FirstOrDefault(tc => tc.Name == testName);

                        if (testCase != null)
                        {
                            testCase.ActualIndex = actualIndex ?? testCase.ActualIndex;
                            testCase.ActualValue = actualValue ?? testCase.ActualValue;
                            testCase.ActualSum = actualSum ?? testCase.ActualSum;
                            testCase.ActualCube = actualCube ?? testCase.ActualCube;
                            testCase.ActualTransformedArray = actualTransformedArray ?? testCase.ActualTransformedArray;
                            testCase.ActualErrors = actualErrors ?? testCase.ActualErrors;
                            Console.WriteLine($"Обновлен существующий TestCase: {testName}");
                        }
                        else
                        {
                            var newTestCase = new TestCase
                            {
                                Name = testName,
                                ActualIndex = actualIndex ?? -1,
                                ActualValue = actualValue ?? 0,
                                ActualSum = actualSum ?? 0,
                                ActualCube = actualCube ?? 0,
                                ActualTransformedArray = actualTransformedArray ?? new int[0],
                                ActualErrors = actualErrors ?? new List<string>()
                            };
                            testCasesCache.Add(newTestCase);
                            Console.WriteLine($"Добавлен новый TestCase: {testName}");
                        }
                    }
                    else if (testCases != null)
                    {
                        foreach (var newTest in testCases)
                        {
                            if (!testCasesCache.Exists(tc => tc.Name == newTest.Name))
                            {
                                testCasesCache.Add(newTest);
                                Console.WriteLine($"Добавлен TestCase из testCases: {newTest.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"TestCase {newTest.Name} уже существует в кэше, пропущен.");
                            }
                        }
                    }

                    // Логирование содержимого кэша перед записью
                    Console.WriteLine($"Кэш перед записью содержит {testCasesCache.Count} элементов:");
                    foreach (var tc in testCasesCache)
                    {
                        Console.WriteLine($"  TestCase: {tc.Name}, ActualIndex={tc.ActualIndex}, ActualValue={tc.ActualValue}, ActualSum={tc.ActualSum}, ActualCube={tc.ActualCube}, Errors={string.Join(",", tc.ActualErrors ?? new List<string>())}");
                    }

                    // Запись в файл
                    int writeRetryCount = 5;
                    int writeRetryDelay = 500;

                    while (writeRetryCount > 0)
                    {
                        try
                        {
                            string updatedJson = JsonConvert.SerializeObject(testCasesCache, Formatting.Indented);
                            File.WriteAllText(FilePath, updatedJson);
                            Console.WriteLine($"Данные успешно сохранены в файл: {FilePath}");
                            break;
                        }
                        catch (IOException ex)
                        {
                            writeRetryCount--;
                            Console.WriteLine($"Ошибка при записи в файл {FilePath}. Попытка {6 - writeRetryCount} из 5. Ошибка: {ex.Message}");
                            Task.Delay(writeRetryDelay).Wait();
                        }
                        catch (JsonException ex)
                        {
                            writeRetryCount--;
                            Console.WriteLine($"Ошибка сериализации JSON для {FilePath}. Попытка {6 - writeRetryCount} из 5. Ошибка: {ex.Message}");
                            Task.Delay(writeRetryDelay).Wait();
                        }
                    }

                    if (writeRetryCount == 0)
                    {
                        Console.WriteLine($"Не удалось записать данные в файл {FilePath}. Кэш содержит {testCasesCache.Count} элементов.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Критическая ошибка при обработке данных для записи в {FilePath}: {ex.Message}");
                }
            }
        }
    }

    // Метод для принудительного завершения обработки очереди
    internal static void FlushQueue()
    {
        if (writeTask != null && !writeTask.IsCompleted)
        {
            Console.WriteLine("Ожидание завершения обработки очереди записи...");
            writeTask.Wait();
            Console.WriteLine("Очередь записи завершена.");
        }
    }
}
