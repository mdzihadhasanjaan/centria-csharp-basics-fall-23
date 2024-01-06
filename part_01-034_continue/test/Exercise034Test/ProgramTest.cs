namespace Exercise034
{
    using System;
    using System.IO;
    using Exercise034;
    using Xunit;
    using TestMyCode.CSharp.API.Attributes;

    [Points("1-34")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestIfFinish()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "word",
                "another",
                "hot potato",
                "kittens",
                "this is weird",
                "no"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "";
                for (int i = 0; i < 6; i++)
                {
                    comparison = comparison + "Do you want to continue?\n";
                }
                // Assert
                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestIfFinish2()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "word", "another", "mistery man",
                "another", "for king and country",
                "hot potato",
                "kittens",
                "this is weird",
                "no"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "";
                for (int i = 0; i <= 8; i++)
                {
                    comparison = comparison + "Do you want to continue?\n";
                }
                // Assert
                Assert.Contains(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}

