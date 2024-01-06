namespace Exercise016
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
            //Write your method here:
      List<string> strings = new List<string>();

      strings.Add("First");
      strings.Add("Second");
      strings.Add("Third");

      // Remember, this is how you print all the items in a list
      strings.ForEach(Console.WriteLine);

      RemoveLast(strings);
      RemoveLast(strings);

      strings.ForEach(Console.WriteLine);
    }

    public static void RemoveLast(List<string> list)
    {
      list.Remove(list[list.Count-1]);


    }
  }
}
