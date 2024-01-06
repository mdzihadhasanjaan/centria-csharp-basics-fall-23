namespace Exercise022
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which file should have its contents printed?");
            string str = Console.ReadLine();

            string[] texts = File.ReadAllLines("data.txt");
            string[] texts2 = File.ReadAllLines("song.txt");

            if(str == "song.txt")
            {
                foreach(string text in texts2)
                {
                    Console.WriteLine(text);
                }
            }
            
            if(str == "data.txt")
            {
                foreach(string text in texts)
                {
                    Console.WriteLine(text);
                }
            }
        }
    }
}