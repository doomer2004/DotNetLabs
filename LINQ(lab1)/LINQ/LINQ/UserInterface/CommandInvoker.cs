using System.Threading.Channels;
using LINQ.Common;
using LINQ.DataAccess;
using LINQ.Models;

namespace LINQ.UserInterface;

public class CommandInvoker : ICommandInvoker
{
    private readonly Dictionary<ExecutingCommandType, Action> _commands;

    private readonly IDataHandler _dataHandler;

    public CommandInvoker(IDataHandler dataHandler)
    {
        _commands = new Dictionary<ExecutingCommandType, Action>
        {
            {ExecutingCommandType.GetAllCars, GetAllCars},
            {ExecutingCommandType.GetCarsByType, GetCarsByType},
            {ExecutingCommandType.GetOrdersbyDate, GetOrdersbyDate},
            {ExecutingCommandType.GetTopFiveOldCars, GetTopOldCars},
            {ExecutingCommandType.GetClientContacts, GetClientContacts},
            {ExecutingCommandType.GetFirstClients, GetFirstClients},
            {ExecutingCommandType.GetOrderStatus, GetOrderStatus},
            {ExecutingCommandType.GetRentalPrice, GetRentalPrice},
            {ExecutingCommandType.GetOrdersAndClients, GetOrdersAndClients},
            {ExecutingCommandType.GetCarFullInfo, GetCarFullInfo},
            {ExecutingCommandType.GetClosedOrders, GetClosedOrders},
            {ExecutingCommandType.RentalCarsNoMoreThanXYears, RentalCarsNoMoreThanXYears},
            {ExecutingCommandType.AveragePriceCarByYearOfRelease, AveragePriceCarByYearOfRelease},
            {ExecutingCommandType.GetClientByName, GetClientByName},
            {ExecutingCommandType.CreateOrder, CreateOrder},
            
        };
        _dataHandler = dataHandler;
    }

    public void InvokeCommand(ExecutingCommandType commandType)
    {
        _commands[commandType].Invoke();
    }

    protected virtual void GetCarsByType()
    {
        Console.Write("Enter car type id: ");
        _dataHandler.GetCarsByType(Convert.ToInt32(Console.ReadLine())).Print();
    }

    protected virtual void GetAllCars()
    {
        _dataHandler.GetAllCars().Print();
    }

    protected virtual void GetOrdersbyDate()
    {
        _dataHandler.GetOrdersByDate().Print();
    }

    protected virtual void GetTopOldCars()
    {
        Console.Write("Enter count of cars: ");
        _dataHandler.GetTopOlderCars(Convert.ToInt32(Console.ReadLine())).Print();
    }

    protected virtual void GetClientContacts()
    {
        _dataHandler.GetClientContacts().Print();
    }

    protected virtual void GetFirstClients()
    {
        Console.Write("Enter count of clients: ");
        _dataHandler.GetFirstClients(Convert.ToInt32(Console.ReadLine())).Print();
    }

    protected virtual void GetOrderStatus()
    {
        _dataHandler.GetOrderStatus().Print();
    }

    protected virtual void GetRentalPrice()
    {
        _dataHandler.GetRentalPrice().Print();
    }

    protected virtual void GetOrdersAndClients()
    {
        _dataHandler.GetOrdersAndClients().Print();
    }

    protected virtual void GetCarFullInfo()
    {
        _dataHandler.GetCarFullInfo().Print();
    }

    protected virtual void GetClosedOrders()
    {
        _dataHandler.GetClosedOrders().Print();
    }

    protected virtual void RentalCarsNoMoreThanXYears()
    {
        Console.Write("Enter year: ");
        Console.WriteLine(_dataHandler.RentalCarsNoMoreThanXYears(Convert.ToInt32(Console.ReadLine())));
    }

    protected virtual void AveragePriceCarByYearOfRelease()
    {
        Console.Write("Enter year: ");
        Console.WriteLine(_dataHandler.AveragePriceCarByYearOfRelease(Convert.ToInt32(Console.ReadLine())));
    }
    protected virtual void GetClientByName()
    {
        Console.Write("Enter Name: ");
        Console.WriteLine(_dataHandler.GetClientByName((Console.ReadLine())));
    }
    protected virtual void CreateOrder()
    {
        var c = _dataHandler.GetClientByName((Console.ReadLine()));
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

            var newClient = new Client(
                _dataHandler.GetLastClientId() + 1,
                fullName,
                address,
                phoneNumber);

            _dataHandler.AddClients(newClient);
            _dataHandler.GetAllCars().Print();
            Console.Write("Create new order");

            Console.Write("CarFromVehicleFleetId: ");
            var carFromVehicleFleetId = int.Parse(Console.ReadLine());

            Console.Write("Rental days: ");
            var rentalDays = int.Parse(Console.ReadLine());

            var returnTime = DateTime.Now.AddDays(rentalDays);

            var newOrder = new Order(
                _dataHandler.GetLastOrderId() + 1,
                newClient.Id,
                carFromVehicleFleetId,
                DateTime.Now,
                returnTime,
                false);

            _dataHandler.AddOrder(newOrder);
            _dataHandler.GetOrderById(newOrder.Id).Print();
        }
        else
        {
            Console.WriteLine("User already exists");
        }
    }
    
}