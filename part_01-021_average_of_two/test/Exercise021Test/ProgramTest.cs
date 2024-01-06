namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise021;
    using TestMyCode.CSharp.API.Attributes;


    public partial class ProgramTest
    {
        [Fact]
        [Points("1-21")]
        public void TestReturnDouble()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "3",
                "4"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Give the first number!\nGive the second number!\nThe average is " + 3.5 + "\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
        [Fact]
        public void TestReturnDouble2()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "4",
                "7"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Give the first number!\nGive the second number!\nThe average is " + 5.5 + "\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
