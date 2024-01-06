namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise010;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-10")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestFindIndex()
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
                "12"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Search for?\n12 is at index 0\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestFindIndexLonger()
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
                "3",
                "12",
                "-1","3"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Search for?\n3 is at index 4\n3 is at index 8\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestMany()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "2",
                "1",
                "2",
                "2",
                "-1",
                "2"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Search for?\n2 is at index 0\n2 is at index 2\n2 is at index 3\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
