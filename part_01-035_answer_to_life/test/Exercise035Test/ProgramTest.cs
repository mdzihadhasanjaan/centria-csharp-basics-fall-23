namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise035;
    using TestMyCode.CSharp.API.Attributes;

    public partial class ProgramTest
    {
        [Fact]
        [Points("1-35")]
        public void TestFiveLoops()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "41",
                "45",
                "11",
                "69",
                "42"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "";
                for (int i = 0; i < 5; i++)
                {
                    comparison = comparison + "Give a number:\n";
                }
                // Assert
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestOneLoop()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "42"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Give a number:\n";

                // Assert
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
