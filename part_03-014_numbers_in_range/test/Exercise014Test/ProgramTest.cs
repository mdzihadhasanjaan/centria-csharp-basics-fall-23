namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise014;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    [Points("3-14")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestPrintInRange()
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

                Program.PrintNumbersInRange(numbers, 0, 5);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("1\n5\n0\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestPrintInRangeLonger()
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
                numbers.Add(5);
                numbers.Add(4);
                numbers.Add(6);

                Program.PrintNumbersInRange(numbers, 0, 5);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("1\n5\n0\n5\n4\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestPrintEmpty()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                List<int> numbers = new List<int>();
                numbers.Add(2);
                numbers.Add(5);
                numbers.Add(12);
                numbers.Add(42);
                numbers.Add(0);
                numbers.Add(5);
                numbers.Add(4);
                numbers.Add(6);

                Program.PrintNumbersInRange(numbers, 0, 1);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
