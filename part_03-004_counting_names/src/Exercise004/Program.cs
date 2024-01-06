namespace Exercise004
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }

      //Write your code here
      Console.WriteLine($"In total: {list.Count}");
    }

  }
}
