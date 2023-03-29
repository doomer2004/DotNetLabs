using System.Threading.Channels;
using LINQ.Common;
using LINQ.DataAccess;
using LINQ.UserInterface;
using Microsoft.Extensions.DependencyInjection;

namespace LINQlab;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = ContainerManager.Configure();
        var dataInitializer = serviceProvider.GetService<IDataInitializer>()  ?? throw new ArgumentNullException(); 
        dataInitializer.Initialize();
        var commandInvoker = serviceProvider.GetService<ICommandInvoker>() ?? throw new ArgumentNullException();
        string? q;
        do
        {
            Console.Clear();
            try
            {
                PrintMenu();
                int choose = Convert.ToInt32(Console.ReadLine());
                commandInvoker.InvokeCommand((ExecutingCommandType) choose);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to return to menu");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Try again");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Enter q to close");
            q = Console.ReadLine();
        } while (q != "q");
        
    }

    private static void PrintMenu()
    {
        Console.WriteLine("Press one of digit bellow");
        foreach (ExecutingCommandType enumValue in Enum.GetValues<ExecutingCommandType>())
        {
            Console.WriteLine($"[{(int)enumValue}] for {enumValue.ToString()}");
        }
    }
}

internal static class ContainerManager
{
    public static ServiceProvider Configure() 
    { 
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<IDataContext,DataContext>();
        serviceCollection.AddScoped<IDataHandler,DataHandler>();
        serviceCollection.AddScoped<IDataInitializer,DataInitializer>();
        serviceCollection.AddScoped<ICommandInvoker,CommandInvoker>();
        
        return serviceCollection.BuildServiceProvider();      
    }
}
