namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise019;
    using TestMyCode.CSharp.API.Attributes;
    [Points("2-19")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestGreatest1()
        {
            int greatest = Program.Greatest(1, 3, 4);

            int comparison = 4;

            Assert.Equal(comparison, greatest);
        }

        [Fact]
        public void TestGreatest2()
        {
            int greatest = Program.Greatest(5, 3, 1);

            int comparison = 5;

            Assert.Equal(comparison, greatest);
        }

        [Fact]
        public void TestGreatest3()
        {
            int greatest = Program.Greatest(5, 8, 1);

            int comparison = 8;

            Assert.Equal(comparison, greatest);
        }

        [Fact]
        public void TestAllEqual()
        {
            int greatest = Program.Greatest(5, 5, 5);

            int comparison = 5;

            Assert.Equal(comparison, greatest);
        }

        [Fact]
        public void Test2GreatestEquals()
        {
            int greatest = Program.Greatest(7, 7, 2);

            int comparison = 7;

            Assert.Equal(comparison, greatest);
        }

        [Fact]
        public void Test2SmallerEquals()
        {
            int greatest = Program.Greatest(3, 2, 2);

            int comparison = 3;

            Assert.Equal(comparison, greatest);
        }

        [Fact]
        public void Test2FirstAreSmallest()
        {
            int greatest = Program.Greatest(2, 2, 3);

            int comparison = 3;

            Assert.Equal(comparison, greatest);
        }
    }
}
