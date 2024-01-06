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
        [Points("5-14.1")]
        public void TestAdvance()
        {
            SimpleDate date = new SimpleDate(1, 1, 1970);
            date.Advance();

            Assert.Equal("2.1.1970", date.ToString());
        }
        [Fact]
        [Points("5-14.2")]
        public void TestAdvanceModernDate()
        {
            SimpleDate date = new SimpleDate(12, 12, 2021);
            date.Advance();

            Assert.Equal("13.12.2021", date.ToString());
        }

        [Fact]
        [Points("5-14.1")]
        public void TestAdvanceParam()
        {
            SimpleDate date = new SimpleDate(1, 1, 1970);
            date.Advance(31);

            Assert.Equal("2.2.1970", date.ToString());
        }

        [Fact]
        [Points("5-14.2")]
        public void TestAdvanceParamMuch()
        {
            SimpleDate date = new SimpleDate(1, 1, 1970);
            date.Advance(360);

            Assert.Equal("1.1.1971", date.ToString());
        }

        [Fact]
        [Points("5-14.2")]
        public void TestAfterHundredDays()
        {
            SimpleDate date = new SimpleDate(1, 1, 1970);
            SimpleDate newDate = date.AfterNumberOfDays(100);

            Assert.Equal("11.4.1970", newDate.ToString());
            Assert.Equal("1.1.1970", date.ToString());
        }

        [Fact]
        [Points("5-14.1")]
        public void TestAfterThousandDays()
        {
            SimpleDate date = new SimpleDate(1, 1, 1970);
            SimpleDate newDate = date.AfterNumberOfDays(1000);

            Assert.Equal("11.10.1972", newDate.ToString());
            Assert.Equal("1.1.1970", date.ToString());
        }
    }
}
