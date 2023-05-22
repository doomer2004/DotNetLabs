using StructuralDesignPatterns.Components;

namespace StructuralDesignPatterns.User;

public class UserInterface
{
    private readonly List<Card> _cardComponents;
    public UserInterface(List<Card> data)
    {
        _cardComponents = data;
    }

    private void ShowAllCards()
    {
        foreach (var card in _cardComponents)
        {
            Console.WriteLine(card.CardOvner);
        }
    }
    
    public void Prosses()
    {
        int input;
        string? q;
        do
        {
            try
            {
                Console.Clear();
                ShowAllCards();
                Console.WriteLine($"Enter card number({_cardComponents.Count})\nq)Exit");
                Console.Write("Card: ");
                input = int.Parse(Console.ReadLine() ?? string.Empty);
                _cardComponents[input - 1].Display();
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
