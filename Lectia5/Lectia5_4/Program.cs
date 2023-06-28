class Program
{
    struct Persoana
    {
        public string nume;
        public string prenume;
        public DateTime dataNasterii;
        public string cetatenia;

        public void AfiseazaInformatii()
        {
            Console.WriteLine(nume);
            Console.WriteLine(prenume);
            Console.WriteLine(dataNasterii);
            Console.WriteLine(cetatenia);
        }
    }

    struct Apartament
    {
        public double metriPatrati;
        public double pret;
        public Persoana proprietar;
        public string adresa;
    }

    static void Main()
    {
        // Ion
        var ion = new Persoana
        {
            nume = "Ion",
            prenume = "ASD",
            dataNasterii = DateTime.Now - TimeSpan.FromDays(40 * 365),
            cetatenia = "Moldovean"
        };

        ion.cetatenia = "Roman";

        ion.AfiseazaInformatii();

        // Andrei
        var andrei = new Persoana
        {
            nume = "Andrei",
            prenume = "ASD",
            dataNasterii = DateTime.Now - TimeSpan.FromDays(66 * 365),
            cetatenia = "Roman"
        };

        andrei.AfiseazaInformatii();

        var apartamentulLuiIon = new Apartament
        {
            adresa = "Strada arborilor",
            metriPatrati = 52,
            pret = 94000,
            proprietar = new Persoana
            {
                nume = "Alexei",
            }
        };
    }
}