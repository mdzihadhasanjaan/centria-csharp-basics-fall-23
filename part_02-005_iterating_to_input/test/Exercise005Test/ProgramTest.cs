namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise005;
    using TestMyCode.CSharp.API.Attributes;

    public partial class ProgramTest
    {
        [Fact]
        [Points("2-5")]
        public void TestReadsInteger()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "7"
                });

                Console.SetIn(new System.IO.StringReader(data));
                // Call student's code
                Program.Main(null!);
                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "0\n1\n2\n3\n4\n5\n6\n7\n";
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
