namespace Exercise014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            SimpleDate date = new SimpleDate(13, 2, 2015);
            Console.WriteLine("Friday of the examined week is " + date);

            SimpleDate newDate = date.AfterNumberOfDays(7);
            int week = 1;
            while (week <= 7)
            {
                Console.WriteLine("Friday after " + week + " weeks is " + newDate);
                newDate = newDate.AfterNumberOfDays(7);

                week = week + 1;
            }

            Console.WriteLine("The date after 790 days from the examined Friday is ... try it out yourself!");
        }
    }
}