using System.Drawing;

namespace Lectia15_1
{
    internal class Produs
    {
        public string Id { get; set; }

        public double Pret { get; set; }

        public Produs(string id, double pret)
        {
            Id = id;
            Pret = pret;
        }
    }

    internal class Calculator : Produs
    {
        public string Model { get; set; }

        public int MemorieRam { get; set; }

        public Calculator(string id, double pret, string model, int memorieRam)
            : base(id, pret)
        {
            Model = model;
            MemorieRam = memorieRam;
        }
    }

    internal class Imprimanta : Produs
    {
        public bool Color { get; set; }

        public Imprimanta()
            : base("abc", 2345)
        {
            Color = false;
        }
    }
}
