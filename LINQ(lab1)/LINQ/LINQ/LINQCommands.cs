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
    
    public void getClinetsAndOrder(List<Order> orders)
    {
        Console.WriteLine("3. Cars and Client:");
        var resoult = from order in orders
            orderby order.ClinetId
            select new {Client = order.ClinetId, Car = order.CarId};
        foreach (var clinet in resoult)
        {
            Console.WriteLine(clinet.ToString());
        }
    }
}