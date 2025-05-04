using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat1.Generator
{
    internal class GeneratorRunner
    {
        private readonly string javaPath;
        private readonly string jarPath;
        private readonly string workingDirectory;

        public GeneratorRunner(string jarRelativePath, string javaPath = "java")
        {
            
            string solutionRoot = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;
            workingDirectory = solutionRoot;

            this.javaPath = javaPath;
            jarRelativePath = "/Generator.jar";
            this.jarPath = Path.Combine(solutionRoot, jarRelativePath);

            if (!File.Exists(jarPath))
            {
                throw new FileNotFoundException($"JAR-файл не найден по пути: {jarPath}", jarPath);
            }

            if (!string.IsNullOrEmpty(javaPath))
            {
                this.javaPath = javaPath;
            }
            else
            {
                string? javaHome = Environment.GetEnvironmentVariable("JAVA_HOME");

                if (string.IsNullOrWhiteSpace(javaHome))
                    throw new InvalidOperationException("Переменная окружения JAVA_HOME не установлена.");

                string javaBin = Path.Combine(javaHome, "bin", OperatingSystem.IsWindows() ? "java.exe" : "java");

                if (!File.Exists(javaBin))
                    throw new FileNotFoundException($"Java не найдена по пути: {javaBin}");

                this.javaPath = javaBin;
            }
        }

        public async Task<JavaRunResult> RunAsync(string outputJsonRelativePath = @"Data\data.json")
        {
            string jsonFullPath = Path.Combine(workingDirectory, outputJsonRelativePath);
            string jsonDir = Path.GetDirectoryName(jsonFullPath);

            if (!string.IsNullOrEmpty(jsonDir))
            {
                Directory.CreateDirectory(jsonDir);
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = javaPath,
                Arguments = $"-jar \"{jarPath}\" \"{outputJsonRelativePath}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                WorkingDirectory = workingDirectory // Важно: запускаем JAR в корне проекта
            };

            try
            {
                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                    string output = await process.StandardOutput.ReadToEndAsync();
                    string errors = await process.StandardError.ReadToEndAsync();

                    await process.WaitForExitAsync();

                    bool success = process.ExitCode == 0;
                    bool jsonCreated = File.Exists(jsonFullPath);
                    string jsonContent = jsonCreated ? await File.ReadAllTextAsync(jsonFullPath) : null;

                    return new JavaRunResult
                    {
                        Success = success,
                        Output = output,
                        Errors = errors,
                        ExitCode = process.ExitCode,
                        JsonFilePath = jsonCreated ? jsonFullPath : null,
                        JsonContent = jsonContent
                    };
                }
            }
            catch (Exception ex)
            {
                return new JavaRunResult
                {
                    Success = false,
                    Errors = $"Ошибка при запуске Java-программы: {ex.Message}",
                    ExitCode = -1
                };
            }
        }
    }

    public class JavaRunResult
    {
        public bool Success { get; set; }
        public string Output { get; set; }
        public string Errors { get; set; }
        public int ExitCode { get; set; }
        public string JsonFilePath { get; set; }
        public string JsonContent { get; set; }
    }
}
