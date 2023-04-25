using System.Xml.Linq;
using LINQ.Common;
using LINQ.DataAccess;
using LINQ.UserInterface;
using LINQXML.FileManager;

namespace LINQXML;

class Program
{
    static void Main(string[] args)
    {
        DataContext dataContext = new DataContext();
        DataInitializer dataInitializer = new DataInitializer(dataContext);
        dataInitializer.Initialize();
        var fileName = "lab2_data.xml";
        FileCreator fileCreator = new FileCreator(dataContext);
        fileCreator.Create(fileName);
        var document = XDocument.Parse(File.ReadAllText(fileName));
        var dataHandler = new DataHandler(document);
        var commandInvoker = new CommandInvoker(dataHandler);
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
    

    
