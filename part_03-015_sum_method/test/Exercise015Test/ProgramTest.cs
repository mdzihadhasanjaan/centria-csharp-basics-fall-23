namespace ProgramTests
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Xunit;
    using Exercise015;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-15")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestSumMethod()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                List<int> numbers = new List<int>();
                numbers.Add(1);
                numbers.Add(5);
                numbers.Add(12);
                numbers.Add(42);
                numbers.Add(0);
                numbers.Add(6);

                int sum = Program.Sum(numbers);
                Console.SetOut(stdout);

                Assert.Equal(66, sum);
            }
        }

        [Fact]
        public void TestResultIsZero()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                List<int> numbers = new List<int>();
                numbers.Add(1);
                numbers.Add(-1);

                int sum = Program.Sum(numbers);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal(0, sum);
            }
        }

        [Fact]
        public void TestNegative()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                List<int> numbers = new List<int>();
                numbers.Add(1);
                numbers.Add(-1);
                numbers.Add(-2);
                numbers.Add(-3);


                int sum = Program.Sum(numbers);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal(-5, sum);
            }
        }
    }
}

