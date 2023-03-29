using LINQ.Models;

namespace LINQ.DataAccess;

public class DataContext : IDataContext
{
   public List<Car> Cars {get; set; } = new List<Car>();
    public List<Order> Orders {get; set; } = new List<Order>();
    public List<VehicleFleet> VehicleFleets {get; set; } = new List<VehicleFleet>();
    public List<Client> Clients {get; set; } = new List<Client>();
    public List<CarBrand> CarBrands {get; set; } = new List<CarBrand>();
    public List<CarType> CarTypes {get; set; } = new List<CarType>();
    
}