using System;

class Program
{
    static void Main()
    {
        var car = new Car();
    }
}

// Clasa abstractă care reprezintă o mașină
public abstract class Car
{
    // Atributele caracteristice unei mașini
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Metodă abstractă pentru a accelera
    public abstract void Accelerate();

    // Metodă abstractă pentru a frâna
    public abstract void Brake();
}

// Clasa derivată "SportsCar" (Mașină sport) care moștenește clasa "Car"
public class SportsCar : Car
{
    // Constructor
    public SportsCar(string make, string model, int year) : base(make, model, year)
    {
    }

    // Implementarea metodei "Accelerate" specifică pentru mașinile sport
    public override void Accelerate()
    {
        Console.WriteLine($"The {Make} {Model} is accelerating rapidly!");
    }

    // Implementarea metodei "Brake" specifică pentru mașinile sport
    public override void Brake()
    {
        Console.WriteLine($"The {Make} {Model} has powerful brakes!");
    }
}

// Clasa derivată "FamilyCar" (Mașină de familie) care moștenește clasa "Car"
public class FamilyCar : Car
{
    // Constructor
    public FamilyCar(string make, string model, int year) : base(make, model, year)
    {
    }

    // Implementarea metodei "Accelerate" specifică pentru mașinile de familie
    public override void Accelerate()
    {
        Console.WriteLine($"The {Make} {Model} is accelerating smoothly.");
    }

    // Implementarea metodei "Brake" specifică pentru mașinile de familie
    public override void Brake()
    {
        Console.WriteLine($"The {Make} {Model} has a comfortable braking system.");
    }
}

public class Program
{
    public static void Main()
    {
        // Creăm obiecte de tip mașină sport și mașină de familie
        Car sportsCar = new SportsCar("Ferrari", "488 GTB", 2022);
        Car familyCar = new FamilyCar("Toyota", "Camry", 2023);

        List<Car> cars = new List<Car>
        {
            sportsCar, familyCar
        };

        foreach(var car in cars)
        {
            car.Accelerate();
            car.Brake();
        }

        // Accelerăm și frânăm mașina sport
        sportsCar.Accelerate();
        sportsCar.Brake();

        // Accelerăm și frânăm mașina de familie
        familyCar.Accelerate();
        familyCar.Brake();
    }
}
