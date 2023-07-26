namespace Lectia17_hw1
{
    public class Rectangle : Shape
    {
        public double Length { get; private set; }
        public double Width { get; private set; }

        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double CalculateArea() => Length * Width;

        public override double CalculatePerimeter() => 2 * (Width + Length);
    }
}
