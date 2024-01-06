namespace Exercise012
{
    public class Book
    {

        private string name;
        private int publicationYear;

        public Book(string name, int publicationYear)
        {
            this.name = name;
            this.publicationYear = publicationYear;
        }



        public override bool Equals(object compared)
        {
           if(compared == null || GetType() != compared.GetType())
                return false;
            
            Book other = (Book)compared;
            return name == other.name && publicationYear == other.publicationYear;
        } 
    }
}