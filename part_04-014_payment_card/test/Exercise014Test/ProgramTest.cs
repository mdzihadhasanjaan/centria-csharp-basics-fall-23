namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise014;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {

        [Fact]
        [Points("4-14.1")]
        public void TestToString()
        {
            {
                PaymentCard card = new PaymentCard(501);

                // Assert
                Assert.Equal("The card has a balance of 501 euros", card.ToString());

            }
        }

        [Fact]
        [Points("4-14.1")]
        public void TestToString42()
        {
            {
                PaymentCard card = new PaymentCard(42);

                // Assert
                Assert.Equal("The card has a balance of 42 euros", card.ToString());

            }
        }

        [Fact]
        [Points("4-14.1")]
        public void TestToStringDouble()
        {
            {
                PaymentCard card = new PaymentCard(42.42);

                // Assert
                Assert.Equal("The card has a balance of 42.42 euros", card.ToString().Replace(",", "."));

            }
        }

        [Fact]
        [Points("4-14.1")]
        public void TestMultipleCards()
        {
            {
                PaymentCard card = new PaymentCard(42.42);
                PaymentCard another = new PaymentCard(420.69);

                // Assert
                Assert.Equal("The card has a balance of 42.42 euros", card.ToString().Replace(",", "."));
                Assert.Equal("The card has a balance of 420.69 euros", another.ToString().Replace(",", "."));

            }
        }

        [Fact]
        [Points("4-14.2")]
        public void TestEatLunch()
        {
            {
                PaymentCard card = new PaymentCard(12.6);
                card.EatLunch();

                // Assert
                Assert.Equal("The card has a balance of 2 euros", card.ToString());

            }
        }

        [Fact]
        [Points("4-14.2")]
        public void TestDrinkCoffee()
        {
            {
                PaymentCard card = new PaymentCard(10);
                card.DrinkCoffee();

                // Assert
                Assert.Equal("The card has a balance of 8 euros", card.ToString());

            }
        }

        [Fact]
        [Points("4-14.2")]
        public void TestDrinkCoffeeAndEatLunch()
        {
            {
                PaymentCard card = new PaymentCard(100);
                card.DrinkCoffee();
                card.EatLunch();

                // Assert
                Assert.Equal("The card has a balance of 87.4 euros", card.ToString().Replace(",", "."));

            }
        }

        [Fact]
        [Points("4-14.3")]
        public void TestEatLunchNotEnoughMoney()
        {
            {
                PaymentCard card = new PaymentCard(8);
                card.EatLunch();

                // Assert
                Assert.Equal("The card has a balance of 8 euros", card.ToString());

            }
        }

        [Fact]
        [Points("4-14.3")]
        public void TestDrinkTooMuchCoffee()
        {
            {
                PaymentCard card = new PaymentCard(9);
                card.DrinkCoffee();
                card.DrinkCoffee();
                card.DrinkCoffee();
                card.DrinkCoffee();
                card.DrinkCoffee();

                // Assert
                Assert.Equal("The card has a balance of 1 euros", card.ToString());

            }
        }

        [Fact]
        [Points("4-14.4")]
        public void TestAddMoney()
        {
            {
                PaymentCard card = new PaymentCard(10);
                card.AddMoney(20);

                // Assert
                Assert.Equal("The card has a balance of 30 euros", card.ToString());

            }
        }

        [Fact]
        [Points("4-14.4")]
        public void TestAddTooMuchMoney()
        {
            {
                PaymentCard card = new PaymentCard(10);
                card.AddMoney(200);

                // Assert
                Assert.Equal("The card has a balance of 150 euros", card.ToString());

            }
        }

        [Fact]
        [Points("4-14.4")]
        public void TestAddNegativeMoney()
        {
            {
                PaymentCard card = new PaymentCard(10);
                card.AddMoney(-5);

                // Assert
                Assert.Equal("The card has a balance of 10 euros", card.ToString());

            }
        }
    }
}
