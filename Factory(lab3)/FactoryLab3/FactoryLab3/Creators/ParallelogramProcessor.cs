using FactoryLab3.Params;

namespace FactoryLab3.Creators;

public class ParallelogramProcessor : Processor<ParallelogramParams>
{
    protected override IFigure CreateFigure(ParallelogramParams parameters)
    {
        return new Parallelogram(parameters.SideA, parameters.SideB, parameters.Height);
    }
}