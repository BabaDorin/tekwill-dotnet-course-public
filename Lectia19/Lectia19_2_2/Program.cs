using Lectia19_2;
using Lectia19_2.Motor;
using Lectia19_2.Transmisie;
using System;
using System.Collections.Generic;

namespace Lectia19_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hondaCivicManual = new Automobil<MotorArdereInterna, TransmisieManuala>(
                "Honda",
                "Civic",
                2012);

            var hondaCivicManual = new Automobil<MotorArdereInterna, TransmisieManuala>(
                "Honda",
                "Civic",
                2012);
            Console.WriteLine(hondaCivicManual.Motor.Info());

            var hondaCivicAutomat = new Automobil<MotorArdereInterna, TransmisieAutomata>(
                "Honda",
                "Civic",
                2012);
            Console.WriteLine(hondaCivicAutomat.Motor.Info());

            var teslaModel3 = new Automobil<MotorElectric, TransmisieAutomata>(
                "Tesla",
                "3",
                2020);
            Console.WriteLine(teslaModel3.Motor.Info());

            //var automobile = new List<Automobil<IMotor, ITransmisie>>
            //{
            //    hondaCivicAutomat,
            //    hondaCivicManual,
            //    teslaModel3
            //};

            //automobile.ForEach(auto =>
            //{
            //    Console.WriteLine($"Marca: {auto.Marca}");
            //    Console.WriteLine($"Model: {auto.Model}");
            //    Console.WriteLine($"Anul producerii: {auto.AnulProducerii}");
            //    Console.WriteLine($"Propulsie: {auto.Motor.Info()}");
            //    Console.WriteLine($"Transmisie: {auto.Transmisie.Info()}");
            //    Console.WriteLine();
            //});
        }
    }
}
