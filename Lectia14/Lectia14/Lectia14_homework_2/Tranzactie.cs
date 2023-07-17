namespace Lectia14_homework_2
{
    internal class Tranzactie
    {
        public DateTime data;
        public decimal suma;

        public Tranzactie(decimal suma)
        {
            data = DateTime.UtcNow;
            this.suma = suma;
        }
    }
}
