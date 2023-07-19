namespace Lectia15_2
{
    internal class Produs
    {
        public int Id { get; set; }

        public double Pret { get; set; }

        public string Denumire { get; set; }

        public bool Vandut { get; set; }

        public string Descriere { get; set; }

        public DateTime DataAdaugare { get; set; }

        public virtual void CitireDate()
        {
            Id = new Random().Next(0, 1000000);

            Console.Write("Pret: ");
            Pret = double.Parse(Console.ReadLine());

            Console.Write("Denumire: ");
            Denumire = Console.ReadLine();

            Vandut = false;

            Console.Write("Descriere: ");
            Descriere = Console.ReadLine();

            DataAdaugare = DateTime.UtcNow;
        }

        public virtual void AfisareDate()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Pret: {Pret}");
            Console.WriteLine($"Denumire: {Denumire}");
            Console.WriteLine($"Vandut: {Vandut}");
            Console.WriteLine($"Descriere: {Descriere}");
            Console.WriteLine($"DataAdaugare: {DataAdaugare}");
        }
    }
}
