namespace StructuralDesignPatterns.Components;

public class PassportComponent : ICardComponent
{
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime Valid { get; set; }
    
    public PassportComponent(string firstName, string lastName, DateTime dateOfBirth, DateTime valid)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Valid = valid;
    }

    public void Display()
    {
        Console.WriteLine($"Full Name: {FirstName + ' '+ LastName}" +
                          $"\nDate of birth: {DateOfBirth}\nValid until: {Valid}");
    }
}