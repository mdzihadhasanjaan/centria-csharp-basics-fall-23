namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise009;
    using TestMyCode.CSharp.API.Attributes;
    [Points("2-9")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestPrintPhraseMethod()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;
                // Redirect standard output to variable.
                Console.SetOut(sw);
                // Call student's code
                Program.PrintPhrase();
                // Restore the original standard output.
                Console.SetOut(stdout);
                // Assert
                Assert.Equal("In a hole in the ground there lived a method\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}