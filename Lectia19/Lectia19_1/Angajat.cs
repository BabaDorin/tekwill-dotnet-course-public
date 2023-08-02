namespace Lectia19_1
{
    internal abstract class Angajat
    {
        protected const double SALARIU_MINIM = 10000;

        public string Nume { get; set; }

        public int ExperientaAni { get; set; }

        public virtual double CalculeazaSalariu()
        {
            return SALARIU_MINIM;
        }
    }
}
