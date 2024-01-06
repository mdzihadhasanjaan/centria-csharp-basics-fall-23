namespace Exercise025
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      int userInput = int.Parse(Console.ReadLine());
      if (userInput == 1984)
      {
        Console.WriteLine("Orwell");
      }
    }
  }
}
