using Lectia17_hw1;

class Program
{
    static void Main()
    {
        var shape1 = new Circle(30);
        var shape2 = new Rectangle(30, 50);

        var shapes = new List<Shape>()
        {
            shape1, shape2,
        };

        Console.WriteLine(shapes.Sum(s => s.CalculatePerimeter()));
        Console.WriteLine(shapes.Sum(s => s.CalculateArea()));
    }
}
