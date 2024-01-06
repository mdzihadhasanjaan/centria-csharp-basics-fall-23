namespace Exercise007
{
    using System;
    public class DecreasingCounter
    {
        private int value;   // a variable that remembers the value of the counter

        public DecreasingCounter(int initialValue)
        {
            this.value = initialValue;
        }

        public void PrintValue()
        {
            Console.WriteLine("value: " + this.value);
        }

        public void Decrement()
        {
            // write the method implementation here
            // the aim is to decrement the value of the counter by one
            if(value > 0)
                value--;
        }

        public void Reset()
        {
            // write the method implementation here
            value *= 0;
        }
    }
}