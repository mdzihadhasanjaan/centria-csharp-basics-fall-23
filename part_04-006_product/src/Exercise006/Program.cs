namespace Exercise006
{
  public class Product
  {
    public string name;
    public double price;
    public int quantity;
    public Product(string name, double price, int quantity)
    {
      this.name = name;
      this.price = price;
      this.quantity = quantity;
    }
    public void PrintProduct()
    {
      Console.WriteLine($"{name}: price {price}: {quantity} pcs");
    }
  }
  public class Program
  {
    public static void Main(string[] args)
    {
      Product fruits = new Product("Banana", 1.1, 13);
      fruits.PrintProduct();
    }
  }
}