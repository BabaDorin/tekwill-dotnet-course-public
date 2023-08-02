namespace Lectia19_1
{
    internal class Contabil : Angajat
    {
        public override double CalculeazaSalariu()
        {
            return ExperientaAni > 0
                ? SALARIU_MINIM + SALARIU_MINIM * 0.2 * ExperientaAni
                : SALARIU_MINIM;
        }
    }
}
