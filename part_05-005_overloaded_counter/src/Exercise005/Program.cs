namespace Exercise005
{
    using System;

    public class Counter
    {
        public int value { get; set; }
        public Counter(int startValue)
        {
            this.value = startValue;
        }

        public Counter() : this(0)
        {

        }

        public void Increase()
        {
            value++;
            Console.WriteLine($"Increase by one: ${value}");
        }

        public void Decrease()
        {
            value--;
            Console.WriteLine($"Decrease by one: ${value}");
        }

        public void Increase(int increaseBy)
        {
            if (increaseBy > 0)
            {
                value += increaseBy;
                Console.WriteLine($"Increase by increaseBy value: ${value}");
            }

        }

        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                value -= decreaseBy;
                Console.WriteLine($"Decrease by decreaseBy value: ${value}");
            }

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Counter myNumber = new Counter(0);

            myNumber.Increase();
            myNumber.Decrease();

            myNumber.Increase(5);
            myNumber.Decrease(7);
            myNumber.Decrease(-3);
        }
    }
}