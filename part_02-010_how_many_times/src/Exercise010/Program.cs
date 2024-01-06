namespace Exercise010
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {//Write your code here
      Console.WriteLine("How many times?");
      int times = int.Parse(Console.ReadLine());

      int i = 0;
      while(i < times)
      {
        PrintPhrase();
        i++;
      }
    }
    //Write your method here
    public static void PrintPhrase()
    {
      Console.WriteLine("In a hole in the ground there lived a method");
    }
}
  }

