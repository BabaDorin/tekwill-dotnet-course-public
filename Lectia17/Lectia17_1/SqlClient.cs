namespace Lectia17_1
{
    internal class SqlClient : IDisposable
    {
        public void Dispose()
        {
            CloseConnection();
        }

        public void RunQuery(string sqlQuery)
        {
            OpenConnection();
            // ...
            CloseConnection();
        }

        private void OpenConnection()
        {
            // ....
        }

        private void CloseConnection()
        {
            // ....
        }

    }
}
