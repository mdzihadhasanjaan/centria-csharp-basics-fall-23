namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise016;
    using TestMyCode.CSharp.API.Attributes;
    using System.Text.RegularExpressions;


    [Points("1-16")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestInput()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "2"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("How many days?\n172800\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestCountSeconds()
        {
            using (StringWriter sw = new StringWriter())
            {
                int seconds = ((60 * 60) * 24);
                int days = 11 * seconds;
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "11"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("How many days?\n" + days + "\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
