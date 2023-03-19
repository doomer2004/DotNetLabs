namespace LINQlab;

public class VehicleFleet
{
    public int Id { get; set; }
    
    public int CarId { get; set; }
    
    public int RentalsCount { get; set; }

    public decimal Deposit { get; set; }

    public VehicleFleet(int id, int carId, int rentalsCount, decimal deposit)
    {
        Id = id;
        RentalsCount = rentalsCount;
        CarId = carId;
        Deposit = deposit;
    }
}