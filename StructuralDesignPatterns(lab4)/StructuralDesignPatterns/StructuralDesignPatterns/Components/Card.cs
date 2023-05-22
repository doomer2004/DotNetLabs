namespace StructuralDesignPatterns.Components;

public class Card : ICardComponent
{
    private List<ICardComponent> components = new List<ICardComponent>();

    public string CardOvner { get; set; }
    public Card(string ovner)
    {
        CardOvner = ovner;
    }
    public void AddComponent(ICardComponent component)
    {
        components.Add(component);
    }

    public void AddComponent(IEnumerable<ICardComponent> cardComponents)
    {
        components.AddRange(cardComponents);
    }

    public void RemoveComponent(ICardComponent component)
    {
        components.Remove(component);
    }
    
    public void Display()
    {
        foreach (var component in components)
        {
            component.Display();
            Console.WriteLine();
        }
    }
    
}