namespace Exercise025
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      
      while (true)
      {
        string str = Console.ReadLine();

        if (str == "")
          break;

        string[] pieces = str.Split(" ");
        foreach (string piece in pieces)
        {
          Console.WriteLine(piece);

    }
  }
}
  }
}
