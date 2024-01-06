namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise013;
    using TestMyCode.CSharp.API.Attributes;


    [Points("1-13")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestDoublePrint()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                Convert.ToDouble("12.4", System.Globalization.CultureInfo.InvariantCulture).ToString()
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Give a number!\nYou gave " + (12.4).ToString().Replace(",", ".") + "\n", sw.ToString().Replace("\r\n", "\n").Replace(",", "."));
            }
        }

        [Fact]
        public void TestDoublePrintSecond()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                Convert.ToDouble("3.4", System.Globalization.CultureInfo.InvariantCulture).ToString()
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Give a number!\nYou gave " + (3.4).ToString().Replace(",", ".") + "\n", sw.ToString().Replace("\r\n", "\n").Replace(",", "."));
            }
        }

        [Fact]
        public void TestDoublePrintAnother()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                Convert.ToDouble("4.19", System.Globalization.CultureInfo.InvariantCulture).ToString()
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Give a number!\nYou gave " + (4.19).ToString().Replace(",", ".") + "\n", sw.ToString().Replace("\r\n", "\n").Replace(",", "."));
            }
        }
    }
}
