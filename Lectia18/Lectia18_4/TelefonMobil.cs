namespace Lectia18_4
{
    internal class TelefonMobil : Produs
    {
        private readonly int rataReducerii = 66;

        public TelefonMobil(double pret) : base(pret)
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
