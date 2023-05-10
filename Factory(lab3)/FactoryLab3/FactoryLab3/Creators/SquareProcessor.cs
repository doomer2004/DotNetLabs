using FactoryLab3.Params;

namespace FactoryLab3.Creators;

public class SquareProcessor : Processor<SquareParams>
{
    protected override IFigure CreateFigure(SquareParams parameters)
    {
        return new Square(parameters.Side);
    }
}