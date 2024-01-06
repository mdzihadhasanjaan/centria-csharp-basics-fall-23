namespace Exercise013
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            // Ask for input as shown in the exercise.
            while(true)
            {
                Console.WriteLine("Identifier? (empty will stop):");
                string id = Console.ReadLine();
                if(id == "")
                    break;

                Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();
                if(name == "")
                    break;

                Item newItem = new Item(id, name);
                if(!items.Contains(newItem))
                    items.Add(newItem);
            }

            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}