using Exceptions;

namespace Lectia9_9
{
    class Pr
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            if (year > DateTime.Now.Year)
            {
                throw new InvalidYearException();
            }

            if (year < 1800)
            {
                throw new InvalidYearException();
            }
        }
    }
}
