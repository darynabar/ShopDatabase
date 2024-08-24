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
