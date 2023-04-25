namespace LINQ.Models;

public class Order
{
    public int Id { get; set; }
    
    public int ClinetId { get; set; }
    
    public int CarFromVehicleFleetId { get; set; }
    
    public DateTime CreationTime { get; set; }
    
    public DateTime ReturnTime { get; set; }
    
    public bool IsReturned { get; set; }

    public Order(int id, 
        int clinetId, 
        int carFromVehicleFleetId, 
        DateTime creationTime, 
        DateTime returnTime, 
        bool isReturned)
    {
        Id = id;
        ClinetId = clinetId;
        CarFromVehicleFleetId = carFromVehicleFleetId;
        CreationTime = creationTime;
        ReturnTime = returnTime;
        IsReturned = isReturned;
    }

    public Order()
    {
        
    }
    public override string ToString()
    {
        return $"ClinetId:{ClinetId}-CarFromVehicleFleetId:" +
               $"{CarFromVehicleFleetId}-CreationTime:{CreationTime}" +
               $"-ReturnTime:{ReturnTime}-IsReturned:{IsReturned}";
    }
}