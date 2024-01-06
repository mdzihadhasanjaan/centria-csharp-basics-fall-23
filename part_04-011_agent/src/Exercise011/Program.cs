namespace Exercise011
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Agent bond = new Agent("James", "Bond");
            Console.WriteLine(bond);

            Agent bourne = new Agent("Jason", "Bourne");
            Console.WriteLine(bourne);
        }
    }
}