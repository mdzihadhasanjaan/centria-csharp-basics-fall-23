namespace Exercise015
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a string:");
      string inputString = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      int inputInt = int.Parse(Console.ReadLine());
      Console.WriteLine("Give a double:");
      double inputDouble = double.Parse(Console.ReadLine());
      Console.WriteLine("Give a boolean:");
      bool inputBoolean = bool.Parse(Console.ReadLine());

      // now we are goin to print output:

      Console.WriteLine("Your string: " + inputString);
      Console.WriteLine($"Your integer: {inputInt}");
      Console.WriteLine($"Your double: {inputDouble}");
      Console.WriteLine($"Your boolean: {inputBoolean}");
    }
  }
}
