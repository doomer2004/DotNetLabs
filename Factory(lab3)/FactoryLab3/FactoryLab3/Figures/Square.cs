namespace FactoryLab3;

public class Square : IFigure
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public double GetArea()
    {
        return Side * Side;
    }

    public double GetPerimeter()
    {
        return 4 * Side;
    }

    public IFigure CreateFigure()
    {
        return new Square(Side);
    }
}