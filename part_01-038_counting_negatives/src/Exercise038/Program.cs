namespace Exercise038
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int count = 0;
      while(true)
      {
        Console.WriteLine("Give a number:");
        string user = Console.ReadLine();
        int num = Convert.ToInt32(user);
        

        if(num == 0)
        {
          Console.WriteLine($"Total amount of negative numbers: {count}");
          break;
        }
        if(num < 0)
        {
          count++;
        }
      }
    }
  }
}