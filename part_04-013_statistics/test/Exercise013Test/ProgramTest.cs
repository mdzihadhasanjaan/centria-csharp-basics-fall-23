namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise013;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    [Points("4-13")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestExampleCount()
        {
            Statistics statistics = new Statistics();
            statistics.AddNumber(3);
            statistics.AddNumber(5);
            statistics.AddNumber(1);
            statistics.AddNumber(2);

            Assert.Equal(4, statistics.count);
        }

        [Fact]
        public void TestExampleSum()
        {
            Statistics statistics = new Statistics();
            statistics.AddNumber(3);
            statistics.AddNumber(5);
            statistics.AddNumber(1);
            statistics.AddNumber(2);

            Assert.Equal(11, statistics.sum);
        }

        [Fact]
        public void TestLargerCount()
        {
            Statistics statistics = new Statistics();
            statistics.AddNumber(37);
            statistics.AddNumber(-45);
            statistics.AddNumber(21);
            statistics.AddNumber(444);
            statistics.AddNumber(444);
            statistics.AddNumber(444);
            statistics.AddNumber(444);
            statistics.AddNumber(444);
            statistics.AddNumber(444);

            Assert.Equal(9, statistics.count);
        }

        [Fact]
        public void TestLargerSum()
        {
            Statistics statistics = new Statistics();
            statistics.AddNumber(37);
            statistics.AddNumber(-45);
            statistics.AddNumber(21);
            statistics.AddNumber(444);
            statistics.AddNumber(444);
            statistics.AddNumber(444);
            statistics.AddNumber(444);
            statistics.AddNumber(444);
            statistics.AddNumber(444);

            Assert.Equal(2677, statistics.sum);
        }

    }
}
