class Program
{
    static void Main()
    {
        var originalPerson = new Person("Ion");

        var clonedPersonRight = new Person(originalPerson);

        clonedPersonRight.name = "Andrei";
    }
}