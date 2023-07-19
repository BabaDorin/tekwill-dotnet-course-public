namespace Lectia15_2
{
    internal class Automobil : Produs
    {
        public string Marca { get; set; }

        public string Model { get; set; }

        public int AnulProducerii { get; set; }

        public int Cubatura { get; set; }

        public override void CitireDate()
        {
            base.CitireDate();

            Console.Write("Marca: ");
            Marca = Console.ReadLine();

            Console.Write("Model: ");
            Model = Console.ReadLine();

            Console.Write("Anul Producerii: ");
            AnulProducerii = int.Parse(Console.ReadLine());

            Console.Write("Cubatura: ");
            Cubatura = int.Parse(Console.ReadLine());
        }

        public override void AfisareDate()
        {
            base.AfisareDate();
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"AnulProducerii: {AnulProducerii}");
            Console.WriteLine($"Cubatura: {Cubatura}");
        }
    }
}
