namespace Lectia18_4
{
    internal abstract class Produs
    {
        public double Pret { get; protected set; }

        public Produs(double pret)
        {
            Pret = pret;
        }

        public abstract void AplicareReducere();

        public abstract void AnulareReducere();
    }
}
