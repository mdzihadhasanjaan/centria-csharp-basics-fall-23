namespace Exercise016
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How many days?");
      int x = int.Parse(Console.ReadLine());
      int y = 86400;
      int z = x * y;
      Console.WriteLine(z);
    }
  }
}
