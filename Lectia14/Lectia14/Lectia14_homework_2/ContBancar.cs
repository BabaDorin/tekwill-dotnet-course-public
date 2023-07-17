using System.Transactions;

namespace Lectia14_homework_2
{
    internal class ContBancar
    {
        public readonly DateTime dataCrearii;
        public Persoana detinator;
        public readonly string numar; // 2344 3454 3456 3435
        public Moneda moneda;
        private string pin;
        private List<Tranzactie> istoricTranzactii;

        public ContBancar(Persoana detinator, string numar, Moneda moneda, string pin)
        {
            this.detinator = detinator;
            this.numar = numar;
            this.moneda = moneda;
            this.pin = pin;

            istoricTranzactii = new List<Tranzactie>();
            dataCrearii = DateTime.UtcNow;
        }

        public void Alimentare(decimal suma)
        {
            var tranzactie = new Tranzactie(suma);
            istoricTranzactii.Add(tranzactie);

            Console.WriteLine();
            Console.WriteLine($"Contul a fost alimentat cu {suma} {moneda}.");
            Console.WriteLine($"Soldul curent: {DeterminareSold()}");
        }

        public void Extragere(decimal suma)
        {
            if (suma > DeterminareSold())
            {
                Console.WriteLine();
                Console.WriteLine($"Tranzactie nereusita de {suma} {moneda}. Fonduri insuficiente.");
                Console.WriteLine($"Soldul curent: {DeterminareSold()}");

                return;
            }

            var tranzactie = new Tranzactie(-suma);

            istoricTranzactii.Add(tranzactie);

            Console.WriteLine();
            Console.WriteLine($"Din cont au fost extrasi {suma} {moneda}.");
            Console.WriteLine($"Soldul curent: {DeterminareSold()}");
        }

        public decimal DeterminareSold()
        {
            return istoricTranzactii.Sum(t => t.suma);
        }
    }
}
