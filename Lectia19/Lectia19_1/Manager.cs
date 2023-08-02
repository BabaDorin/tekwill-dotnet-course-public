namespace Lectia19_1
{
    internal class Manager : Angajat
    {
        public override double CalculeazaSalariu()
        {
            return ExperientaAni > 0
                ? SALARIU_MINIM + SALARIU_MINIM * 0.3 * ExperientaAni
                : SALARIU_MINIM;
        }
    }
}
