public class Person
{
    public string name;

    public Person(string name)
    {
        this.name = name;
    }

    public Person(Person original)
    {
        this.name = original.name;
    }

    ~Person()
    {
        Console.WriteLine("Memoria a fost dealocata");
    }

}
