namespace LINQlab;

public class Order
{
    public int Id { get; set; }
    
    public int ClinetId { get; set; }
    
    public int CarFromVehicleFleetId { get; set; }
    
    public DateTime CreationTime { get; set; }
    
    public DateTime ReturnTime { get; set; }
    
    public bool DepositStatus { get; set; }

    public Order(int id, int clinetId, int carFromVehicleFleetId, DateTime creationTime, DateTime returnTime, bool depositStatus)
    {
        Id = id;
        ClinetId = clinetId;
        CarFromVehicleFleetId = carFromVehicleFleetId;
        CreationTime = creationTime;
        ReturnTime = returnTime;
        DepositStatus = depositStatus;
    }
    
    public override string ToString()
    {
        return $"Order Id:{Id}-ClinetId:{ClinetId}-CarFromVehicleFleetId:{CarFromVehicleFleetId}-CreationTime:{CreationTime}-ReturnTime:{ReturnTime}-DepositStatus:{DepositStatus}";
    }
}