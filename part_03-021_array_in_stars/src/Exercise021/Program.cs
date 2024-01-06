namespace Exercise021
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
            int[] array = {5, 1, 3, 4, 2};
      PrintArrayInStars(array);
    }

    public static void PrintArrayInStars(int[] arr)
    {
      foreach(int i in arr)
      {
        for(int j = 0; j < i; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }

    }

  }
}