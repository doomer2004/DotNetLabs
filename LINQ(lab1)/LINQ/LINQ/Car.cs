namespace LINQlab;

public class Car
{
    public int Id{ get; set; }
    public string Brand { get; set; }
    public decimal Price { get; set; }
    public string Type { get; set; }
    public decimal RentalPrice { get; set; }
    
    public double YearOfRelease { get; set; }

    public Car(int id,string brand, decimal price, string type, decimal rentalPrice, int yearOfRelease)
    {
        Id = id;
        Brand = brand;
        Price = price;
        Type = type;
        RentalPrice = rentalPrice;
        YearOfRelease = yearOfRelease;
    }

    public override string ToString()
    {
        return $"{Brand}-{Type}-{YearOfRelease}-{Price}-{RentalPrice}";
    }
}