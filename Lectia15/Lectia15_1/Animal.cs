namespace Lectia15_1
{
    // Clasa de baza
    // Clasa parinte
    // Superclasa
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Clasa derivata
    // Clasa copil
    public class Dog : Animal
    {


        public override void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    public class Cat : Animal
    {
        public void Meaw()
        {
            Console.WriteLine("Cat is meaweing.");
        }
    }
}
