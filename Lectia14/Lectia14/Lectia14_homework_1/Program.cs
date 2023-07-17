// Creați o clasă numită Angajat care să reprezinte informații despre un angajat.
// Adăugați următoarele proprietăți la clasa Angajat:
// -Nume - pentru a reține numele angajatului
// -	Salariu - pentru a reține salariul angajatului
// -	Departament - pentru a reține departamentul în care lucrează angajatul
// Implementați un constructor pentru clasa Angajat care să primească argumente pentru nume, salariu și departament și să le atribuie proprietăților corespunzătoare.
// Adăugați o metodă numită AfisareDetalii în clasa Angajat care să afișeze numele, salariul și departamentul angajatului.
// Testați clasa Angajat în funcția Main a programului.
// Creați mai multe obiecte de tip Angajat, specificând valorile pentru nume, salariu și departament.
// Apelați metoda AfisareDetalii pentru fiecare obiect de tip Angajat pentru a afișa detaliile angajaților.

using Lectia14_homework_1;
using System;

class Program
{
    static void Main()
    {
        var angajatIon = new Angajat("Ion", 5003.23, Departament.Management);
        angajatIon.AfisareDetalii();

        Console.WriteLine();

        var angajatImplicit = new Angajat();
        angajatImplicit.AfisareDetalii();

        Console.WriteLine();

        var angajatAndrei = new Angajat()
        {
            nume = "Andrei",
            departament = Departament.Marketing,
            salariu = 34442.1
        };
        angajatAndrei.AfisareDetalii();
    }
}
