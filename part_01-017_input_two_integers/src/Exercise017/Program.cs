namespace Exercise017
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      int firstNum = int.Parse(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int secondNum = int.Parse(Console.ReadLine());
      int sum = firstNum + secondNum;
      Console.WriteLine($"The sum is {sum}");

    }
  }
}