namespace Exercise013
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      //Call your method here
      Division(72, 7);
    }
    //Write your method here
    public static void Division(int numerator, int denominator)
    {
      double result = numerator / (double) denominator;
      Console.WriteLine(result);
    }

  }
}
