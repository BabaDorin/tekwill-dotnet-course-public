namespace Lectia18_homework
{
    internal class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"LogLevel: Error. {message}");
        }

        public void LogInformation(string message)
        {
            Console.WriteLine($"LogLevel: Information. {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"LogLevel: Warning. {message}");
        }
    }
}
