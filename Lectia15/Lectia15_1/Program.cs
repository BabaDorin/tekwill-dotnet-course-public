using Lectia15_1;

class Program
{
    static void Main()
    {
        var dog = new Dog();
        dog.Eat();
        dog.Bark();

        var cat = new Cat();
        cat.Eat();
        cat.Meaw();

        // Upcasting
        List<Animal> animals = new List<Animal>();
        animals.Add(dog);
        animals.Add(cat);

        foreach(var animal in animals)
        {
            animal.Eat();
        }
    }
}