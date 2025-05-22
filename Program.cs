// See https://aka.ms/new-console-template for more information
using TestC.LINQ;

public class Product
{
    public int ID { set; get; }
    public string Name { set; get; }
    public double Price { set; get; }
    public string[] Colors { set; get; }
    public string Brand { set; get; }
    public Product(int id, string name, double price, string[] colors, string brand)
    {
        ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
    }
    public override string ToString()
        => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";
}

class Program
{
    static void Main(string[] args)
    {
        Product p = new Product(1, "Code with me", 5555, new string[] { "Blue", "Red" }, "Nam Cap");
    }

}
