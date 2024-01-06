namespace Exercise010
{
    using System;
    public class Apartment
    {

        private int rooms;
        private int squares;
        private int pricePerSquare;

        public Apartment(int rooms, int squares, int pricePerSquare)
        {
            this.rooms = rooms;
            this.squares = squares;
            this.pricePerSquare = pricePerSquare;
        }

        public bool LargerThan(Apartment compared)
        {
            if(this.squares > compared.squares)
                return true;
            else
                return false;
        }

        private int Price()
        {
            return squares * pricePerSquare;;
        }

        public int PriceDifference(Apartment compared)
        {
            // Math.Abs returns the absolute value
            return Math.Abs(this.Price() - compared.Price());             
        }

        public bool MoreExpensiveThan(Apartment compared)
        {
            if(this.Price() > compared.Price())
                return true;
            else
                return false;
        }
    }
}