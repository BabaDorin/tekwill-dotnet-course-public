using System.Collections.Generic;
using System;

namespace Lectia19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var angajati = new List<Angajat>
            {
                new Manager
                {
                    ExperientaAni = 4,
                    Nume = "Andrei Bosu"
                },
                new Contabil
                {
                    Nume = "Alexei",
                    ExperientaAni = 3
                },
                new Programator
                {
                    LimbajeDeProgramare = new List<string>
                    {
                        "php",
                        "javascript",
                        "C#"
                    },
                    Nume = "Sava",
                    ExperientaAni = 2
                }
            };

            foreach(var angajat in angajati)
            {
                Console.WriteLine(angajat.Nume);
                Console.WriteLine(angajat.CalculeazaSalariu());
                Console.WriteLine();
            }
        }
    }
}
