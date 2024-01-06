namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise008;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("2-8.1")]
        public void TestReadingNumbers()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "9",
                "7",
                "2",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Give numbers:\nThx! Bye!\n";
                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-8.2")]
        public void TestSumOfNumbers()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "9",
                "7",
                "2",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Give numbers:\nThx! Bye!\nSum: 18\n";
                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-8.3")]
        public void TestNumberOfNumbers()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "9",
                "7",
                "2",
                "3",
                "1",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Give numbers:\nThx! Bye!\nSum: 22\nNumbers: 5\n";
                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-8.4")]
        public void TestAverage()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "9",
                "7",
                "2",
                "3",
                "1",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Give numbers:\nThx! Bye!\nSum: 22\nNumbers: 5\nAverage: " + Convert.ToDouble("4.4", System.Globalization.CultureInfo.InvariantCulture).ToString() + "\n";
                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-8.5")]
        public void TestEvenAndOdd()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "9",
                "7",
                "2",
                "3",
                "-1"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Give numbers:\nThx! Bye!\nSum: 21\nNumbers: 4\nAverage: " + Convert.ToDouble("5.25", System.Globalization.CultureInfo.InvariantCulture).ToString() + "\nEven: 1\nOdd: 3\n";
                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
