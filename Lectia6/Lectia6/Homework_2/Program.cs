//  2.Gestionarea informațiilor despre studenți:
//•	Definiți o structură pentru a reprezenta informațiile despre un student
//  (nume, vârstă, specializare, anul de studii).
//•	Solicitați utilizatorului să introducă informațiile despre un student de la tastatură.
//•	Utilizați enumerațiile pentru a indica anul de studii. Valori admisibile:
//  I, II, III, IV, V, VI.
//•	Utilizați structura pentru a stoca aceste informații și pentru a le accesa ulterior.
//•	Afișați informațiile despre student la ecran.

enum AnulDeStudii
{
    I,
    II,
    III,
    IV,
    V,
    VI
}

struct Student
{
    public string nume;
    public int varsta;
    public string specializare;
    public AnulDeStudii anulDeStudii;

    public void AfisareInformatii()
    {
        Console.WriteLine(nume);
        Console.WriteLine(varsta);
        Console.WriteLine(specializare);
        Console.WriteLine(anulDeStudii);
    }
}

public class Program
{
    static void Main()
    {
        Console.Write("Nume: ");
        string nume = Console.ReadLine()!;

        Console.Write("Varsta: ");
        int varsta = int.Parse(Console.ReadLine()!);

        Console.Write("Specializarea: ");
        string specializare = Console.ReadLine()!;

        Console.Write("Anul de studii: ");
        var anulDeStudiiText = Console.ReadLine();
        AnulDeStudii anulDeStudii = Enum.Parse<AnulDeStudii>(anulDeStudiiText);

        var student = new Student
        {
            nume = nume,
            anulDeStudii = anulDeStudii,
            specializare = specializare,
            varsta = varsta
        };

        switch (student.specializare)
        {
            case "Tehnologii informationale":
                Console.WriteLine("TI");
                break;
            case "Ingineria software":
                Console.WriteLine("SW");
                break;
            case "Retele si calculatoare":
                Console.WriteLine("RC");
                break;
            default: throw new Exception("Specializarea este invalida");
        }

        student.AfisareInformatii();
    }
}
