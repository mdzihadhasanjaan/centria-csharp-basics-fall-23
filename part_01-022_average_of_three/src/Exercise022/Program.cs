﻿namespace Exercise022
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
      Console.WriteLine("Give the third number!");
      int num3 = int.Parse(Console.ReadLine());
      double avr = (num1 + num2 + num3) / 3.0;
      Console.WriteLine($"The average is {avr}");
      

    }
  }
}
