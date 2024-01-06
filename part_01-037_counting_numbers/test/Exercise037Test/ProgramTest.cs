namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise037;
    using TestMyCode.CSharp.API.Attributes;
    [Points("1-37")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestAmountOfNumbersZeroNotIncluded()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "-4","4",
                "2",
                "-2",
                "0"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Give a number:\nGive a number:\nGive a number:\nGive a number:\nGive a number:\nTotal amount of numbers: 4\n";
                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestReturnZero()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "0"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Give a number:\nTotal amount of numbers: 0\n";

                // Assert
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
