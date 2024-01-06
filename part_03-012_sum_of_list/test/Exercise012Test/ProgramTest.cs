namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise012;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-12")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestSumOfFour()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "12",
                "1",
                "10",
                "1",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Sum: 24\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestSumOfMultiple()
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
                "-10",
                "3",
                "42",
                "-11",
                "-3",
                "-12",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Sum: 42\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestSumOfOne()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "2",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Sum: 2\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
