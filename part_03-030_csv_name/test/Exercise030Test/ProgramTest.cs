namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise030;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    [Points("3-30")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestOldestPersonNameCSV()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
          "sebastian,2", "lucas,2", "lily,1", "hanna,5", "gabriel,10",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Name of the oldest: gabriel\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void TestOneYearOlderNameCSV()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
          "sebastian,2", "lucas,2", "lily,1", "hanna,5", "gabriel,10","matt,11",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Name of the oldest: matt\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void TestTwoOldestNameCSV()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
          "sebastian,2", "lucas,2", "lily,10", "hanna,5", "gabriel,10",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Name of the oldest: lily\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }
    }
}
