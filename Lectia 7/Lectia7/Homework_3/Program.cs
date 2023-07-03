class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Meniu: ");
            Console.WriteLine("1 - Supa");
            Console.WriteLine("2 - Salata Caesar");
            Console.WriteLine("3 - Salata Greceasca");
            Console.WriteLine("4 - Inghetata");

            Console.WriteLine("Introduceti optiunea: ");
            int optiune = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (optiune)
            {
                case 1:
                    Console.WriteLine("\nSupa:\n\tIngrediente...\n\tDescriere...\n\tPret: 203");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("\nSalata Caesar: Ingrediente... Descriere...");
                    Console.WriteLine("Pret: 203");
                    break;
                case 3:
                    Console.WriteLine("\nSalata Greceasca: Ingrediente... Descriere...");
                    Console.WriteLine("Pret: 203");
                    break;
                case 4:
                    Console.WriteLine("\nInghetata: Ingrediente... Descriere...");
                    Console.WriteLine("Pret: 203");
                    break;
                default:
                    Console.WriteLine("Optiune invalida.");
                    break;
            }
        }
    }
}