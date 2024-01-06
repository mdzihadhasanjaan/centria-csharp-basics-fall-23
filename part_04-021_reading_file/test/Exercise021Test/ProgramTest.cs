namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise021;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("4-21")]
        public void TestFileContent()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";

                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("This is test data\nThis should NOT be ALTERED\nIf you touch this file\nYOU WILL FAIL THE EXERCISE\n\nP.S.\nUnicorns are real!\n", sw.ToString());
            }
        }
    }
}
