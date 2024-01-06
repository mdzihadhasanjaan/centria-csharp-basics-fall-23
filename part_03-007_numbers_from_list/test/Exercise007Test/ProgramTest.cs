namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise007;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-7")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestExerciseContainsStringOnce()
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
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("12\n345\n123\n1\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestExerciseContainsStringTwice()
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
                "-2",
                "3",
                "34",
                "-11",
                "11",
                "12",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("12\n11\n10\n-2\n3\n34\n-11\n11\n12\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestExerciseContainsStringNegative()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "-1",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
