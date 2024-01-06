namespace Exercise014
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
     Console.WriteLine("Give me the truth!");
        string input = Console.ReadLine();
        bool truth = bool.Parse(input);
        if (truth)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
  }
}
