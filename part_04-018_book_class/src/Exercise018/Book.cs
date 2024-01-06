namespace Exercise018
{
    using System;

    public class Book
    {
        public string name {get; set;}
        public int pages {get; set;}
        public int publicationYear {get; set;}

        public Book(string name, int pages, int publicationYear)
        {
            this.name = name;
            this.pages = pages;
            this.publicationYear = publicationYear;
        }

        public override string ToString()
        {
            return $"{name}, {pages} pages, {publicationYear}";
        }
    }
}