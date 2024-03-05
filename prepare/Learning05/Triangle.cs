public class Triangle : Shape
{
    private double _base;
    private double _height;

    public Triangle(string color, double tBase, double height) : base(color)
    {
        _base = tBase;
        _height = height;
    }

    public override double GetArea()
    {
        return (_base * _height) / 2;
    }
}