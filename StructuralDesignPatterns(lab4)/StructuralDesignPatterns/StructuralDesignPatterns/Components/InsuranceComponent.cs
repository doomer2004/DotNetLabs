namespace StructuralDesignPatterns.Components;

public class InsuranceComponent : ICardComponent
{
    public string PolicyNumber { get; set; }
    public string InsuranceCompany { get; set; }
    public DateTime Valid { get; set; }
    public InsuranceComponent(string policyNumber, string insuranceCompany, DateTime valid)
    {
        PolicyNumber = policyNumber;
        InsuranceCompany = insuranceCompany;
        Valid = valid;
    }
    
    public void Display()
    {
        Console.WriteLine($"Policy Number: {PolicyNumber}" +
                          $"\nInsurance Company: {InsuranceCompany}\nValid until: {Valid}");
    }
}