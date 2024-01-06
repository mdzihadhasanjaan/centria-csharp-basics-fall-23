namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise012;
    using TestMyCode.CSharp.API.Attributes;
    [Points("4-12")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestExample()
        {
            Multiplier multiplyByThree = new Multiplier(3);
            int result = multiplyByThree.Multiply(2);

            Assert.Equal(6, result);
        }

        [Fact]
        public void TestExample2()
        {
            Multiplier multiplyByFour = new Multiplier(4);
            int result = multiplyByFour.Multiply(2);

            Assert.Equal(8, result);
        }

        [Fact]
        public void TestBig()
        {
            Multiplier multiplyByFour = new Multiplier(53);
            multiplyByFour.Multiply(2);
            int result = multiplyByFour.Multiply(14);
            Assert.Equal(1484, result);
        }

        [Fact]
        public void TestBig2()
        {
            Multiplier multiplyByFour = new Multiplier(532);
            multiplyByFour.Multiply(27);
            int result = multiplyByFour.Multiply(141);
            Assert.Equal(2025324, result);
        }
    }
}
