namespace Lectia15_2
{
    internal class Imobil : Produs
    {
        public double Suprafata { get; set; }

        public int NrEtaje { get; set; }

        public bool PrezentaAscensor { get; set; }

        public override void CitireDate()
        {
            base.CitireDate();

            Console.Write("Suprafata: ");
            Suprafata = double.Parse(Console.ReadLine());

            Console.Write("Nr Etaje: ");
            NrEtaje = int.Parse(Console.ReadLine());

            Console.Write("Prezenta ascensor: ");
            PrezentaAscensor = bool.Parse(Console.ReadLine());
        }

        public override void AfisareDate()
        {
            base.AfisareDate();
            Console.WriteLine($"Suprafata: {Suprafata}");
            Console.WriteLine($"NrEtaje: {NrEtaje}");
            Console.WriteLine($"PrezentaAscensor: {PrezentaAscensor}");
        }
    }
}
