namespace FactoryLab3;

public interface IFigure
{
    public double GetArea();
    public double GetPerimeter();
    public IFigure CreateFigure();
}