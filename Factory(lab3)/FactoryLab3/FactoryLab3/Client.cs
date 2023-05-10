using FactoryLab3.Creators;
using FactoryLab3.Params;

namespace FactoryLab3;

public class Client
{
    public void Prosses()
    {
        string input = null;
        while (input != "q")
        {
            Console.Clear();
            Console.WriteLine("1)Triangle \n2)Square \n3)Parallelogram \n4)Circle \n5)CompositeFigure\nq)Exit");
            Console.Write("Create a figure: ");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CreateTriangle();
                    break;
                case "2":
                    CreateSquare();
                    break;
                case "3":
                    CreateParallelogram();
                    break;
                case "4":
                    CreateCircle();
                    break;
                case "5":
                    CreateCompositeFigure();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            Console.ReadKey();
        }

    }

    private void CreateTriangle()
    {
        try
        {
            Console.Write("Enter side A of the triangle: ");
            double triangleA = double.Parse(Console.ReadLine());
            
            Console.Write("Enter side B of the triangle: ");
            double triangleB = double.Parse(Console.ReadLine());
            
            Console.Write("Enter side C of the triangle: ");
            double triangleC = double.Parse(Console.ReadLine());
            
            if (triangleA >= triangleB + triangleC || triangleB >= triangleA + triangleC || triangleC >= triangleA + triangleB)
            {
                throw new Exception("Triangle creation failed: the sides do not form a valid triangle.");
            }
            
            new TriangleProcessor().Process(new TriangleParams(triangleA, triangleB, triangleC));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Press any key to restart the program...");
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
    }
    
    private void CreateSquare()
    {
        try
        {
            Console.Write("Enter side of the square: ");
            double squareSide = double.Parse(Console.ReadLine());

            if (squareSide <= 0)
            {
                throw new ArgumentException("Square creation failed: the side length must be positive.");
            }

            new SquareProcessor().Process(new SquareParams(squareSide));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Press any key to restart the program...");
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
    }
    private void CreateParallelogram()
    {
        try
        {
            Console.Write("Enter side A of the parallelogram: ");
            double parallelogramA = double.Parse(Console.ReadLine());

            Console.Write("Enter side B of the parallelogram: ");
            double parallelogramB = double.Parse(Console.ReadLine());

            Console.Write("Enter height of the parallelogram: ");
            double parallelogramHeight = double.Parse(Console.ReadLine());

            if (parallelogramA <= 0 || parallelogramB <= 0 || parallelogramHeight <= 0)
            {
                throw new ArgumentException("Parallelogram creation failed: all sides and the height must be positive.");
            }

            new ParallelogramProcessor().Process(new ParallelogramParams(parallelogramA, parallelogramB, parallelogramHeight));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Press any key to restart the program...");
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
    }
    private void CreateCircle()
    {
        try
        {
            Console.Write("Enter radius for circle: ");
            double circleRadius = double.Parse(Console.ReadLine());

            if (circleRadius <= 0)
            {
                throw new ArgumentException("Circle creation failed: the radius must be positive.");
            }

            new CircleProcessor().Process(new CircleParams(circleRadius));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine("Press any key to restart the program...");
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
    }

    private void CreateCompositeFigure()
    {
        List<IFigure> figures = new List<IFigure>();
        string input = null;
        while (input != "q")
        {
            Console.Clear();
            Console.WriteLine("1)Triangle \n2)Square \n3)Parallelogram \n4)Circle");
            Console.Write("Create a figure");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    try
                    {
                        Console.Write("Enter side A of the triangle: ");
                        double triangleA = double.Parse(Console.ReadLine());
                        Console.Write("Enter side B of the triangle: ");
                        double triangleB = double.Parse(Console.ReadLine());
                        Console.Write("Enter side C of the triangle: ");
                        double triangleC = double.Parse(Console.ReadLine());
                        
                        if (triangleA >= triangleB + triangleC || triangleB >= triangleA + triangleC || triangleC >= triangleA + triangleB)
                        {
                            throw new Exception("Triangle creation failed: the sides do not form a valid triangle.");
                        }
                        
                        figures.Add(new TriangleProcessor().Process(new TriangleParams(triangleA, triangleB, triangleC)));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        Console.WriteLine("Press any key to restart the program...");
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main();
                    }
                    
                    break;
                case "2":
                    try
                    {
                        Console.Write("Enter side of the square: ");
                        double squareSide = double.Parse(Console.ReadLine());
                        
                        if (squareSide <= 0)
                        {
                            throw new ArgumentException("Square creation failed: the side length must be positive.");
                        }
                        
                        figures.Add(new SquareProcessor().Process(new SquareParams(squareSide)));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        Console.WriteLine("Press any key to restart the program...");
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main();
                    }
                    
                    break;
                case "3":
                    try
                    {
                        Console.Write("Enter side A of the parallelogram: ");
                        double parallelogramA = double.Parse(Console.ReadLine());
                        
                        Console.Write("Enter side B of the parallelogram: ");
                        double parallelogramB = double.Parse(Console.ReadLine());
                        
                        Console.Write("Enter height of the parallelogram: ");
                        double parallelogramHeight = double.Parse(Console.ReadLine());
                        
                        if (parallelogramA <= 0 || parallelogramB <= 0 || parallelogramHeight <= 0)
                        {
                            throw new ArgumentException("Parallelogram creation failed: all sides and the height must be positive.");
                        }

                        figures.Add(new ParallelogramProcessor().Process(new ParallelogramParams(parallelogramA, parallelogramB, parallelogramHeight)));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        Console.WriteLine("Press any key to restart the program...");
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main();
                    }
                    

                    break;
                case "4":
                    try
                    {
                        Console.Write("Enter radius for circle: ");
                        double circleRadius = double.Parse(Console.ReadLine());

                        if (circleRadius <= 0)
                        {
                            throw new ArgumentException("Circle creation failed: the radius must be positive.");
                        }
                        
                        figures.Add(new CircleProcessor().Process(new CircleParams(circleRadius)));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        Console.WriteLine("Press any key to restart the program...");
                        Console.ReadKey();
                        Console.Clear();
                        Program.Main();
                    }
                    
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            
        }

        new CompositeFigureProcessor().Process(new CompositeFigureParams(figures));
    }
}