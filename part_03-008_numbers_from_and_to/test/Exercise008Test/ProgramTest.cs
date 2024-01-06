namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise008;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-8")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestOnly12IsPrinted()
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
                "-1",
                "2",
                "15"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("From where?\nWhere to?\n12\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestOnly10And3ArePrinted()
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
                "-1",
                "1",
                "10"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("From where?\nWhere to?\n10\n3\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestNothingIsPrinted()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "-1",
                "0",
                "0",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("From where?\nWhere to?\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
