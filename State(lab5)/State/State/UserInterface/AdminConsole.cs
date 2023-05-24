namespace State.UserInterface;

public class AdminConsole
{
    private readonly List<Context> _contexts;

    public AdminConsole(List<Context> contexts)
    {
        _contexts = contexts;
    }

    private void ShowAllGrants()
    {
        foreach (var context in _contexts)
        {
            Console.WriteLine($"{context._grantOvner}");
        }
    }

    public void Prosses()
    {
        int input;
        string? q;
        string? b;
        do
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"Enter grant number(1-{_contexts.Count})\nq)Exit");
                ShowAllGrants();
                Console.Write("Grant: ");
                input = int.Parse(Console.ReadLine() ?? string.Empty);
                do
                {
                    Console.WriteLine("1-- next stage\n2--past stage");
                    b = Console.ReadLine();
                    switch (b)
                    {
                        case "1":
                            _contexts[input - 1].Request1();
                            break;
                        case "2":
                            _contexts[input - 1].Request2();
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }

                    Console.WriteLine("Enter q to close");
                    b = Console.ReadLine();
                } while (b != "q");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to return to menu");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Try again");
            }

            Console.WriteLine("Enter q to close");
            q = Console.ReadLine();
        } while (q != "q");
    }
}