namespace StructuralDesignPatterns.Components;

public class StudentID : ICardComponent
{
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public DateTime Valid { get; set; }
    
    public StudentID(string firstName, string lastName, int id, DateTime valid)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        Valid = valid;
    }

    public void Display()
    {
        Console.WriteLine($"Full Name: {FirstName + LastName}\nID: {Id}\nValid until: {Valid}");
    }
}