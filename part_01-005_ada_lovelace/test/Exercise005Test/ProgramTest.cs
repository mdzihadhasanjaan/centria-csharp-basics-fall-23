namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise005;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("1-5")]
        public void TestPrintsHelloAdaLoveLace()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Contains("Hello Ada LoveLace!", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
