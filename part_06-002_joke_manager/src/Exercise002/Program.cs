namespace Exercise002
{
    using System;
    using System.Collections.Generic;

    //Section 01
    public class JokeManager
    {
        public List<string> jokes;

        public JokeManager()
        {
            this.jokes = new List<string>();
        }

        public void AddJoke(string joke)
        {
            jokes.Add(joke);
        }

        public string DrawJoke()
        {
            if (jokes.Count == 0)
            {
                Console.WriteLine("Jokes are in short supply.");
            }

            Random draw = new Random();
            int index = draw.Next(0, jokes.Count);
            return jokes[index];
        }

        public void PrintJokes()
        {
            foreach (string joke in jokes)
            {
                Console.WriteLine(joke);
            }
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            //Section - 01
            JokeManager manager = new JokeManager();
            manager.AddJoke("What is red and smells of blue paint? - Red paint.");
            manager.AddJoke("What is blue and smells of red paint? - Blue paint.");

            Console.WriteLine("Drawing jokes:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(manager.DrawJoke());
            }

            Console.WriteLine("");
            Console.WriteLine("Printing jokes:");
            manager.PrintJokes();


            
        }
    }
}