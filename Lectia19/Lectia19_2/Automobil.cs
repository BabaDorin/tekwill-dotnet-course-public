using Lectia19_2.Motor;
using Lectia19_2.Transmisie;

namespace Lectia19_2
{
    internal class Automobil
    {
        public string Marca { get; set; }

        public string Model { get; set; }

        public int AnulProducerii { get; set; }

        public IMotor Motor { get; set; }

        public ITransmisie Transmisie { get; set; }
    }
}
