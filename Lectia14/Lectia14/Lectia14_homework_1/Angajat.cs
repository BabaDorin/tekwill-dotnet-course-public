using System;

// CTRL + R + G

// Creați o clasă numită Angajat care să reprezinte informații despre un angajat.
// Adăugați următoarele proprietăți la clasa Angajat:
// -Nume - pentru a reține numele angajatului
// -	Salariu - pentru a reține salariul angajatului
// -	Departament - pentru a reține departamentul în care lucrează angajatul
// Implementați un constructor pentru clasa Angajat care să primească argumente pentru nume, salariu și departament și să le atribuie proprietăților corespunzătoare.
// Adăugați o metodă numită AfisareDetalii în clasa Angajat care să afișeze numele, salariul și departamentul angajatului.
// Testați clasa Angajat în funcția Main a programului.
// Creați mai mulți obiecte de tip Angajat, specificând valorile pentru nume, salariu și departament.
// Apelați metoda AfisareDetalii pentru fiecare obiect de tip Angajat pentru a afișa detaliile angajaților.

namespace Lectia14_homework_1
{
    internal class Angajat
    {
        public string nume;
        public double salariu;
        public Departament departament;

        public Angajat(string nume, double salariu, Departament departament)
        {
            this.nume = nume;
            this.salariu = salariu;
            this.departament = departament;
        }

        public Angajat()
        {
        }

        public void AfisareDetalii()
        {
            Console.WriteLine($"Nume: {nume}");
            Console.WriteLine($"Salariu: {salariu}");
            Console.WriteLine($"Departament: {departament}");
        }
    }
}
