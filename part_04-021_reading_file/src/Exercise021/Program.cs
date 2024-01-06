namespace Exercise021
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            // Read the file data.txt and print the text from it as it is
            // You can use either File.ReadAllText or File.ReadAllLines
            string[] lines = File.ReadAllLines("data.txt");

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}