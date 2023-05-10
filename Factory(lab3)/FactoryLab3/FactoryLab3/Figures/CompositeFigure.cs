namespace FactoryLab3;

public class CompositeFigure : IFigure
{
    public List<IFigure> Figures { get; set; }

    public CompositeFigure(List<IFigure> figures)
    {
        Figures = figures;
    }

    public double GetArea()
    {
        double area = 0;
        foreach (var figure in Figures)
        {
            area += figure.GetArea();
        }
        return area;
    }

    public double GetPerimeter()
    {
        double perimeter = 0;
        foreach (var figure in Figures)
        {
            perimeter += figure.GetPerimeter();
        }
        return perimeter;
    }

    public IFigure CreateFigure()
    {
        return new CompositeFigure(Figures);
    }
}