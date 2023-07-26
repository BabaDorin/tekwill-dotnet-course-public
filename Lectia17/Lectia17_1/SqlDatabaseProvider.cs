namespace Lectia17_1
{
    // Interface segregation
    internal class SqlDatabaseProvider : IDatabaseProvider
    {
        public void Add(Order order)
        {
            using(var sqlClient = new SqlClient())
            {
                var query = $"insert into orders (id) values {order.Id}";
                sqlClient.RunQuery(query);
            }

            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            using (var sqlClient = new SqlClient())
            {
                var query = $"delete from orders where id = {id}";
                sqlClient.RunQuery(query);
            }

            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            OpenConnection();
            // select * from orders where id == id
            CloseConnection();

            throw new NotImplementedException();
        }
    }
}
