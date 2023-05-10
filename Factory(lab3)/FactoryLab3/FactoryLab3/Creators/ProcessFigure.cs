using FactoryLab3.Params;

namespace FactoryLab3.Creators;

public abstract class Processor<T> where T : FigureParams
{
    protected abstract IFigure CreateFigure(T parameters);

    public IFigure Process(T parameters)
    {
        var figure = CreateFigure(parameters);
        Console.WriteLine($"Area:{figure.GetArea()}, Perimeter:{figure.GetPerimeter()}");
        return figure;
    }
}
