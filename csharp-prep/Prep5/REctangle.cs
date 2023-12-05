public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // Using of the override keyword
    public override double GetArea()
    {
        return _length * _width;
    }
}