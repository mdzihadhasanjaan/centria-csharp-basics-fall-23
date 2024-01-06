namespace Exercise018
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
   {
      //Call your method here:
      int num1 = int.Parse(Console.ReadLine());
      int num2 = int.Parse(Console.ReadLine());

      int ans = Smallest(num1, num2);
      Console.WriteLine($"Smallest: {ans}");
    }
    //Write your method here:
    public static int Smallest(int num1, int num2)
    {
      if(num1 < num2)
        return num1;
      else
        return num2;
    }

  }
}
