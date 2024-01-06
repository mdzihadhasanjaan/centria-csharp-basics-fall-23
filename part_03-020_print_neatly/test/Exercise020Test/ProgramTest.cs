namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise020;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-20")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestMethod()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                int[] array = { 5, 1, 3, 4, 2 };
                Program.PrintNeatly(array);

                Console.SetOut(stdout);

                Assert.Contains("5, 1, 3, 4, 2", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestSingleItem()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                int[] array = { 5 };
                Program.PrintNeatly(array);

                Console.SetOut(stdout);
                Assert.Equal("5\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
