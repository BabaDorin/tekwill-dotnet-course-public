class Program
{
    static void Main()
    {
        Carte carte1 = new Carte { Nume = "Harry Potter", Autor = "J.K. Rowling", Pret = 50.99 };
        Carte carte2 = new Carte { Nume = "Sherlock Holmes", Autor = "Arthur Conan Doyle", Pret = 45.50 };

        Electrocasnic electrocasnic1 = new Electrocasnic { Nume = "Televizor", Producator = "Samsung", Pret = 2000.00 };
        Electrocasnic electrocasnic2 = new Electrocasnic { Nume = "Frigider", Producator = "Bosch", Pret = 2500.00 };

        carte1.Afisare(); // Va afișa: "Carte: Harry Potter, Autor: J.K. Rowling, Pret: 50.99 lei"
        carte2.Afisare(); // Va afișa: "Carte: Sherlock Holmes, Autor: Arthur Conan Doyle, Pret: 45.50 lei"
        electrocasnic1.Afisare(); // Va afișa: "Electrocasnic: Televizor, Producator: Samsung, Pret: 2000.00 lei"
        electrocasnic2.Afisare(); // Va afișa: "Electrocasnic: Frigider, Producator: Bosch, Pret: 2500.00 lei"

        List<Produs> produse = new List<Produs>
        {
            carte1, carte2, electrocasnic1, electrocasnic2
        };

        for (int i = 0; i < produse.Count; i++)
        {
            produse[i].Afisare();
        }
    }
}
