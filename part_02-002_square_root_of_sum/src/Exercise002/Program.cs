namespace Exercise002
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int n1 = Convert.ToInt32(Console.ReadLine());
      int n2 = Convert.ToInt32(Console.ReadLine());

      double root = Math.Sqrt(n1+n2);
      Console.WriteLine(root);

    }
  }
}
