namespace FactoryLab3;

public class Circle : IFigure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public IFigure CreateFigure()
    {
        return new Circle(Radius);
    }
}