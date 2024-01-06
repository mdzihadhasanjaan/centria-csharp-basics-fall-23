namespace Exercise012
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

      int sum = 0;
      foreach(int num in list)
      {
        sum += num;
      }

      Console.WriteLine($"Sum: {sum}");
    }
  }
    
  }

