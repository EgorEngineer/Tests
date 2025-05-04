using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using Laborat1.Generator;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Laborat1.JSONWorks
{
    public static class GetData
    {
        // Static field to hold all test cases, loaded only once
        private static JArray allTestCases = null;
        private static readonly object lockObject = new object();
        private static bool generatorRan = false;
        private static readonly string jsonRelativePath = @"Data/data.json";
        private static readonly string jarRelativePath = @"Generator/Generator.jar"; 

        private static string GetJsonPath()
        {
            string solutionRoot = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;
            return Path.Combine(solutionRoot, jsonRelativePath);
        }

        // Run generator once at program startup
        static GetData()
        {
            RunGeneratorOnce();
        }

        private static void RunGeneratorOnce()
        {
            lock (lockObject)
            {
                if (!generatorRan)
                {
                    try
                    {
                        // Create and run the generator
                        var generator = new GeneratorRunner(jarRelativePath);
                        var result = generator.RunAsync(jsonRelativePath).GetAwaiter().GetResult();

                        if (!result.Success)
                        {
                            throw new Exception($"Generator failed with error: {result.Errors}, Exit code: {result.ExitCode}");
                        }

                        LoadJsonData();
                        generatorRan = true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error running generator: {ex.Message}");
                        throw new InvalidOperationException($"Failed to generate test data: {ex.Message}", ex);
                    }
                }
            }
        }

        private static void LoadJsonData()
        {
            string jsonPath = GetJsonPath();
            if (!File.Exists(jsonPath))
            {
                throw new FileNotFoundException($"JSON file not found at path: {jsonPath}");
            }

            string jsonContent;
            using (var fileStream = new FileStream(jsonPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = new StreamReader(fileStream))
            {
                jsonContent = reader.ReadToEnd();
            }
            allTestCases = JArray.Parse(jsonContent);
        }

        public static IEnumerable<object[]> GetTestData(string testCaseName)
        {
            var testCase = allTestCases.FirstOrDefault(tc => tc["name"]?.ToString() == testCaseName);
            if (testCase == null)
            {
                throw new KeyNotFoundException($"Тестовый случай {testCaseName} не найден в data.json");
            }

            int[] input = testCase["input"]?.ToObject<int[]>();
            int expectedIndex = testCase["expectedIndex"]?.ToObject<int>() ?? -1;
            int expectedValue = testCase["expectedValue"]?.ToObject<int>() ?? 0;
            long expectedSum = testCase["expectedSum"]?.ToObject<long>() ?? 0;
            long expectedCube = testCase["expectedCube"]?.ToObject<long>() ?? 0;
            int[] expectedTransformedArray = testCase["expectedTransformedArray"]?.ToObject<int[]>();
            List<string> expectedErrors = testCase["expectedErrors"]?.ToObject<List<string>>() ?? new List<string>();

            yield return new object[] { input, expectedIndex, expectedValue, expectedSum, expectedCube, expectedTransformedArray, expectedErrors };
        }
    }
}