namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise001;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    [Points("4-1")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestFirstAccount()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "120\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

    }
}
