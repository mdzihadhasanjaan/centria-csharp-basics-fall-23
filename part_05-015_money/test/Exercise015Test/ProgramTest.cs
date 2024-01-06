namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise015;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("5-15.1")]
        public void TestConstructor()
        {
            Money money = new Money(100, 1);

            Assert.Equal(typeof(Money), money.GetType());
        }

        [Fact]
        [Points("5-15.1")]
        public void TestToString()
        {
            Money money = new Money(100, 1);

            Assert.Equal("100.01e", money.ToString());
        }

        [Fact]
        [Points("5-15.1")]
        public void TestToString2()
        {
            Money money = new Money(100, 11);

            Assert.Equal("100.11e", money.ToString());
        }

        [Fact]
        [Points("5-15.1")]
        public void TestPlus()
        {
            Money money = new Money(100, 11);
            Money newMoney = money.Plus(money);

            Assert.Equal("200.22e", newMoney.ToString());
        }

        [Fact]
        [Points("5-15.1")]
        public void TestPlusCents()
        {
            Money money = new Money(100, 59);
            Money newMoney = money.Plus(money);

            Assert.Equal("201.18e", newMoney.ToString());
        }

        [Fact]
        [Points("5-15.1")]
        public void TestMinus()
        {
            Money money = new Money(100, 0);
            Money lessMoney = new Money(10, 0);
            Money newMoney = money.Minus(lessMoney);

            Assert.Equal("90.00e", newMoney.ToString());
        }

        [Fact]
        [Points("5-15.1")]
        public void TestMinusCents()
        {
            Money money = new Money(100, 59);
            Money lessMoney = new Money(10, 69);
            Money newMoney = money.Minus(lessMoney);

            Assert.Equal("89.90e", newMoney.ToString());
        }

        [Fact]
        [Points("5-15.2")]
        public void TestMinusOverValue()
        {
            Money money = new Money(100, 59);
            Money lessMoney = new Money(100, 69);
            Money newMoney = money.Minus(lessMoney);

            Assert.Equal("0.00e", newMoney.ToString());
        }


        [Fact]
        [Points("5-15.2")]
        public void TestMinusLessThanFirst()
        {
            Money money = new Money(100, 59);
            Money lessMoney = new Money(100, 69);

            Assert.Equal(false, lessMoney.LessThan(money));
        }

        [Fact]
        [Points("5-15.2")]
        public void TestMinusLessThanSecond()
        {
            Money money = new Money(101, 69);
            Money lessMoney = new Money(100, 69);

            Assert.Equal(true, lessMoney.LessThan(money));
        }
    }
}
