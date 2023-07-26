using System;
using System.Collections.Generic;

namespace Lectia18_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produse = new List<Produs>
            {
                new Calculator(300),
                new Calculator(3000),
                new Imprimata(1000),
                new CameraVideo(1300),
                new TelefonMobil(5300),
            };

            //produse.ForEach(p => p.AplicareReducere());

            foreach(var produs in produse)
            {
                produs.AplicareReducere();

                produs.Pret = 30;
            }

            foreach (var produs in produse)
            {
                produs.AnulareReducere();
            }
        }
    }
}
