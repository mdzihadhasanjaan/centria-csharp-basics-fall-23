namespace Exercise028
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How old are you?");
      int userInput = int.Parse(Console.ReadLine());
      if (userInput < 18)
      {
        Console.WriteLine("You're under age!");
      
      }

      else

      {
        Console.WriteLine("You're an adult!");
      }

    }
  }
}
