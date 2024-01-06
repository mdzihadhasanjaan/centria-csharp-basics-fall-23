namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise011;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-11")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestExerciseContainsNumbersOnce()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "12",
                "345",
                "123",
                "1",
                "9999"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Smallest number: 1\nFound at index: 3\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestExerciseContainsNumbersTwice()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "12",
                "11",
                "10",
                "20",
                "3",
                "42",
                "999911",
                "11",
                "3",
                "12",
                "9999"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Smallest number: 3\nFound at index: 4\nFound at index: 8\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestExerciseContainsNumbersSingle()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "2",
                "3",
                "2",
                "2",
                "9999"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Smallest number: 2\nFound at index: 0\nFound at index: 2\nFound at index: 3\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}

