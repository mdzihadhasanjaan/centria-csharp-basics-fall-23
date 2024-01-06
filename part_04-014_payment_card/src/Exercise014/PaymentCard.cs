namespace Exercise014
{
    public class PaymentCard
    {
        private double balance;
        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }
        
        public void EatLunch()
        {
            if(balance > 10.60)
                balance -= 10.60;
        }

        public void DrinkCoffee()
        {
            if(balance > 2.0)
                balance -= 2.0;
        }

        public void AddMoney(double amount)
        {
            if(amount > 0)
                balance += amount;
            if(balance > 150)
                balance = 150;
        }

        public override string ToString()
        {
            // write code here
            return $"The card has a balance of {balance} euros";
        }
    }
}