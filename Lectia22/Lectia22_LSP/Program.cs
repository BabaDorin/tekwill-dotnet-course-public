// Clasa de bază
abstract class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

// Clasa derivată
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
}

// Clasa derivată
class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape1 = new Rectangle { Width = 5, Height = 10 };
        Shape shape2 = new Circle { Radius = 7 };

        CalculateAndPrintArea(shape1);
        CalculateAndPrintArea(shape2);
    }

    static void CalculateAndPrintArea(Shape shape)
    {
        double area = shape.Area();
        Console.WriteLine($"Area: {area}");
    }
}
