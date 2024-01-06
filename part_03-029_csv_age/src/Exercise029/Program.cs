namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            {
            List<int> ages = new List<int>();
            while(true)
            {
                string str = Console.ReadLine();
                if(str == "")
                    break;
                
                string[] age = str.Split(",");
                int int_age = int.Parse(age[1]);
                ages.Add(int_age);
                
            }
            int oldest = ages.Max();
            Console.WriteLine($"Age of the oldest: {oldest}");
        }

        }
    }
}