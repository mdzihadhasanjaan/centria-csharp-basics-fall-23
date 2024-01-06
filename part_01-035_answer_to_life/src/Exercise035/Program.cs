namespace Exercise036
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      while(true)
      {
        Console.WriteLine("Give a number:");
        string user = Console.ReadLine();
        int num = Convert.ToInt32(user);

        if(num > 0)
        {
          Console.WriteLine(num*num);
        }
        else if(num < 0)
        {
          Console.WriteLine("That is negative");
        }
        else
        {
          break;
        }
      }
    }
  }
}