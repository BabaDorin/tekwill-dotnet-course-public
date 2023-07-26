using Lectia17_1;

class Program
{
    static void Main()
    {
        //var colectie1 = new List<int> { 1, 2, 3, 4 };
        //var colectie2 = new int[] { 1, 2, 3 };

        //UseOfIenumerable.AfisareNumerePare(colectie1);
        //UseOfIenumerable.AfisareNumerePare(colectie2);

        using (var databaseProvider = new SqlDatabaseProvider())
        {
            var orderManager = new OrderManager(databaseProvider);
        }
    }
}