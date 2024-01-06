namespace Exercise019
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int answer = Greatest(5, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }
    
    //Write your method here
    public static int Greatest(int a, int b, int c)
    {
      if(a > b && a > c)
        return a;
      else if(b > c)
        return b;
      else
       return c;
    }

    
    //Write your method here
  }
}
