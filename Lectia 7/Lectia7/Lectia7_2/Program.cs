class Program
{
    struct Contact
    {
        public string name;
        public string phoneNumber;
    }

    static void Main()
    {
        var phoneBook = new Contact[3]
        {
            new Contact()
            {
                name = "Ion",
                phoneNumber = "+37323441"
            },
            new Contact()
            {
                name = "Andrei",
                phoneNumber = "+37323442"
            },
            new Contact()
            {
                name = "Alex",
                phoneNumber = "+37323443"
            },
        };

        Console.WriteLine("Lista de contacte:");
        for (int i = 0; i < phoneBook.Length; i++)
        {
            Console.WriteLine(phoneBook[i].name);
        }

        Console.Write("Introduceti numele persoanei pentru a vedea numarul de telefon: ");
        string searchName = Console.ReadLine();

        for (int i = 0; i < phoneBook.Length; i++)
        {
            if (phoneBook[i].name == searchName)
            {
                Console.WriteLine(phoneBook[i].phoneNumber);
            }
        }

        Console.WriteLine(phoneBook.First(contact => contact.name == searchName).phoneNumber);
    }
}