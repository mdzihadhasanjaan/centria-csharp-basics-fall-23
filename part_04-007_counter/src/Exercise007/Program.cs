namespace Exercise007
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DecreasingCounter counter = new DecreasingCounter(20);
            counter.PrintValue();

            counter.Reset();
            counter.PrintValue();
        }
    }
}