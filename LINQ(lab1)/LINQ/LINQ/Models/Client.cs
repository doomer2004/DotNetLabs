namespace LINQ.Models;

public class Client
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public Client(int id,string fullName, string address, string phoneNumber)
    {
        Id = id;
        FullName = fullName;
        Address = address;
        PhoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return $"Name : {FullName}, Address : {Address}, PhoneNumber : {PhoneNumber}";
    }
}

