namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
             {
            int oldest_age = -1;
            string oldest_name = "";
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "")
                    break;

                string[] parts = str.Split(",");
                int age = int.Parse(parts[1]);
                if(age > oldest_age)
                {
                    oldest_name = parts[0];
                    oldest_age = age;

                }
            }
            Console.WriteLine($"Name of the oldest: {oldest_name}");
        }

        }
    }
}