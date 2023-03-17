namespace LINQlab;

public class Order
{
    public int Id { get; set; }
    
    public int ClinetId { get; set; }
    
    public int CarId { get; set; }
    
    public DateTime CreationTime { get; set; }
    
    public DateTime ReturnTime { get; set; }
    
    public decimal Deposit { get; set; }

    public Order(int id, int clinetId, int carId, DateTime creationTime, DateTime returnTime, decimal deposit)
    {
        Id = id;
        ClinetId = clinetId;
        CarId = carId;
        CreationTime = creationTime;
        ReturnTime = returnTime;
        Deposit = deposit;
    }
    
    public override string ToString()
    {
        return $"{Id}-{ClinetId}-{CarId}-{CreationTime}-{ReturnTime}-{Deposit}";
    }
}