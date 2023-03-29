namespace LINQ.Models;

public class CarType
{
    public int Id{ get; set; }
    public string Type { get; set; }

    public CarType(int id,string type)
    {
        Id = id;
        Type = type;
    }

    public override string ToString()
    {
        return $"Type:{Type}";
    }
}