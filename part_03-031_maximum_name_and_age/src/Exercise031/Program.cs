namespace Exercise031
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            {
            int currentYear = DateTime.Now.Year;
            int highest_age = -1;
            string longest_name = "";
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "")
                    break;

                string[] parts = str.Split(",");

                string name = parts[0];
                int length_name = name.Length;
                if(length_name > highest_age)
                {
                    highest_age = length_name;
                    longest_name = name;
                }

                int year = int.Parse(parts[1]);
                int age = currentYear - year;
                if(age > highest_age)
                {
                    highest_age = age;

                }
            }
            Console.WriteLine($"Longest name: {longest_name}");
            Console.WriteLine($"Highest age: {highest_age}");
        }

        }
    }
}