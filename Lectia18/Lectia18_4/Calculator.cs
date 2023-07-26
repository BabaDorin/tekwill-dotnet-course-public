namespace Lectia18_4
{
    internal class Calculator : Produs
    {
        private readonly int rataReducerii = 30;

        public Calculator(double pret) : base(pret)
        {
        }

        public override void AnulareReducere()
        {
            Pret = Pret / (1 - rataReducerii / 100);
        }

        public override void AplicareReducere()
        {
            Pret = Pret - (Pret / 100 * rataReducerii);
        }
    }
}
