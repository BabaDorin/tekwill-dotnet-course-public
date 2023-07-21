
using Lectia16_2_class_library;

class Program
{
    static void Main()
    {
        var persoana = new Persoana();

        Console.WriteLine(persoana.Public);
        Console.WriteLine(persoana.Private);
        Console.WriteLine(persoana.Protected);
        Console.WriteLine(persoana.Internal);
        Console.WriteLine(persoana.ProtectedInternal);

        var student = new Student();

        Console.WriteLine(student.Public);
        Console.WriteLine(student.Private);
        Console.WriteLine(student.Protected);
        Console.WriteLine(persoana.Internal);
    }
}