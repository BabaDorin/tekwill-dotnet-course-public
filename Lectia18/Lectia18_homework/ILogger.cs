namespace Lectia18_homework
{
    internal interface ILogger
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
