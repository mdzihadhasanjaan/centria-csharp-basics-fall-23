namespace Exercise013
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Statistics statistics = new Statistics();
            statistics.AddNumber(3);
            statistics.AddNumber(5);
            statistics.AddNumber(1);
            statistics.AddNumber(2);
            Console.WriteLine("Count: " + statistics.count);
            Console.WriteLine("Sum: " + statistics.sum);
        }
    }
}