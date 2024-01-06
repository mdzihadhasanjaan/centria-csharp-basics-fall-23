namespace Exercise030
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine($"Give your percent [0 - 100]:");
      int userInput = int.Parse(Console.ReadLine());
      if (userInput < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (userInput < 49)
      {
        Console.WriteLine("Fail");

      }
      else if (userInput <= 59)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (userInput <= 69)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (userInput <= 79)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (userInput <= 89)
      {
        Console.WriteLine("Grade: 4");
      
      }
      else if (userInput <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      if (userInput > 100)
      {
        Console.WriteLine("Outstanding!");
      }
    }
  }
}
