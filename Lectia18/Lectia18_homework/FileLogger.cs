namespace Lectia18_homework
{
    internal class FileLogger : ILogger
    {
        private const string filePath = @"C:\Users\dbaba\OneDrive - ENDAVA\Desktop\logs.txt";

        public void LogError(string message)
        {
            Log($"LogLevelwwqweqweqweqweqweqweqweq: Error. {message}");
        }

        public void LogInformation(string message)
        {
            Log($"LogInformation: Information. {message}");

        }

        public void LogWarning(string message)
        {
            Log($"LogWarning: Warning. {message}");
        }

        private void Log(string message)
        {
            using (var streamWriter = new StreamWriter(filePath, true))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}