namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise032;
    using TestMyCode.CSharp.API.Attributes;

    [Points("1-32")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestMellonIsWelcome()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Mellon"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Speak, friend, and enter!\nWelcome, friend\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
        [Fact]
        public void TestCaveTrollNotWelcome()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Here we go!"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Speak, friend, and enter!\nThey\'ve got a cave troll!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
