using System.Linq.Expressions;
using System.Xml.Linq;
using LINQ.Common;
using LINQ.Models;
using LINQXML.FileManager;

namespace LINQ.DataAccess;

public class DataHandler : IDataHandler
{
    private readonly string fileName = "lab2_data.xml";
    private readonly XDocument _document;
    private readonly FileUpdater _fileUpdater = new FileUpdater();
    public DataHandler(XDocument document)
    {
        _document = document;
    }
    
    public IEnumerable<Car> GetCarsByType(int typeId)
    {
        return _document.Descendants("Car")
            .Where(p => int.Parse(p.Element("TypeId").Value) == typeId)
            .Deserialize<Car>();
    }
    
    
    public IEnumerable<Car> GetAllCars()
    {
        return _document.Descendants("Car").Deserialize<Car>();
    }
    
    public IEnumerable<Car> GetOrdersByDate()
    {
        var olderCars = from car in _document.Descendants("Car")
            orderby car.Element("YearOfRelease").Value
            select car;
        return olderCars.Deserialize<Car>();
    }

    public IEnumerable<Car> GetTopOlderCars(int countFromTop)
    {
        var topfive = (from car in _document.Descendants("Car")
            orderby car.Element("YearOfRelease").Value
            select car).Take(countFromTop);
        return topfive.Deserialize<Car>();
    }

    public IEnumerable<string> GetClientContacts()
    {
        var res = from client in _document.Descendants("Client")
            orderby client.Element("FullName").Value
            let c = client.Element("FullName").Value + " " + client.Element("PhoneNumber").Value
            select c;
        return res;
    }

    public IEnumerable<Client> GetFirstClients(int count) 
    {
        var firstTen = from client in _document.Descendants("Client")
            where int.Parse(client.Element("Id").Value) <= count
            select client;
        return firstTen.Deserialize<Client>();
    }

    public IEnumerable<string> GetRentalPrice()
    {
        var res = from vehicleFleet in _document.Descendants("VehicleFleet")
            join car in _document.Descendants("Car") 
                on vehicleFleet.Element("CarId").Value equals car.Element("Id").Value
            select $"Car id {car.Element("Id").Value} - rental price " +
                   $"{(decimal.Parse(car.Element("RentalPrice").Value) - ((decimal.Parse(vehicleFleet.Element("YearsInRental").Value) / 100m) * decimal.Parse(car.Element("RentalPrice").Value)))}";
        return res;
    }
    
    
    public IEnumerable<string> GetOrdersAndClients()
    {
        var res = from order in _document.Descendants("Order")
            join client in _document.Descendants("Client") on int.Parse(order.Element("ClinetId").Value)
                equals int.Parse(client.Element("Id").Value)
            orderby int.Parse(client.Element("Id").Value)
            select ($"Order Number {order.Element("Id").Value} - Client {client.Element("FullName").Value} - " +
                    $"{client.Element("PhoneNumber").Value}");
        return res;
    }

    public  IEnumerable<string> GetCarFullInfo()
    {
        var res = from car in _document.Descendants("Car")
            join carBrand in _document.Descendants("CarBrand") on int.Parse(car.Element("BrandId").Value)
                equals int.Parse(carBrand.Element("Id").Value)
            join carType in _document.Descendants("CarType") on int.Parse(car.Element("TypeId").Value) 
                equals int.Parse(carType.Element("Id").Value)
            select $"{carBrand.Element("Brand").Value} {carType.Element("Type").Value} " +
                   $"{car.Element("YearOfRelease").Value} " +
                   $"{car.Element("Price").Value} {car.Element("RentalPrice").Value}";
        return res;
    }

    public IEnumerable<Client> GetClientByName(string? name)
    {
        var res = (from client in _document.Descendants("Client") 
            where client.Element("FullName").Value == name
                select client) ?? throw new ArgumentException($"No clients found for name {name}");
        return res.Deserialize<Client>();
    }
    public IEnumerable<Order> GetClosedOrders()
    {
        return _document.Descendants("Order").TakeWhile(o => 
            bool.Parse(o.Element("IsReturned").Value)).Deserialize<Order>();
    }
    
    public string RentalCarsNoMoreThanXYears(int x)
    {
        bool res = _document.Descendants("Car").All(c => 
            int.Parse(c.Element("YearOfRelease").Value) <= x);
        return (res ? "Such machines exist" : "Such machines do not exist:)");
    }
    public decimal AveragePriceCarByYearOfRelease(int year)
    {
        var cars = (from car in _document.Descendants("Car")
            where int.Parse(car.Element("YearOfRelease").Value) == year
            select car) ?? throw new ArgumentException($"No cars found for year {year}");
        var selectionResult = cars.ToList();

        if (selectionResult.Any())
        {
            return selectionResult.Average(car => Decimal.Parse(car.Element("RentalPrice").Value));
        }
        
        throw new ArgumentException($"No cars found for year {year}");
    }
    
    public IEnumerable<Order> GetOrderById(int id)
    {
        return _document.Descendants("Order").Where(o =>
            o.Element("Id").Value == id.ToString()).Deserialize<Order>();
    }

    public int GetLastClientId()
    {
        return _document.Descendants("Client").Max(c => int.Parse(c.Element("Id").Value));
    }
    
    public int GetLastOrderId()
    {
        return _document.Descendants("Order").Max(c => int.Parse(c.Element("Id").Value));
    }
    
    public void CreateClient()
    {
        var c = GetClientByName((Console.ReadLine()));
        if (!c.Any())
        {
            Console.Clear();
            Console.WriteLine("Enter your name, address and phone number");

            Console.Write("FullName: ");
            var fullName = Console.ReadLine();

            Console.Write("Address: ");
            var address = Console.ReadLine();

            Console.Write("PhoneNumber: ");
            var phoneNumber = Console.ReadLine();

             IFileUpdater _fileUpdater = new FileUpdater();
            _fileUpdater.UpdateClient(fileName,  fullName, address, phoneNumber, GetLastClientId() + 1);
        }
        else
        {
            Console.WriteLine("User already exists");
        }
    }

    public void CreateOrder()
    {
        GetAllCars().Print();
        
        Console.Write("Create new order");

        Console.Write("CarFromVehicleFleetId: ");
        var carFromVehicleFleetId = int.Parse(Console.ReadLine());

        Console.Write("Rental days: ");
        var rentalDays = int.Parse(Console.ReadLine());

        var returnTime = DateTime.Now.AddDays(rentalDays);
        
        _fileUpdater.UpdateOrder(fileName, GetLastClientId(), GetLastOrderId(), carFromVehicleFleetId,rentalDays);
        
        GetOrderById(GetLastOrderId()).Print();
    }
}