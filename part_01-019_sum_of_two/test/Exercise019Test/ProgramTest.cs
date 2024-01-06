namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise019;
    using TestMyCode.CSharp.API.Attributes;


    [Points("1-19")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestSumPrint()
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
                Assert.Equal("Give the first number!\nGive the second number!\n2 + 4 = 6\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestSumPrint2()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "-4",
                "4"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give the first number!\nGive the second number!\n-4 + 4 = 0\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
