namespace Lectia17_hw1
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2); // pi * r^2
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
