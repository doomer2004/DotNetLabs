using System.Linq.Expressions;
using LINQ.Common;
using LINQ.Models;

namespace LINQ.DataAccess;

public class DataHandler : IDataHandler
{
    private readonly IDataContext _dataContext;

    public DataHandler(IDataContext context)
    {
        _dataContext = context;
    }
    
    public IEnumerable<Car> GetCarsByType(int typeId)
    {
        return _dataContext.Cars.Where(p => p.TypeId == typeId);
    }
    
    
    public IEnumerable<Car> GetAllCars()
    {
        return _dataContext.Cars;
    }
    
    public IEnumerable<Car> GetOrdersByDate()
    {
        var olderCars = from car in _dataContext.Cars
            orderby car.YearOfRelease
            select car;
        return olderCars;
    }

    public IEnumerable<Car> GetTopOlderCars(int countFromTop)
    {
        var topfive = (from car in _dataContext.Cars
            orderby car.YearOfRelease
            select car).Take(countFromTop);
        return topfive;
    }

    public IEnumerable<string> GetClientContacts()
    {
        var res = from client in _dataContext.Clients
            orderby client.FullName
            let c = client.FullName + " " + client.PhoneNumber
            select c;
        return res;
    }

    public IEnumerable<Client> GetFirstClients(int count) 
    {
        var firstTen = from client in _dataContext.Clients
            where client.Id <= count
            select client;
        return firstTen;
    }

    public IEnumerable<string> GetOrderStatus()
    {
        var result = from order in _dataContext.Orders
            group order by order.IsReturned into groups
            select new
            {
                Key = groups.Key,
                Orders = groups.ToList(),
                Count = groups.Count()
            };

        return result.Select(r => $"Group: {r.Key}, Count: {r.Count} Orders : {r.Orders.ToDisplayString()}");
    }

    public IEnumerable<string> GetRentalPrice()
    {
        var res = from vehicleFleet in _dataContext.VehicleFleets
            join car in _dataContext.Cars on vehicleFleet.CarId equals car.Id
            select $"Car id {car.Id} - rental price {(car.RentalPrice - ((vehicleFleet.YearsInRental / 100m) * car.RentalPrice))}";
        return res;
    }
    
    
    public IEnumerable<string> GetOrdersAndClients()
    {
        var res = from order in _dataContext.Orders
            join client in _dataContext.Clients on order.ClinetId equals client.Id
            orderby client.Id
            select ($"Order Number {order.Id} - Client {client.FullName} - {client.PhoneNumber}");
        return res;
    }

    public  IEnumerable<string> GetCarFullInfo()
    {
        var res = from car in _dataContext.Cars
            join carBrand in _dataContext.CarBrands on car.BrandId equals carBrand.Id
            join carType in _dataContext.CarTypes on car.TypeId equals carType.Id
            select $"{carBrand.Brand} {carType.Type} {car.YearOfRelease} {car.Price} {car.RentalPrice}";
        return res;
    }

    public IEnumerable<Client> GetClientByName(string? name)
    {
        var res = (from client in _dataContext.Clients 
            where client.FullName == name
                select client) ?? throw new ArgumentException($"No clients found for name {name}");
        return res;
    }
    public IEnumerable<Order> GetClosedOrders()
    {
        return _dataContext.Orders.TakeWhile(o => o.IsReturned);
    }
    
    public string RentalCarsNoMoreThanXYears(int x)
    {
        bool res = _dataContext.Cars.All(c => c.YearOfRelease <= x);
        return (res ? "Such machines exist" : "Such machines do not exist:)");
    }
    public decimal AveragePriceCarByYearOfRelease(int year)
    {
        var cars = (from car in _dataContext.Cars
            where car.YearOfRelease == year
            select car) ?? throw new ArgumentException($"No cars found for year {year}");
        var selectionResult = cars.ToList();

        if (selectionResult.Any())
        {
            return selectionResult.Average(car => car.RentalPrice);
        }
        
        throw new ArgumentException($"No cars found for year {year}");
    }

    public int GetLastClientId()
    {
        return _dataContext.Clients.Max(c => c.Id);
    }
    
    public int GetLastOrderId()
    {
        return _dataContext.Orders.Max(c => c.Id);
    }
    
    public void AddClients(Client c)
    {
        _dataContext.Clients.Add(c);
    }
    public void AddOrder(Order o)
    {
        _dataContext.Orders.Add(o);
    }

    
    public IEnumerable<Order> GetOrderById(int id)
    {
        return _dataContext.Orders.Where(o => o.Id == id);
    }
    
}