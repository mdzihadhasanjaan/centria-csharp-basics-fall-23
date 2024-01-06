namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise039;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("1-39")]
        public void TestSumsNumbers()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "-2","4",
                "2",
                "-2",
                "0"
        });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);

                Console.SetOut(stdout);

                string comparison = "Give a number:\nGive a number:\nGive a number:\nGive a number:\nGive a number:\nTotal sum of numbers: 2\n";

                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestStopAtZero()
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
                Program.Main(null!);

                Console.SetOut(stdout);

                string comparison = "Give a number:\nTotal sum of numbers: 0\n";

                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
