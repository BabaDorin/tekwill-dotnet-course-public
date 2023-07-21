namespace Lectia16_4_logger
{
    public class UserManager
    {
        private ILogger _logger;

        public UserManager(ILogger logger)
        {
            _logger = logger;
        }

        public void LogIn(string username, string password)
        {
            _logger.LogInfo("trying to log in: " + username);
        }
    }
}
