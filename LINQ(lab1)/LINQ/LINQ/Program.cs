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
        
        Random rnd = new Random();
        List<Order> orders = new List<Order>();

        foreach (Client client in clients)
        {
            for (int i = 0; i < 3; i++)
            {
                int carIndex = rnd.Next(cars.Count);
                Car car = cars[carIndex];

                DateTime creationTime = new DateTime(2023, rnd.Next(1, 13), rnd.Next(1, 29), rnd.Next(0, 24), 0, 0);
                DateTime returnTime = creationTime.AddDays(rnd.Next(1, 8));

                decimal deposit = car.Price * (decimal)(0.1 + rnd.NextDouble() * 0.2);

                Order order = new Order(orders.Count + 1, client.Id, car.Id, creationTime, returnTime, deposit);
                orders.Add(order);
            }
        }
        
        linqCommands.getAllCars(cars);
        
        linqCommands.getCarsByBrand(cars, "Bugatti");

        linqCommands.getClinetsAndOrder(orders);
    }
}