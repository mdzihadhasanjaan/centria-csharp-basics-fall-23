namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise005;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-5")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestWhenFour()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "word",
                "hot potato",
                "truest",
                "false",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("false\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestWhenMany()
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

                Assert.Equal("I am last\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestWhenOne()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Only one",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Only one\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
