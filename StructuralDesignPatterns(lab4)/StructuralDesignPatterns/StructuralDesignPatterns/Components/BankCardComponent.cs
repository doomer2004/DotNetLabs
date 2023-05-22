namespace StructuralDesignPatterns.Components;

public class BankCardComponent : ICardComponent
{
    public string CardNumber { get; set; }
    public string BankName { get; set; }

    public BankCardComponent(string cardNumber, string bankName)
    {
        CardNumber = cardNumber;
        BankName = bankName;
    }
    
    public void Display()
    {
        Console.WriteLine($"CardNumber: {CardNumber}\nBankName: {BankName}");
    }
}