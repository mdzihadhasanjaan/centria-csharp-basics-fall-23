namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise031;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    [Points("3-31")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestMaximumNameAndAgeCSV()
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
          "sebastian,2000", "lucas,2012", "lily,2003", "hanna,2005", "gabriel,2010",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Longest name: sebastian\nHighest age: " + (Convert.ToInt32(DateTime.Now.Year) - 2000) + "\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void TestMaximumNameAndAgeChangeCSV()
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
          "sebastian,2021", "lucas,2019", "lillardsson,2011", "hanna,2005", "gabriel,2010","matt,2011",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Longest name: lillardsson\nHighest age: " + (Convert.ToInt32(DateTime.Now.Year) - 2005) + "\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void TestMaximumNameAndAgeYearCSV()
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
          "sebastian,2011", "lucas,2002", "lily,2012", "hanna,5", "gabriel,10",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Longest name: sebastian\nHighest age: " + (Convert.ToInt32(DateTime.Now.Year) - 5) + "\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }


    }
}
