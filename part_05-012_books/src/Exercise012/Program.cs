namespace Exercise012
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.WriteLine("Name (empty will stop):");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                Console.WriteLine("Publication year:");
                int publicationYear = Convert.ToInt32(Console.ReadLine());
                Book newBook = new Book(name, publicationYear);
                // Add unique books to the list.
                // Remember to print
                // "The book is already on the list. Let's not add the same book again."
                // If the list Contains the book



                if (books.Contains(newBook))
                    Console.WriteLine("The book is already on the list. Let's not add the same book again.");
                else
                    books.Add(newBook);
            }


            // Don't alter the line below!
            Console.WriteLine("Thank you! Books added: " + books.Count);
        }

    }
}