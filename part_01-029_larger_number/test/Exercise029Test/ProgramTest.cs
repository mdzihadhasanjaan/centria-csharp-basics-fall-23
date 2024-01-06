namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise029;
    using TestMyCode.CSharp.API.Attributes;


    public partial class ProgramTest
    {
        [Fact]
        [Points("1-29")]
        public void TestFirstIsLarger()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "18",
                "12"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Give the first number!\nGive the second number!\nThe larger number is 18!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
        [Fact]
        public void TestSecondIsLarger()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "8",
                "12"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Give the first number!\nGive the second number!\nThe larger number is 12!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
        [Fact]
        public void TestWhenEqual()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "18",
                "18"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Give the first number!\nGive the second number!\nThey are equal!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
