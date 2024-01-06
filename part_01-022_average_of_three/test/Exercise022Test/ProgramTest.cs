namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise022;
    using TestMyCode.CSharp.API.Attributes;
    using System.Text.RegularExpressions;

    public partial class ProgramTest
    {
        [Fact]
        [Points("1-22")]
        public void TestCountingAverage()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "3",
                "4",
                "2"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give the first number!\nGive the second number!\nGive the third number!\nThe average is " + 3.0 + "\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestCountingAverage2()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "4",
                "7",
                "5"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Give the first number!\nGive the second number!\nGive the third number!\nThe average is " + 5.3333, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
