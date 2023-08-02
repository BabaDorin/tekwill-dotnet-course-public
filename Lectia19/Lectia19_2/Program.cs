using Lectia19_2.Motor;
using Lectia19_2.Transmisie;
using System;
using System.Collections.Generic;

namespace Lectia19_2
{
    //    Elaborati o aplicatie pentru a gestiona o colectie de automobile.
    // Automobilele pot avea propulsie electrica sau pe ardere interna.
    // Metoda Info al clasei Motor va afisa informatia corespunzatoare tipului de motor:
    // - Masina are propulsie electrica
    // - Masina are propulsie cu ardere interna

    // Automobilele pot avea cutii manuale sau automate.
    // Metoda Info al clasei Transmisie va afisa informatia corespunzatoare tipului de transmisie:
    // - Masina este echipata cu transmisie manuala
    // - Masina este echipata cu transmisie automata

    // Clasa Automobil va contine urmatoare proprietati:
    // Marca
    // Model
    // Anul Producerii
    // Motor
    // Transmisie

    internal class Program
    {
        static void Main(string[] args)
        {
            var hondaCivicManual = new Automobil
            {
                AnulProducerii = 2012,
                Marca = "Honda",
                Model = "Civic",
                Motor = new MotorArdereInterna(),
                Transmisie = new TransmisieManuala()
            };

            var hondaCivicAutomat = new Automobil
            {
                AnulProducerii = 2012,
                Marca = "Honda",
                Model = "Civic",
                Motor = new MotorArdereInterna(),
                Transmisie = new TransmisieAutomata()
            };

            var teslaModel3 = new Automobil
            {
                AnulProducerii = 2020,
                Marca = "Tesla",
                Model = "3",
                Motor = new MotorElectric(),
                Transmisie = new TransmisieAutomata()
            };

            var automobile = new List<Automobil>
            {
                hondaCivicAutomat,
                hondaCivicManual,
                teslaModel3
            };

            automobile.ForEach(auto =>
            {
                Console.WriteLine($"Marca: {auto.Marca}");
                Console.WriteLine($"Model: {auto.Model}");
                Console.WriteLine($"Anul producerii: {auto.AnulProducerii}");
                Console.WriteLine($"Propulsie: {auto.Motor.Info()}");
                Console.WriteLine($"Transmisie: {auto.Transmisie.Info()}");
                Console.WriteLine();
            });
        }
    }
}
