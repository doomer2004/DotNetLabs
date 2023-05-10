namespace FactoryLab3;

    public class Parallelogram : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Height { get; set; }

        public Parallelogram(double sideA, double sideB, double height)
        {
            SideA = sideA;
            SideB = sideB;
            Height = height;
        }

        public double GetArea()
        {
            return SideA * Height;
        }

        public double GetPerimeter()
        {
            return 2 * SideA + 2 * SideB;
        }

        public IFigure CreateFigure()
        {
            return new Parallelogram(SideA, SideB, Height);
        }
}