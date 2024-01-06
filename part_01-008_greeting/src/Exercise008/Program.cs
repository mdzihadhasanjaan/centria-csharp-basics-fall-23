namespace Exercise008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string inputString = Console.ReadLine();
            Console.WriteLine($"Hello {inputString}!");
        }
    }
}
