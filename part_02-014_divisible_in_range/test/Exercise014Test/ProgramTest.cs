namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise014;
    using TestMyCode.CSharp.API.Attributes;

    [Points("2-14")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestWhenInRange()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                Program.DivisibleByThreeInRange(1, 15);
                Console.SetOut(stdout);

                Assert.Equal("3\n6\n9\n12\n15\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestWhenNotInRange()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                Program.DivisibleByThreeInRange(1, 2);
                Console.SetOut(stdout);

                Assert.Equal("", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
