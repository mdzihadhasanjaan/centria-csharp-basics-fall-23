namespace Exercise014
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      //Call your method here:
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      DivisibleByThreeInRange(a, b);
    }
    //Write your method here:
    public static void DivisibleByThreeInRange(int a, int b)
    {
      for(int i = a; i <= b; i++)
      {
        if(i % 3 == 0)
          Console.WriteLine(i);
      }
    }

  }
}
