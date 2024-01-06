namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise008;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("5-8.1")]
        public void TestCardAddMoney()
        {
            PaymentCard card = new PaymentCard(10);
            card.AddMoney(5);

            Assert.Equal(Math.Round(Convert.ToDouble("15", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(card.balance, System.Globalization.CultureInfo.InvariantCulture), 2));
        }


        [Fact]
        [Points("5-8.1")]
        public void TestCardTakeMoneyBalance()
        {
            PaymentCard card = new PaymentCard(10);
            card.TakeMoney(8);

            Assert.Equal(2, card.balance);
        }

        [Fact]
        [Points("5-8.1")]
        public void TestCardTakeTooMuchMoneyBalance()
        {
            PaymentCard card = new PaymentCard(2);
            card.TakeMoney(8);

            Assert.Equal(2, card.balance);
        }

        [Fact]
        [Points("5-8.1")]
        public void TestCardTakeTooMuchMoneyBoolean()
        {
            PaymentCard card = new PaymentCard(2);
            Assert.False(card.TakeMoney(8));
        }

        [Fact]
        [Points("5-8.1")]
        public void TestCardTakeMoneyBoolean()
        {
            PaymentCard card = new PaymentCard(20);
            Assert.True(card.TakeMoney(8));
        }

        [Fact]
        [Points("5-8.1")]
        public void TestCardConstructor()
        {
            PaymentCard card = new PaymentCard(5);
            Assert.Equal(typeof(PaymentCard), card.GetType());
        }

        [Fact]
        [Points("5-8.2")]
        public void TestTerminalConstructor()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            Assert.Equal(typeof(PaymentTerminal), terminal.GetType());
        }

        [Fact]
        [Points("5-8.2")]
        public void TestTerminalInitialValues()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            Assert.Equal(1000, terminal.money);
            Assert.Equal(0, terminal.coffeeAmount);
            Assert.Equal(0, terminal.lunchAmount);
        }

        [Fact]
        [Points("5-8.2")]
        public void TestDrinkCoffee()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            Assert.Equal(Math.Round(Convert.ToDouble("2.5", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(terminal.DrinkCoffee(5), System.Globalization.CultureInfo.InvariantCulture), 2));
        }

        [Fact]
        [Points("5-8.2")]
        public void TestDrinkCoffeeExactMoney()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            Assert.Equal(Math.Round(Convert.ToDouble("0", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(terminal.DrinkCoffee(2.5), System.Globalization.CultureInfo.InvariantCulture), 2));
        }

        [Fact]
        [Points("5-8.2")]
        public void TestDrinkCoffeeNotEnoughMoney()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            Assert.Equal(Math.Round(Convert.ToDouble("2", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(terminal.DrinkCoffee(2), System.Globalization.CultureInfo.InvariantCulture), 2));
        }

        [Fact]
        [Points("5-8.2")]
        public void TestEatLunch()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            Assert.Equal(Math.Round(Convert.ToDouble("2", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(terminal.EatLunch(12.3), System.Globalization.CultureInfo.InvariantCulture), 2));
        }
        [Fact]
        [Points("5-8.2")]
        public void TestEatLunchExactMoney()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            Assert.Equal(Math.Round(Convert.ToDouble("0", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(terminal.EatLunch(10.3), System.Globalization.CultureInfo.InvariantCulture), 2));
        }

        [Fact]
        [Points("5-8.2")]
        public void TestEatLunchNotEnoughMoney()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            Assert.Equal(Math.Round(Convert.ToDouble("10", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(terminal.EatLunch(10), System.Globalization.CultureInfo.InvariantCulture), 2));

        }

        [Fact]
        [Points("5-8.3")]
        public void TestDrinkCoffeeFromCardBooleanTrue()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            PaymentCard card = new PaymentCard(5);
            Assert.True(terminal.DrinkCoffee(card));
        }

        [Fact]
        [Points("5-8.3")]
        public void TestDrinkCoffeeFromCardBooleanFalse()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            PaymentCard card = new PaymentCard(2);
            Assert.False(terminal.DrinkCoffee(card));
        }

        [Fact]
        [Points("5-8.3")]
        public void TestEatLunchFromCardBooleanFalse()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            PaymentCard card = new PaymentCard(2);
            Assert.False(terminal.EatLunch(card));
        }

        [Fact]
        [Points("5-8.3")]
        public void TestEatLunchFromCardBooleanTrue()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            PaymentCard card = new PaymentCard(11);
            Assert.True(terminal.EatLunch(card));
        }


        [Fact]
        [Points("5-8.3")]
        public void TestEatLunchFromCard()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            PaymentCard card = new PaymentCard(11);
            terminal.EatLunch(card);
            Assert.Equal(Math.Round(Convert.ToDouble("0.7", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(card.balance, System.Globalization.CultureInfo.InvariantCulture), 2));
        }

        [Fact]
        [Points("5-8.3")]
        public void TestEatLunchFromCardNotEnoughMoney()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            PaymentCard card = new PaymentCard(10);
            terminal.EatLunch(card);
            Assert.Equal(Math.Round(Convert.ToDouble("10", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(card.balance, System.Globalization.CultureInfo.InvariantCulture), 2));

        }

        [Fact]
        [Points("5-8.4")]
        public void TestAddMoneyToBalances()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            PaymentCard card = new PaymentCard(10);
            terminal.AddMoneyToCard(card, 10);
            Assert.Equal(Math.Round(Convert.ToDouble("20", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(card.balance, System.Globalization.CultureInfo.InvariantCulture), 2));
            Assert.Equal(Math.Round(Convert.ToDouble("1010", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(terminal.money, System.Globalization.CultureInfo.InvariantCulture), 2));
        }

        [Fact]
        [Points("5-8.4")]
        public void TestAddNegativeMoneyDoesNotChangeBalances()
        {
            PaymentTerminal terminal = new PaymentTerminal();
            PaymentCard card = new PaymentCard(10);
            terminal.AddMoneyToCard(card, -10);
            Assert.Equal(Math.Round(Convert.ToDouble("10", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(card.balance, System.Globalization.CultureInfo.InvariantCulture), 2));
            Assert.Equal(Math.Round(Convert.ToDouble("1000", System.Globalization.CultureInfo.InvariantCulture), 2), Math.Round(Convert.ToDouble(terminal.money, System.Globalization.CultureInfo.InvariantCulture), 2));
        }
    }
}
