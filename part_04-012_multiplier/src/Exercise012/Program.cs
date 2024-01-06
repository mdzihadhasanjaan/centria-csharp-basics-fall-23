namespace Exercise012
{
    using System;
    public class Multiplier
    {
        public int value;

        public Multiplier(int number)
        {
            this.value = number;
        }

        public int Multiply(int number)
        {
            int result = number * value;
            value = result;
            return result;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Multiplier multiplyByThree = new Multiplier(3);

            Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));

            Multiplier multiplyByFour = new Multiplier(4);

            Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
            Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
            Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
            Console.WriteLine("multiplyByFour.Multiply(3): " + multiplyByFour.Multiply(3));

        }
    }
}