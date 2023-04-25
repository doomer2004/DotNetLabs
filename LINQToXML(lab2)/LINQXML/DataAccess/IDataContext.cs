using LINQ.Models;

namespace LINQ.DataAccess;

public interface IDataContext
{
    List<Car> Cars {get; set; }
    List<Client> Clients {get; set; }
    List<VehicleFleet> VehicleFleets {get; set; } 
    List<Order> Orders { get; set; }
    List<CarBrand> CarBrands { get; set; }
    List<CarType> CarTypes { get; set; }

}