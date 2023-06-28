namespace Homework_1
{
    public class MasaCorporala
    {
        public static void CalculareaIMC()

        {
            Console.WriteLine("Introdu greutatea corporala (kg): ");
            int greutate = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu inaltimea (m): ");
            float inaltime = float.Parse(Console.ReadLine());

            float IMC = greutate / (inaltime * inaltime);
            Console.WriteLine("Indeciul de masa corporala este: " + IMC);
        }
    }
}
