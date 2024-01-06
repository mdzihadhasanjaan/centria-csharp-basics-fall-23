
namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise011;
    using TestMyCode.CSharp.API.Attributes;

    [Points("2-11")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestPrintsFourNumbers()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "4"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.PrintUntilNumber(Convert.ToInt32(data));
                Console.SetOut(stdout);
                Assert.Equal("1\n2\n3\n4\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
        [Fact]
        public void TestWhenZero()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "0"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.PrintUntilNumber(Convert.ToInt32(data));
                Console.SetOut(stdout);
                Assert.Equal("", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
