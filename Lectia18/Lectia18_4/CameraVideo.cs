namespace Lectia18_4
{
    internal class CameraVideo : Produs
    {
        private readonly int rataReducerii = 25;

        public CameraVideo(double pret) : base(pret)
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
