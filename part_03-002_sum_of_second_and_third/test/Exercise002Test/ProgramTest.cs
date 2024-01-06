namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise002;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-2")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestReturnsSumAfterThree()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                12,
                13,
                12,
                0
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("25\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestReturnsSumAfterFour()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                23,
                21,
                21,
                69,
                0
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("42\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
