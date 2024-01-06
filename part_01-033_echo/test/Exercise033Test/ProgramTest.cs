namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise033;
    using TestMyCode.CSharp.API.Attributes;

    public partial class ProgramTest
    {
        [Fact]
        [Points("1-33")]
        public void TestWhenEqual()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Mellon",
                "Mellon"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Give the first string:\nGive the second string:\nEcho!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestWhenNotEqual()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Here we go!",
                "Where are we?"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Give the first string:\nGive the second string:\nNope!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
