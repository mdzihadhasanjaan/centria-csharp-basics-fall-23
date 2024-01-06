namespace Exercise024
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Your speed:");
      int userInput = int.Parse(Console.ReadLine());
      if (userInput>120)
      {
        Console.WriteLine("Speeding!");
      }
    }
  }
}
