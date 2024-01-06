namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise013;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-13")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestSearchLastInList()
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
                "",
                "false"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Search for?\nfalse was found!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestWhenNotInList()
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
                "",
                "mr fantastic"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Search for?\nmr fantastic was not found!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestShortList()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "First",
                "Second",
                "",
                "Third"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Contains("Search for?\nThird was not found!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
