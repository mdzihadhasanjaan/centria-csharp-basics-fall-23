namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise018;
    using TestMyCode.CSharp.API.Attributes;


    public partial class ProgramTest
    {
        [Fact]
        [Points("1-18")]
        public void TestSumOfThreeIntegers()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                var data = String.Join(Environment.NewLine, new[]
                {
                "2",
                "4",
                "5"
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);
                Assert.Equal("Give the first number!\nGive the second number!\nGive the third number!\nThe sum is 11\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestSumThreeThreeThree()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "-42",
                "4",
                "371"
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("Give the first number!\nGive the second number!\nGive the third number!\nThe sum is 333\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
