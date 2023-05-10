using FactoryLab3.Params;

namespace FactoryLab3.Creators;

public class CircleProcessor : Processor<CircleParams>
{
    protected override IFigure CreateFigure(CircleParams parameters)
    {
        return new Circle(parameters.Radius);
    }
}