namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise001;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("3-1")]
        public void TestReturnThirdOnce()
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

                // Assert
                Assert.Equal("truest\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestReturnThirdTwice()
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
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("moneyshot\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
