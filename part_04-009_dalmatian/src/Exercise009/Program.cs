namespace Exercise009
{
    using System;
    public class Dalmatian
    {
        public string name {get; set;}
        public int spots {get; set;}

        public Dalmatian(string name, int spots)
        {
            this.name = name;
            this.spots = spots;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Dalmatian spotty = new Dalmatian("Spot", 306);
            Console.WriteLine(spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur");
        }
    }
}