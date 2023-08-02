using Lectia19_2.Motor;
using Lectia19_2.Transmisie;

namespace Lectia19_2
{
    // var auto = new Automobil<int, string>
    // var auto = new Automobil<MotorCuArdereInterna, Tr.Manuakla>
    internal class Automobil<TMotor, TTransmisie> 
        where TMotor : IMotor, new()
        where TTransmisie : ITransmisie, new()
    {
        public string Marca { get; set; }

        public string Model { get; set; }

        public int AnulProducerii { get; set; }

        public TMotor Motor { get; set; }

        public TTransmisie Transmisie { get; set; }

        public Automobil(string marca, string model, int anulProducerii)
        {
            Marca = marca;
            Model = model;
            AnulProducerii = anulProducerii;
            Motor = new TMotor();
            Transmisie = new TTransmisie();
        }
    }
}
