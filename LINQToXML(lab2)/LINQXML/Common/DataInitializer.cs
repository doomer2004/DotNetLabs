using LINQ.DataAccess;
using LINQ.Models;

namespace LINQ.Common;

public class DataInitializer : IDataInitializer
{
    private readonly IDataContext _dataContext;
    public DataInitializer(IDataContext context)
    {
        _dataContext = context;
    }
    
    public void Initialize()
    {
        _dataContext.CarBrands.AddRange(new List<CarBrand>
        {
            new CarBrand(1, "Toyota"),
            new CarBrand(2, "Honda"),
            new CarBrand(3, "Ford"),
            new CarBrand(4, "Chevrolet"),
            new CarBrand(5, "BMW"),
        });
        _dataContext.CarTypes.AddRange(new List<CarType>
        {
            new CarType(1, "Sedan"),
            new CarType(2, "SUV"),
            new CarType(3, "Hatchback"),
            new CarType(4, "Coupe"),
            new CarType(5, "Convertible"),
        });
        _dataContext.Cars.AddRange(new List<Car>
        {
            new Car(1, 1, 20000, 1, 50, 2019),
            new Car(2, 2, 22000, 2, 55, 2020),
            new Car(3, 3, 18000, 3, 45, 2018),
            new Car(4, 4, 25000, 4, 60, 2021),
            new Car(5, 5, 35000, 5, 80, 2022),
            new Car(6, 1, 30000, 2, 70, 2020),
            new Car(7, 2, 27000, 4, 65, 2021),
            new Car(8, 3, 23000, 1, 55, 2019),
            new Car(9, 4, 28000, 3, 50, 2020),
            new Car(10, 5, 40000, 5, 85, 2022),
            new Car(11, 1, 22000, 3, 45, 2018),
            new Car(12, 2, 25000, 2, 55, 2019),
            new Car(13, 3, 20000, 4, 50, 2018),
            new Car(14, 4, 27000, 1, 60, 2020),
            new Car(15, 5, 38000, 5, 80, 2022),
            new Car(16, 1, 32000, 4, 65, 2021),
            new Car(17, 2, 29000, 1, 55, 2019),
            new Car(18, 3, 24000, 2, 60, 2020),
            new Car(19, 4, 30000, 5, 85, 2022),
            new Car(20, 5, 42000, 3, 70, 2021)
        });
        _dataContext.Clients.AddRange(
            new List<Client> 
            {
                new Client(1, "John Doe", "123 Main St", "555-1234"),
                new Client(2, "Jane Doe", "456 Elm St", "555-5678"),
                new Client(3, "Bob Smith", "789 Oak St", "555-9012"),
                new Client(4, "Alice Johnson", "321 Pine St", "555-3456"),
                new Client(5, "Tom Wilson", "654 Maple St", "555-7890"),
                new Client(6, "Sara Brown", "987 Cedar St", "555-2345"),
                new Client(7, "Mike Davis", "246 Birch St", "555-6789"),
                new Client(8, "Karen Lee", "135 Cherry St", "555-0123"),
                new Client(9, "Timothy Green", "864 Walnut St", "555-4567"),
                new Client(10, "Emily White", "579 Spruce St", "555-8901"),
                new Client(11, "Danyil Hizhytskyi", "Akademika Yangelya Street, 20", "111-3421")
            });
        _dataContext.VehicleFleets.AddRange(
            new List<VehicleFleet>
            {
                new VehicleFleet(1, 1, 3, 5000),
                new VehicleFleet(2, 2, 2, 4500),
                new VehicleFleet(3, 3, 4, 4000),
                new VehicleFleet(4, 4, 1, 5500),
                new VehicleFleet(5, 5, 2, 6500),
                new VehicleFleet(6, 6, 3, 6000),
                new VehicleFleet(7, 7, 1, 5500),
                new VehicleFleet(8, 8, 4, 4000),
                new VehicleFleet(9, 9, 2, 4500),
                new VehicleFleet(10, 10, 1, 7500),
                new VehicleFleet(11, 11, 5, 3500),
                new VehicleFleet(12, 12, 2, 5500),
                new VehicleFleet(13, 13, 3, 5000),
                new VehicleFleet(14, 14, 2, 6000),
                new VehicleFleet(15, 15, 1, 8000),
                new VehicleFleet(16, 16, 1, 6000),
                new VehicleFleet(17, 17, 3, 4500),
                new VehicleFleet(18, 18, 2, 5500),
                new VehicleFleet(19, 19, 1, 7500),
                new VehicleFleet(20, 20, 4, 4000),
            });
        _dataContext.Orders.AddRange(
            new List<Order> 
            {
                new Order(1, 1, 5, DateTime.Now, DateTime.Now.AddDays(2), false),
                new Order(2, 2, 8, DateTime.Now.AddDays(1), DateTime.Now.AddDays(3), true),
                new Order(3, 3, 2, DateTime.Now.AddDays(3), DateTime.Now.AddDays(6), false),
                new Order(4, 4, 6, DateTime.Now.AddDays(4), DateTime.Now.AddDays(5), true),
                new Order(5, 5, 3, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), true),
                new Order(6, 6, 7, DateTime.Now.AddDays(5), DateTime.Now.AddDays(7), false),
                new Order(7, 7, 1, DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), true),
                new Order(8, 8, 4, DateTime.Now.AddDays(1), DateTime.Now.AddDays(8), false),
                new Order(9, 9, 9, DateTime.Now.AddDays(5), DateTime.Now.AddDays(9), true),
                new Order(10, 10, 10, DateTime.Now.AddDays(10), DateTime.Now.AddDays(13), false),
                new Order(11, 4, 5, DateTime.Now.AddDays(11), DateTime.Now.AddDays(12), false),
                new Order(12, 7, 2, DateTime.Now.AddDays(1), DateTime.Now.AddDays(8), true),
                new Order(13, 1, 6, DateTime.Now.AddDays(2), DateTime.Now.AddDays(4), false),
                new Order(14, 7, 3, DateTime.Now.AddDays(4), DateTime.Now.AddDays(9), true),
                new Order(15, 8, 7, DateTime.Now.AddDays(4), DateTime.Now.AddDays(5), false),
                new Order(16, 2, 1, DateTime.Now.AddDays(7), DateTime.Now.AddDays(10), true),
                new Order(17, 5, 4, DateTime.Now.AddDays(12), DateTime.Now.AddDays(16), false),
                new Order(18, 3, 9, DateTime.Now.AddDays(9), DateTime.Now.AddDays(11), true),
                new Order(19, 10, 10, DateTime.Now.AddDays(15), DateTime.Now.AddDays(19), false),
                new Order(20, 10, 5, DateTime.Now.AddDays(20), DateTime.Now.AddDays(12), true)
            });
    }
}