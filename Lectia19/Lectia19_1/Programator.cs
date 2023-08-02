using System.Collections.Generic;
using System.Linq;

namespace Lectia19_1
{
    internal class Programator : Angajat
    {
        public List<string> LimbajeDeProgramare { get; set; }

        public override double CalculeazaSalariu()
        {
            var rezultat = SALARIU_MINIM;

            var nrLimbajeNonCs = LimbajeDeProgramare
                .Where(limbaj => limbaj != "C#")
                .Count();

            if (nrLimbajeNonCs > 0)
            {
                rezultat += nrLimbajeNonCs * 0.5 * SALARIU_MINIM;
            }

            if (LimbajeDeProgramare.Any(limbaj => limbaj == "C#"))
            {
                rezultat += 4 * SALARIU_MINIM;
            }

            return rezultat;
        }
    }
}
