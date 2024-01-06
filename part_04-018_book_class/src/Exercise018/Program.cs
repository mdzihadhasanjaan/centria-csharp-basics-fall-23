namespace Exercise018
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // implement here the program that allows the user to enter 
            // book information and to examine them
            List<Book> list = new List<Book>();

            while(true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if(name == "")
                    break;
                
                Console.Write("Pages: ");
                int pages = int.Parse(Console.ReadLine());

                Console.Write("Publication year: ");
                int publicationYear = int.Parse(Console.ReadLine());

                Book newBook = new Book(name, pages, publicationYear);
                list.Add(newBook);
            }

            Console.WriteLine();

            Console.Write("What information will be printed? ");
            string ans = Console.ReadLine();

            foreach(Book item in list)
            {
                if(ans == "everything")
                {
                    Console.WriteLine($"{item.name}, {item.pages} pages, {item.publicationYear}");
                }
            }

            foreach(Book item in list)
            {
                if(ans == "title")
                {
                    Console.WriteLine($"{item.name}");
                }
            }


        }
    }
}