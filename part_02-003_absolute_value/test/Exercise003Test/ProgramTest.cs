namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise003;
    using TestMyCode.CSharp.API.Attributes;

    [Points("2-3")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestPositiveReturnsItself()
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
                string comparison = "2\n";
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestZeroReturnsItself()
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
                string comparison = "0\n";

                // Assert
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestNegativeReturnsAbsoluteValue()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "-3"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "3\n";

                // Assert
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
