namespace Exercise011
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
       {
      List<int> list = new List<int>();

      while(true)
      {
        int input = int.Parse(Console.ReadLine());
        if(input == 9999)
        {
          break;
        }
      
        list.Add(input);
      }

      int min = list[0];
     
      foreach(int num in list)
      {
        if(num < min)
          min = num;
      }

      Console.WriteLine($"Smallest number: {min}");

      int index = 0;
      foreach(int num in list)
      {
        if(min == num)
          Console.WriteLine($"Found at index: {index}");

        index++;
      }
      
    }

    }
  }
}
