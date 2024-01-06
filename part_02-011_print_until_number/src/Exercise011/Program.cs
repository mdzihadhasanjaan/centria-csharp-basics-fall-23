namespace Exercise011
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
  {
      //call your method here:
      PrintUntilNumber(5);
    }
    //write your method here:
    public static void PrintUntilNumber(int number)
    {
      for(int i = 1; i <= number; i++)
      {
        Console.WriteLine(i);
      }
    }
  
  }
}
