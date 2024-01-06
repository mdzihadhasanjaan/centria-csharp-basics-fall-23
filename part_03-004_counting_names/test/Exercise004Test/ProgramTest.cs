namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise004;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-4")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestListTotalIs0()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("In total: 0\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestListTotalIs3()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Harold",
                "Mary,",
                "Bob",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                Assert.Equal("In total: 3\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
