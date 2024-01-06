namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise006;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("3-6")]
        public void TestPrintsFirstAndLast()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "moist",
                "hot potato",
                "truest",
                "false",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("moist\nfalse\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestFirstAndLastAgain()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "word",
                "hot potato",
                "moneyshot",
                "false",
                "count all",
                "the strings",
                "from the list",
                "with the property",
                "I am last",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("word\nI am last\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestWithAShortList()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "First",
                "Second",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Contains("First\nSecond\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
