namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise024;
    using TestMyCode.CSharp.API.Attributes;


    [Points("1-24")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestNotSpeeding()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "3",
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Your speed:\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestYesSpeeding()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "123",
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Your speed:\nSpeeding!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
