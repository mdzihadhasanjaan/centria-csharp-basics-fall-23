namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise027;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    [Points("3-27")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestFirstWord()
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
          "mickey and minney have a house",
          "i like it",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "mickey\ni\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void TestMultibleLinesFirstWord()
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
          "mickey and minney have a baby",
          "babies have favourite toys",
          "toys have wheels in them",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "mickey\nbabies\ntoys\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void TestTypoInFirstWord()
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
          "Do,you have a favourite flavour",
          "I have not",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Do,you\nI\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }



    }
}
