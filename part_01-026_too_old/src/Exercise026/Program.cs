namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("Give your year of birth:");
          int userInput = int.Parse(Console.ReadLine());
          if (userInput<1899)
          {
            Console.WriteLine($"You're old");
          } 
        }
    }
}
