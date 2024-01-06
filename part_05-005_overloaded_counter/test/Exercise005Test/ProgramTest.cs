namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise005;
    using TestMyCode.CSharp.API.Attributes;
    [Points("5-5")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestCounterNullConstructor()
        {
            Counter counter = new Counter();

            Assert.Equal(typeof(Counter), counter.GetType());
        }

        [Fact]
        public void TestCounterStartNumberConstructor()
        {
            Counter counter = new Counter(2);

            Assert.Equal(typeof(Counter), counter.GetType());
        }

        [Fact]
        public void TestCounterIncrease()
        {
            Counter counter = new Counter(2);
            counter.Increase();

            Assert.Equal(3, counter.value);
        }

        [Fact]
        public void TestCounterIncreaseMore()
        {
            Counter counter = new Counter();
            counter.Increase();

            Assert.Equal(1, counter.value);
        }

        [Fact]
        public void TestDecrease()
        {
            Counter counter = new Counter();
            counter.Decrease();

            Assert.Equal(-1, counter.value);
        }

        [Fact]
        public void TestDecreaseBy10()
        {
            Counter counter = new Counter();
            counter.Decrease(10);

            Assert.Equal(-10, counter.value);
        }

        [Fact]
        public void TestIncreaseBy12()
        {
            Counter counter = new Counter();
            counter.Increase(12);

            Assert.Equal(12, counter.value);
        }

        [Fact]
        public void TestDecreaseByNEGATIVE10()
        {
            Counter counter = new Counter();
            counter.Decrease(-10);

            Assert.Equal(0, counter.value);
        }

        [Fact]
        public void TestIncreaseByNEGATIVE10()
        {
            Counter counter = new Counter();
            counter.Increase(-10);

            Assert.Equal(0, counter.value);
        }

        [Fact]
        public void TestDecreaseExistingValueByNEGATIVE15()
        {
            Counter counter = new Counter(22);
            counter.Decrease(-15);

            Assert.Equal(22, counter.value);
        }

        [Fact]
        public void TestIncreaseExistingByNEGATIVE12()
        {
            Counter counter = new Counter(15);
            counter.Increase(-12);

            Assert.Equal(15, counter.value);
        }

        [Fact]
        public void TestRandom()
        {
            Random rand = new Random();
            int rando1 = rand.Next(1, 100);
            Counter counter = new Counter(rando1);
            int rando2 = rand.Next(2, 10000);
            counter.Increase(rando2);

            Assert.Equal(rando1 + rando2, counter.value);
        }
    }
}
