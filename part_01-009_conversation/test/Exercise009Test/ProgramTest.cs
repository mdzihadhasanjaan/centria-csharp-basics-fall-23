namespace ProgramTests
{

    using System;
    using System.IO;
    using Xunit;
    using Exercise009;
    using TestMyCode.CSharp.API.Attributes;


    [Points("1-9")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestConversationPrint()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                var input = new StringReader(@"Fine, thanks
Not now");
                Console.SetIn(input);
                Program.Main(null!);
                string expectedOutput = @"Hello, how are you?
That's interesting, tell me more
Thank you for sharing!
";
                Console.SetOut(stdout);
                Assert.Equal(expectedOutput, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        /* [Fact]
        public void TestCountReadLines()
        {
            string code = File.ReadAllText("../../../../../src/Exercise009/Program.cs");
            int count = Regex.Matches(code, "Console.ReadLine").Count;

            Assert.Equal(2, count);
        } */
    }
}
