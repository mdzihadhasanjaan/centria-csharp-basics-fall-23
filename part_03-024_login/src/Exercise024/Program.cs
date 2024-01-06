namespace Exercise024
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
                        Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            if((username == "alex" && password == "sunshine") || (username == "emma" && password == "haskell"))
                Console.WriteLine("You have successfully logged in!");
            else
                Console.WriteLine("Incorrect username or password!");

        }
    }
}