namespace Exercise010
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("I will tell a story, but I need some information.");
      Console.WriteLine("Give a name for main character:");
      string inputString1 = Console.ReadLine();
      Console.WriteLine("Give the character a profession:");
      string inputString2 = Console.ReadLine();
      Console.WriteLine("Here is the story:");
      Console.WriteLine($"Once upon a time there was a {inputString2} called {inputString1}\nOn her way to work, {inputString1} often pondered what being {inputString2} meant to them.\nWhen you work as a {inputString2} you meet interesting people.\n{inputString1} enjoys their work as {inputString2}, The end.");
    }
  }
}
