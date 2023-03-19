using LINQlab;

namespace LINQlab;

public class LINQCommands
{
    public void getAllCars(List<Car> cars)
    {
        Console.WriteLine("1. All cars:");
        var resoult = from car in cars select car;
        foreach (var car in resoult)
        {
            Console.WriteLine(car.ToString());
        }
    }
    
    public void getCarsByBrand(List<Car> cars, string brand)
    {
        Console.WriteLine("2. Cars by brand:");
        var resoult = from car in cars 
            where car.Brand == brand
            select car;
        foreach (var car in resoult)
        {
            Console.WriteLine(car.ToString());
        }
    }
    
    public void getCarsandClients(List<Order> orders, List<VehicleFleet> vehicleFleets, List<Client> clients)
    {
        Console.WriteLine("3. Cars and Clients:");
        var resoult = from order in orders
            join v in vehicleFleets on order.CarFromVehicleFleetId equals v.CarId
            join c in clients on order.ClinetId equals c.Id
            select new {Name = c.FullName, Car = v.CarId};
        foreach (var car in resoult)
        {
            Console.WriteLine(car.ToString());
        }
    }
    
    public void getOrdersbyDate(List<Order> orders)
    {
        Console.WriteLine("4. First Orsers:");
        var resoult = from order in orders
            orderby order.CreationTime
            select new { Order = order.Id, TimeStart = order.CreationTime, TimeEnd = order.ReturnTime};
        foreach (var car in resoult)
        {
            Console.WriteLine(car.ToString());
        }
    }
    
    public void getVehicleFleetByRentals(List<VehicleFleet> vehicleFleets)
    {
        Console.WriteLine("5. cars that used the smallest:");
        var resoult = from vehicleFleet in vehicleFleets
            orderby vehicleFleet.RentalsCount
            where vehicleFleet.RentalsCount <= 15
            select new { Car = vehicleFleet.CarId, InUsed = vehicleFleet.RentalsCount };
        foreach (var car in resoult)
        {
            Console.WriteLine(car.ToString());
        }
    }
    
    public void getOrderStatus(List<Order> orders)
    {
        Console.WriteLine("6. Order status:");
        var resoult = from order in orders
            group order by order.DepositStatus!=true
            into groups
            select new
            {
                Key = groups.Key,
                Orders = groups.ToList(),
                Count = groups.Count()
            };
        foreach (var group in resoult)
        {
            Console.WriteLine($"Order Status: {group.Key}");
            Console.WriteLine($"Number of Orders: {group.Count}");
            foreach (var order in group.Orders)
            {
                Console.WriteLine(order);
            }
        }
    }
    
    public void getCarsProfit(List<Car> cars, List<VehicleFleet> vehicleFleets)
    {
        Console.WriteLine("7. Profit:");
        var res = from v in vehicleFleets
            join c in cars on v.Id equals c.Id
            select new
            {
                CarName = c.Brand + " " + c.Type,
                RentPrice = v.RentalsCount * c.RentalPrice 
            };
    
        foreach (var car in res)
        {
            Console.WriteLine($"{car.CarName}: {car.RentPrice}");
        }
    }
    
    public void getCarRent(List<Car> cars, List<VehicleFleet> vehicleFleets)
    {
        Console.WriteLine("8. Rent price:");
        var res = from v in vehicleFleets
            join c in cars on v.Id equals c.Id
            select new
            {
                CarName = c.Brand + " " + c.Type,
                RentPrice = c.RentalPrice - (v.RentalsCount / 100m) * c.RentalPrice

            };
    
        foreach (var car in res)
        {
            Console.WriteLine($"{car.CarName}: {car.RentPrice}");
        }
    }
    
}