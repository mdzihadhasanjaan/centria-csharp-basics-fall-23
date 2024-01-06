namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise010;
    using TestMyCode.CSharp.API.Attributes;
    [Points("2-10")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestPrint2Times()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "2"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("How many times?\nIn a hole in the ground there lived a method\nIn a hole in the ground there lived a method\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestPrint3Times()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "3"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                for (int i = 0; i < Convert.ToInt32(data); i++)
                {
                    Program.PrintPhrase();
                }

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "In a hole in the ground there lived a method\nIn a hole in the ground there lived a method\nIn a hole in the ground there lived a method\n";

                // Assert
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestNoPrint()
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
                for (int i = 0; i < Convert.ToInt32(data); i++)
                {
                    Program.PrintPhrase();
                }

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "";

                // Assert
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
