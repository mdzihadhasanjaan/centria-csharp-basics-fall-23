namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise020;
    using TestMyCode.CSharp.API.Attributes;


    [Points("1-20")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestMultiplicationResult()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "2",
                "4"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give the first number!\nGive the second number!\n2 * 4 = 8\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestMultiplicationResult2()
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
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give the first number!\nGive the second number!\n4 * -1 = -4\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
