namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise029;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    [Points("3-29")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestOldestPersonCSV()
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
                string comparison = "Age of the oldest: 10\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void TestOneYearOlderCSV()
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
                string comparison = "Age of the oldest: 11\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void TestTwoOldestCSV()
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
                string comparison = "Age of the oldest: 10\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void TestOldestNotLastGiven()
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
          "sebastian,2", "lucas,2", "lily,12", "hanna,5", "gabriel,10",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Age of the oldest: 12\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }
    }
}
