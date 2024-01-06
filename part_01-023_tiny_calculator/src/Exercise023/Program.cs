namespace Exercise023
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");
      int num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Give the second number!");
      int num2 = int.Parse(Console.ReadLine());
      int sum = num1 + num2;
      int sub = num1 - num2;
      int mul = num1 * num2;
      double division = (double)num1 / num2;
      Console.WriteLine($"{num1} + {num2} = {sum}");
      Console.WriteLine($"{num1} - {num2} = {sub}");
      Console.WriteLine($"{num1} * {num2} = {mul}");
      Console.WriteLine($"{num1} / {num2} = {division}");
    }
  }
}
