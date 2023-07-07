class Pr
{
    struct Person
    {
        public string name;
        public int age;
        public string occupation;
    }

    static void Main()
    {
        var persons = new Person[]
        {
            new Person() { name = "Ion", age = 20, occupation = "Marketing" },
            new Person() { name = "Andrei", age = 30, occupation = "Vanzari" },
            new Person() { name = "Alex", age = 40, occupation = "Sofer" },
        };

        var occupation = "sOfEr";

        foreach(var person in persons)
        {
            if (person.occupation.ToUpper() == occupation.ToUpper())
            {
                Console.WriteLine(person.name);
                break;
            }
        }

        // Utilizand LINQ
        persons.Where(p => p.occupation.ToUpper() == occupation.ToUpper())
            .ToList()
            .ForEach(p => Console.WriteLine(p.name));
    }
}