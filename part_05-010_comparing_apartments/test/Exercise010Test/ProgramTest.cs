namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise010;
    using TestMyCode.CSharp.API.Attributes;
    [Points("5-10")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestApartmentConstructor()
        {
            Apartment house = new Apartment(2, 3, 100);

            Assert.Equal(typeof(Apartment), house.GetType());
        }

        [Fact]
        public void TestApartmentMoreExpensiveFirst()
        {
            Apartment house = new Apartment(2, 3, 100);
            Apartment house2 = new Apartment(2, 3, 50);
            Assert.True(house.MoreExpensiveThan(house2));
        }

        [Fact]
        public void TestApartmentMoreExpensiveSecond()
        {
            Apartment house = new Apartment(2, 3, 100);
            Apartment house2 = new Apartment(2, 3, 500);
            Assert.False(house.MoreExpensiveThan(house2));
        }

        [Fact]
        public void TestApartmentMoreExpensiveSecondSmall()
        {
            Apartment house = new Apartment(2, 300, 100);
            Apartment house2 = new Apartment(6, 3, 50000);
            Assert.False(house.MoreExpensiveThan(house2));
        }

        [Fact]
        public void TestApartmentPriceDifferenceFirst()
        {
            Apartment house = new Apartment(2, 350, 1000);
            Apartment house2 = new Apartment(2, 30, 3500);
            Assert.Equal(245000, house.PriceDifference(house2));
        }

        [Fact]
        public void TestApartmentPriceDifferenceSecond()
        {
            Apartment house = new Apartment(2, 35, 1000);
            Apartment house2 = new Apartment(2, 30, 3500);
            Assert.Equal(70000, house.PriceDifference(house2));
        }

        [Fact]
        public void TestLargerThanFirst()
        {
            Apartment house = new Apartment(2, 35, 1000);
            Apartment house2 = new Apartment(2, 30, 3500);
            Assert.True(house.LargerThan(house2));
        }

        [Fact]
        public void TestLargerThanSecond()
        {
            Apartment house = new Apartment(2, 35, 1000);
            Apartment house2 = new Apartment(2, 36, 3500);
            Assert.False(house.LargerThan(house2));
        }

        [Fact]
        public void TestEqualApartments()
        {
            Apartment house = new Apartment(2, 35, 1000);
            Apartment house2 = new Apartment(2, 35, 1000);
            Assert.False(house.LargerThan(house2));
            Assert.Equal(0, house.PriceDifference(house2));
            Assert.False(house.MoreExpensiveThan(house2));

            Assert.False(house2.LargerThan(house));
            Assert.Equal(0, house2.PriceDifference(house));
            Assert.False(house2.MoreExpensiveThan(house));
        }

        [Fact]
        public void TestOnSelf()
        {
            Apartment house = new Apartment(2, 35, 1000);
            Assert.False(house.LargerThan(house));
            Assert.Equal(0, house.PriceDifference(house));
            Assert.False(house.MoreExpensiveThan(house));

        }
    }
}
