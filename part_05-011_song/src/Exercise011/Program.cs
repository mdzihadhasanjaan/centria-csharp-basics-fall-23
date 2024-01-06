namespace Exercise011
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);

            if (jackSparrow.Equals(anotherSparrow))
            {
                Console.WriteLine("Songs are equal.");
            }

            if (jackSparrow.Equals("Another object"))
            {
                Console.WriteLine("Strange things are afoot.");
            }
        }
    }
}