public interface IAnimal
{
    public void Speak();
}

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

public class Cow : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Moo");
    }
}

public class Program
{
    public static void Main()
    {
        MakeAnimalSpeak(new Dog());
        MakeAnimalSpeak(new Cat());
        MakeAnimalSpeak(new Cow());
    }

    public static void MakeAnimalSpeak(IAnimal animal)
    {
        animal.Speak();
    }
}
