namespace FactoryLab3;

public class Triangle : IFigure
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }

    public double GetArea()
    {
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public IFigure CreateFigure()
    {
        return new Triangle(SideA, SideB, SideC);
    }
}