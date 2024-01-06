namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise018;
    using System.Collections.Generic;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-18")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestWhenFound()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "3"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                string comparison = "Search for?\n3 is at index 4.\n";
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestWhenNotFound()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "22"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                string comparison = "Search for?\n22 was not found.\n";
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
