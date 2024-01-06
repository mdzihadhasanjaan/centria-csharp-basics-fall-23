namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise001;
    using TestMyCode.CSharp.API.Attributes;

    public partial class ProgramTest
    {
        [Fact]
        [Points("2-1")]
        public void TestForInput()
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
                string comparison = "4\n";
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestInputZero()
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
        public void TestIfInputNegative()
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
                string comparison = "9\n";
                // Assert
                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
