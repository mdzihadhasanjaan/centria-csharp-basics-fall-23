namespace Exercise004
{
    public class Room
    {
        private string code;
        private int seats;
        public Room(string classCode, int numberOfSeats)
        {
            this.code = classCode;
            this.seats = numberOfSeats;
        }
    }
}