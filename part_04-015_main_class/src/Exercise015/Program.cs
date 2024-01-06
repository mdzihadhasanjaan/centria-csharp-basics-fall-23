namespace Exercise015
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>();
            while (true)
            {
                Console.Write("Name: ");
                string itemName = Console.ReadLine();

                if (itemName == "")
                    break;

                Item newItem = new Item(itemName);
                items.Add(newItem);
                

            }

            Console.WriteLine();
            foreach (Item name in items)
            {
                // Print using ToString
                Console.WriteLine(name.ToString());

            }

        }
    }
}