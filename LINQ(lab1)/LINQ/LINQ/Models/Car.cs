namespace LINQ.Models;

public class Car
{
    public int Id{ get; set; }
    public int BrandId { get; set; }
    public decimal Price { get; set; }
    public int TypeId { get; set; }
    public decimal RentalPrice { get; set; }
    public int YearOfRelease { get; set; } 
    
    public Car(int id,int brandId, decimal price, int typeId, decimal rentalPrice, int yearOfRelease)
    {
        Id = id;
        BrandId = brandId;
        Price = price;
        TypeId = typeId;
        RentalPrice = rentalPrice;
        YearOfRelease = yearOfRelease;
    }

    public override string ToString()
    {
        return $"Brand : {BrandId}, Price : {Price}, TypeId : {TypeId}, RentalPrice : {RentalPrice}, YearOfRelease : {YearOfRelease}";
    }
}