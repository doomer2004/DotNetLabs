using FactoryLab3.Creators;
using FactoryLab3.Params;

namespace FactoryLab3;

public class CompositeFigureProcessor : Processor<CompositeFigureParams>
{
    protected override IFigure CreateFigure(CompositeFigureParams parameters)
    {
        return new CompositeFigure(parameters.Figures);
    }
}