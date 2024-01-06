namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise023;
    using TestMyCode.CSharp.API.Attributes;


    public partial class ProgramTest
    {
        [Fact]
        [Points("1-23")]
        public void TestPrintsCalculations()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "3",
                "4"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Give the first number!\nGive the second number!\n3 + 4 = 7\n3 - 4 = -1\n3 * 4 = 12\n3 / 4 = " + ((double)3 / 4) + "\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
