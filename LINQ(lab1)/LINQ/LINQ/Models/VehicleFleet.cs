namespace LINQ.Models;

public class VehicleFleet
{
    public int Id { get; set; }
    
    public int CarId { get; set; }
    
    public int YearsInRental { get; set; }

    public decimal Deposit { get; set; }

    public VehicleFleet(int id, int carId, int yearsInRental, decimal deposit)
    {
        Id = id;
        YearsInRental = yearsInRental;
        CarId = carId;
        Deposit = deposit;
    }
}