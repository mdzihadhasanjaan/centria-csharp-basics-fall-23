namespace Exercise012
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      //call your method here:
      PrintFromNumberToOne(5);
    }
    //write your method here:
    public static void PrintFromNumberToOne(int number)
    {
      for(int i = number; i >= 1; i--)
      {
        Console.WriteLine(i);
      }
    } 

  }
}
