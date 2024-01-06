namespace Exercise013
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

      Console.WriteLine("Search for?");
      string name = Console.ReadLine();

      bool isFound = false;
      foreach(string nimi in list)
      {
        if(name == nimi)
        {
          isFound = true;
          break;
        }
      }
      if(isFound)
        Console.WriteLine($"{name} was found!");
      else
        Console.WriteLine($"{name} was not found!");
    }

  }
}
