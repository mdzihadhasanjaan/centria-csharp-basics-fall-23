namespace Exercise015
{
    public class Money
    {

        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            this.euros = euros;
            this.cents = cents;
        }


        public Money Plus(Money addition)
        {
            Money newMoney = new Money(euros, cents);
            // create a new Money object that has the correct worth
            int totalEuros = euros + addition.euros;
            int totalCents = cents + addition.cents;

            if(totalCents > 99)
            {
                totalEuros += totalCents / 100;
                totalCents %= 100;
            }
            // return the new Money object
            return new Money(totalEuros, totalCents);
        }

        public Money Minus(Money decreaser)
        {
            Money newMoney = new Money(euros, cents);
            // create a new Money object that has the correct worth
            int diffEuros = euros - decreaser.euros;
            int diffCents = cents - decreaser.cents;

            if(diffCents < 0)
            {
                diffEuros--;
                diffCents += 100;
            }

            if(diffEuros < 0)
            {
                diffEuros = 0;
                diffCents = 0;
            }
            // return the new Money object
            return new Money(diffEuros, diffCents);
        }

        public bool LessThan(Money compared)
        {
            // Do something here
            if(euros < compared.euros || (euros == compared.euros && cents < compared.cents))
                return true;
    
            return false;
        }

        public override string ToString()
        {
            string zero = "";
            if (this.cents <= 10)
            {
                zero = "0";
            }

            return this.euros + "." + zero + this.cents + "e";
        }
    }
}