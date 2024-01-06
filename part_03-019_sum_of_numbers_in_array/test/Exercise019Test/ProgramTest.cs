namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise019;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-19")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestSumOfNumers()
        {
            {
                int[] numbers = { 5, 1, 3, 4, 2 };
                int sum = Program.SumOfNumbersInArray(numbers);

                Assert.Equal(15, sum);
            }
        }

        [Fact]
        public void TestTestSumOfNumersTwice()
        {
            {
                int[] numbers = { 5, 1, 3, 4, 2, 1 };
                int sum = Program.SumOfNumbersInArray(numbers);

                Assert.Equal(16, sum);
            }
        }

        [Fact]
        public void TestTestSumOfNumersThree()
        {
            {
                int[] numbers = { };
                int sum = Program.SumOfNumbersInArray(numbers);

                Assert.Equal(0, sum);
            }
        }

        [Fact]
        public void TestTestSumOfNumersFour()
        {
            {
                int[] numbers = { -1, -2, 3, 42 };
                int sum = Program.SumOfNumbersInArray(numbers);

                Assert.Equal(42, sum);
            }
        }
    }
}
