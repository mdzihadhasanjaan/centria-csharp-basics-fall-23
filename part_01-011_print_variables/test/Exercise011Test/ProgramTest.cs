namespace ProgramTests
{
    using System;
    using System.IO;
    using Exercise011;
    using Xunit;
    using TestMyCode.CSharp.API.Attributes;


    [Points("1-11")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestPrintVariables()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Days to summer:\n200\nHours to lunch:\n" + 3.5 + "\nCoding is fun:\nIt sure is!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

    }
}

