using Lectia15_2;

class Program
{
    private static List<Produs> produse;

    static void Main()
    {
        produse = new List<Produs>();

        while (true)
        {
            Console.WriteLine("Meniu:");

            Console.WriteLine("1 - Adaugare produs");
            Console.WriteLine("2 - Vezi produse");
            Console.WriteLine("3 - Eliminare produs");
            Console.WriteLine("4 - Marcare produs ca vandut");

            int optiune = int.Parse(Console.ReadLine());

            switch (optiune)
            {
                case 1: AdaugareProdus(); break;
                case 2: ListeazaProduse(); break;
                case 3: EliminareProdus(); break;
                case 4: MarcareProdusVandut(); break;
                default: Console.WriteLine("Optiune invalida ;("); break;
            }
        }
    }

    private static void MarcareProdusVandut()
    {
        Console.Write("Introdu id-ul produsului: ");
        int id = int.Parse(Console.ReadLine());

        //foreach (var produs in produse)
        //{
        //    if (produs.Id == id)
        //    {
        //        produs.Vandut = true;
        //        break;
        //    }
        //}

        var produs = produse.First(p => p.Id == id);
        produs.Vandut = true;
    }

    private static void CurataLista()
    {
        produse = produse.Where(p => !p.Vandut).ToList();
    }

    private static void EliminareProdus()
    {
        Console.Write("Introdu id-ul produsului: ");
        int id = int.Parse(Console.ReadLine());

        //foreach(var produs in produse)
        //{
        //    if (produs.Id == id)
        //    {
        //        produse.Remove(produs);
        //        break;
        //    }
        //}

        var produs = produse.First(p => p.Id == id);
        produse.Remove(produs);
    }

    private static void ListeazaProduse()
    {
        foreach(var produs in produse)
        {
            produs.AfisareDate();
            Console.WriteLine();
        }
    }

    private static void AdaugareProdus()
    {
        Console.WriteLine("1 - Adaugare imobil");
        Console.WriteLine("2 - Adaugare automobild");

        int optiune = int.Parse(Console.ReadLine());

        switch (optiune)
        {
            case 1:
                var imobil = new Imobil();
                imobil.CitireDate();

                produse.Add(imobil);
                break;
            case 2:
                var automobil = new Automobil();
                automobil.CitireDate();

                produse.Add(automobil);
                break;
            default:
                Console.WriteLine("Optiune invalida ;(");
                break;
        }
    }
}