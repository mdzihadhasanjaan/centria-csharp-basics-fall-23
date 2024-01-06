namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise004;
    using TestMyCode.CSharp.API.Attributes;

    public partial class ProgramTest
    {
        [Fact]
        [Points("2-4")]
        public void TestLessThan()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
               {
                "2",
                "7"
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                string comparison = "2 is less than 7.\n";
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
        [Fact]
        public void TestGreaterThan()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "2",
                "1"
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                string comparison = "2 is greater than 1.\n";
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestEqualTo()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "3",
                "3"
                });

                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                string comparison = "3 is equal to 3.\n";
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
