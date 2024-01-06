namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise013;
    using TestMyCode.CSharp.API.Attributes;

    [Points("2-13")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestDivisionWithoutDecimals()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's method
                Program.Division(10, 5);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "2\n";

                // Assert
                Assert.Equal(comparison, sw.ToString().Replace(".", ",").Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestDivisionWithDecimals()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's method

                Program.Division(5, 2);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "2,5\n";

                // Assert
                Assert.Equal(comparison, sw.ToString().Replace(".", ",").Replace("\r\n", "\n"));
            }
        }
    }
}
