namespace Exercise010
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

      Console.WriteLine("Search for?");
      int search = int.Parse(Console.ReadLine());

      int index = 0;
      foreach(int num in list)
      {
        if(search == num)
        {
          Console.WriteLine($"{search} is at index {index}");
        }
        index++;
      }
    }

  }
}
