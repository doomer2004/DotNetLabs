using System.Text;

namespace LINQlab;

class Program
{
    static void Main(string[] args)
    {
        LINQCommands linqCommands = new LINQCommands();

        List<Car> cars = new List<Car>
        {
            new Car(1, "Toyota", 25000, "Sedan", 50, 2019),
            new Car(2, "Honda", 28000, "SUV", 60, 2020),
            new Car(3, "Nissan", 20000, "Hatchback", 45, 2018),
            new Car(4, "Ford", 30000, "Pickup", 70, 2021),
            new Car(5, "Chevrolet", 35000, "Sports car", 80, 2022),
            new Car(6, "Mazda", 22000, "Sedan", 50, 2017),
            new Car(7, "Volkswagen", 27000, "Hatchback", 55, 2020),
            new Car(8, "BMW", 45000, "Luxury car", 100, 2022),
            new Car(9, "Mercedes", 50000, "Luxury car", 110, 2023),
            new Car(10, "Audi", 42000, "Sedan", 90, 2021),
            new Car(11, "Subaru", 24000, "SUV", 60, 2018),
            new Car(12, "Lexus", 48000, "Luxury car", 105, 2022),
            new Car(13, "Kia", 18000, "Sedan", 40, 2016),
            new Car(14, "Hyundai", 20000, "SUV", 50, 2017),
            new Car(15, "Porsche", 60000, "Sports car", 120, 2023),
            new Car(16, "Jeep", 32000, "SUV", 75, 2020),
            new Car(17, "Tesla", 70000, "Electric car", 130, 2022),
            new Car(18, "Ferrari", 150000, "Sports car", 200, 2023),
            new Car(19, "Lamborghini", 200000, "Sports car", 250, 2023),
            new Car(20, "Bugatti", 300000, "Luxury car", 300, 2023)
        };

        List<Client> clients = new List<Client>
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
            new Client(10, "Emily White", "579 Spruce St", "555-8901")
        };

        List<VehicleFleet> vehicleFleets = new List<VehicleFleet>
        {
            new VehicleFleet(1, 1, 24, 2500),
            new VehicleFleet(2, 2, 15, 2800),
            new VehicleFleet(3, 3, 32, 2000),
            new VehicleFleet(4, 4, 21, 3000),
            new VehicleFleet(5, 5, 20, 3500),
            new VehicleFleet(6, 6, 16, 2200),
            new VehicleFleet(7, 7, 18, 2700),
            new VehicleFleet(8, 8, 8, 4500),
            new VehicleFleet(9, 9, 3, 50000),
            new VehicleFleet(10, 10, 26, 4200),
            new VehicleFleet(11, 11, 42, 2400),
            new VehicleFleet(12, 12, 13, 4800),
            new VehicleFleet(13, 13, 42, 1800),
            new VehicleFleet(14, 14, 34, 2000),
            new VehicleFleet(15, 15, 7, 6000),
            new VehicleFleet(16, 16, 29, 3200),
            new VehicleFleet(17, 17, 6, 7000),
            new VehicleFleet(18, 18, 2, 15000),
            new VehicleFleet(19, 19, 2, 20000),
            new VehicleFleet(20, 20, 1, 30000),
        };

        List<Order> orders = new List<Order>
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
        };

        linqCommands.getAllCars(cars);

        linqCommands.getCarsByBrand(cars, "Bugatti");

        linqCommands.getCarsandClients(orders, vehicleFleets, clients);

        linqCommands.getOrdersbyDate(orders);

        linqCommands.getVehicleFleetByRentals(vehicleFleets);

        linqCommands.getOrderStatus(orders);

        linqCommands.getCarsProfit(cars, vehicleFleets);
        
        linqCommands.getCarRent(cars, vehicleFleets);
    }
}