using System;

interface IPerson
{
    string GetInfo();
}

class Student : IPerson
{
    public string GetInfo()
    {
        throw new NotImplementedException();
    }
}

class Teacher : IPerson
{
    public string GetInfo()
    {
        throw new NotImplementedException();
    }
}

class Logger
{
    public void Log<T>(T data) where T : IPerson
    {
        Console.WriteLine($"Info: {data.GetInfo()}");
    }
}

class Program
{
    static void Main()
    {
        Logger logger = new Logger();

        logger.Log("This is a string message.");
        logger.Log(42);
        logger.Log(3.14);
        logger.Log(DateTime.Now);

        var student = new Student();
        var teacher = new Teacher();

        logger.Log(student);
        logger.Log(teacher);
    }
}
