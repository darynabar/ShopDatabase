using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public ICollection<Shop> Shops { get; set; }

}
public class Shop
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int CityId { get; set; }
    public int? ParkingArea { get; set; }
    public City City { get; set; }
    public ICollection <Worker> Workers { get; set; }
    public ICollection <Product> Products { get; set; }
}
public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<City> Cities { get; set; }

}

public class Worker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Salary { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int CityId { get; set; }
    public Position Position { get; set; }
    public int PositionId { get; set; }
    public Shop Shop { get; set; }
    public int ShopId { get; set; }
    
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }

}
public class Position
{
    public int Id { get; set; }
    public string Name { get; set; }
    public  ICollection<Worker> Workers { get; set; }

}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public float Discount { get; set; }
    public ICollection<Shop> Shops { get; set; }


    public int Quantity { get; set; }
    public bool IsINStock { get; set; }

    public Category Category { get; set; }
    public int? CategoryId { get; set; }


}




namespace ShopDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
