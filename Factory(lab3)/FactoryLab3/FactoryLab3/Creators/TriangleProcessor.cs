using FactoryLab3.Params;

namespace FactoryLab3.Creators;

public class TriangleProcessor: Processor<TriangleParams>
{
    protected override IFigure CreateFigure(TriangleParams parameters)
    {
        return new Triangle(parameters.SideA, parameters.SideB, parameters.SideC);
    }
} 