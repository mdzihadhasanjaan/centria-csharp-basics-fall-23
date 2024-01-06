namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise004;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("1-4")]
        public void TestReturnsTrue()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Contains("Passport and a toothbrush!", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
