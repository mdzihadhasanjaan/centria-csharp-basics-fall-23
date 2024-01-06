namespace Exercise007
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {

     Console.WriteLine("Where to?");
      int to = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("Where from?");
     int from = Convert.ToInt32(Console.ReadLine());

     if (from <= to)

     {

     PrintNumbers(from, to);
     }
      else
     {
      Console.WriteLine("If the upper limit is larger than the starting point, nothing is printed.");
     }
     }

     static void PrintNumbers(int start, int end)
      {
      for (int i = start; i <= end; i++)
      {
       Console.WriteLine(i);
      }
      


    }
  }
}