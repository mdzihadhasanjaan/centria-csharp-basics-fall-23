namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise002;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    [Points("4-2")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestFirstTansfer()
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
                string comparison = "Heikki's account balance: 900\n" +
                "Personal account balance: 100\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

    }
}

