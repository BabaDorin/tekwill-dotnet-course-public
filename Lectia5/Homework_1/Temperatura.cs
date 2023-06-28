namespace Homework_1
{
    public class Temperatura
    {
        public static void ConversiaCtoF()

        {
            Console.WriteLine("Introduceti temperatura in grade Celsius");
            float celsius = float.Parse(Console.ReadLine());

            double fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine("Grade in Fahrenheit sunt: " + fahrenheit);
        }
    }
}
