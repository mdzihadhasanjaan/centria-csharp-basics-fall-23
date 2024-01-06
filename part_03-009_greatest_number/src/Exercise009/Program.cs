namespace Exercise009
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    { 
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }

      int max = list[0];
      foreach(int num in list)
      {
        if(num > max)
          max = num;
      }

      Console.WriteLine($"The greatest number: {max}");
    }

    
  }
}

