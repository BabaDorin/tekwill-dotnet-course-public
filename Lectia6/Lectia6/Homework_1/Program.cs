//1.Gestionarea datelor de naștere:
// •	Solicitați utilizatorului să introducă data sa de naștere (ziua, luna și anul) de la tastatură.
// •	Utilizați tipul de date DateTime pentru a stoca această valoare.
// •	Calculați vârsta utilizatorului pe baza datei de naștere și data curentă (utilizând metodele și proprietățile din clasa DateTime).
// •	Afișați vârsta utilizatorului la ecran.

// Comment: CTRL + K + C
// Uncomment: CTRL + K + U

public class Program
{
    static void Main()
    {
        Console.Write("Introduceti data Dvs. de nastere (In formatul an/luna/zi): ");
        string? dataNasteriiText = Console.ReadLine(); // null forgiveness operator

        DateTime dataNasterii;

        if(DateTime.TryParse(dataNasteriiText, out dataNasterii))
        {
            var dataCurenta = DateTime.Now;

            var diferentaDeTimp = dataCurenta - dataNasterii;

            var ani = (int)(diferentaDeTimp.TotalDays / 365);

            Console.WriteLine($"Varsta: {ani} ani");
        }
        else
        {
            Console.WriteLine("Ati introdus o data invalida.");
        }
    }
}
