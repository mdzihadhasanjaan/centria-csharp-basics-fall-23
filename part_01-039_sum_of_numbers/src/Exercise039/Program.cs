namespace Exercise039
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      while(true)
      {
        Console.WriteLine("Give a number:");
        string user = Console.ReadLine();
        int num = Convert.ToInt32(user);
        sum += num;

        if(num == 0)
        {
          Console.WriteLine($"Total sum of numbers: {sum}");
          break;
        }
      }
    }
  }
}