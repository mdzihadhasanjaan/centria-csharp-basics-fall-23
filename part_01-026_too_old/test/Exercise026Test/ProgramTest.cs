namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise026;
    using TestMyCode.CSharp.API.Attributes;

    public partial class ProgramTest
    {
        [Fact]
        [Points("1-26")]
        public void TestYear()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "1985",
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Give your year of birth:\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestIfOld()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "1800",
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Give your year of birth:\nYou\'re old\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

    }
}
