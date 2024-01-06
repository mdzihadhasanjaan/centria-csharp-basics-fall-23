namespace Exercise013
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number!");
      string inputString = Console.ReadLine();
      double doubleValue = Convert.ToDouble(inputString);
      Console.WriteLine($"You gave {doubleValue}");
    }
  }
}
