namespace LINQ.Models;

public class CarBrand
{
        public int Id{ get; set; }
        public string Brand { get; set; }

        public CarBrand(int id,string brand)
        {
            Id = id;
            Brand = brand;
        }

        public CarBrand()
        {
        }

        public override string ToString()
        {
            return $"Brand:{Brand}";
        }
}