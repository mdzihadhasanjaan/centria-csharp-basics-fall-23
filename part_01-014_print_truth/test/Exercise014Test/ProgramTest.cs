namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise014;
    using TestMyCode.CSharp.API.Attributes;


    public partial class ProgramTest
    {
        [Fact]
        [Points("1-14")]
        public void TestPrintsTruth()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);


                var data = String.Join(Environment.NewLine, new[]
                {
                "tRuE"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give me the truth!\nTrue\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
