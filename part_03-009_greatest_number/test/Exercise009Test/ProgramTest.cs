namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise009;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-9")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestFindGreatestNumber()
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

                Assert.Contains("The greatest number: 345\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestNegatives()
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
                "42",
                "-111",
                "11",
                "12",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("The greatest number: 42\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestSingleValue()
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

                // Assert
                Assert.Contains("The greatest number: 2\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
