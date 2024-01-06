namespace Exercise008
{
    public class PaymentTerminal
    {
        public double money { get; private set; }  // amount of cash
        public int coffeeAmount { get; private set; } // number of sold coffees
        public int lunchAmount { get; private set; }  // number of sold lunches

        public PaymentTerminal()
        {
            // register initially has 1000 euros of money
            this.money = 1000;
        }

        public double DrinkCoffee(double payment)
        {
            // an coffee now costs 2.50 euros
            // increase the amount of cash by the price of an coffee mean and return the change
            // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment
            if (payment >= 2.50)
            {
                money += 2.50;
                coffeeAmount++;
                return payment - 2.50;
            }
            else
                return payment;

        }

        public double EatLunch(double payment)
        {
            // a lunch now costs 10.30 euros
            // increase the amount of cash by the price of a lunch and return the change
            // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment
            if (payment >= 10.30)
            {
                money += 10.30;
                lunchAmount++;
                return payment - 10.30;
            }
            else
                return payment;
        }


        public bool DrinkCoffee(PaymentCard card)
        {
            // a coffee costs 2.50 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            double coffeePrice = 2.50;
            if (card.TakeMoney(coffeePrice))
            {
                coffeeAmount++;
                return true;
            }
            else
                return false;
        }

        public bool EatLunch(PaymentCard card)
        {
            // a lunch costs 10.30 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            double lunchPrice = 10.30;
            if (card.TakeMoney(lunchPrice))
            {
                lunchAmount++;
                return true;
            }
            else
                return false;
        }
        public void AddMoneyToCard(PaymentCard card, double sum)
        {
            // Only add positive amounts
            if (sum >= 0)
            {
                this.money += sum;
                card.AddMoney(sum);
            }
        }

        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}