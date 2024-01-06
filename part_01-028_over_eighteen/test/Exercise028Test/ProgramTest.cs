namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise028;
    using TestMyCode.CSharp.API.Attributes;

    [Points("1-28")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestAdult()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "18",
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("How old are you?\nYou\'re an adult!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestUnderAge()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "17",
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("How old are you?\nYou\'re under age!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
