using LINQ.Models;

namespace LINQ.DataAccess;

public interface IDataHandler
{
    IEnumerable<Car> GetCarsByType(int typeId);
    
    IEnumerable<Car> GetAllCars();
    
    IEnumerable<Car> GetOrdersByDate();

    IEnumerable<Car> GetTopOlderCars(int countFromTop);

    IEnumerable<string> GetClientContacts();

    IEnumerable<Client> GetFirstClients(int count);
    
    IEnumerable<string> GetOrderStatus();
    
    IEnumerable<string> GetRentalPrice();

    IEnumerable<string> GetOrdersAndClients();

    IEnumerable<string> GetCarFullInfo();

    IEnumerable<Order> GetClosedOrders();

    string RentalCarsNoMoreThanXYears(int x);

    decimal AveragePriceCarByYearOfRelease(int year);

    IEnumerable<Client> GetClientByName(string? name);

    int GetLastClientId();
    int GetLastOrderId();

    void AddClients(Client c);

    void AddOrder(Order o);
    
    IEnumerable<Order> GetOrderById(int id);
    
}