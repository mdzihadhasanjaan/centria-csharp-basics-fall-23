namespace Exercise029
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int num1, num2;

        Console.WriteLine("Give the first number!");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Give the second number!");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("The larger number is " + num1 + "!");
        }
        else if (num2 > num1)
        {
            Console.WriteLine("The larger number is " + num2 + "!");
        }
        else
        {
            Console.WriteLine("They are equal!");

    }
  }
}
}
