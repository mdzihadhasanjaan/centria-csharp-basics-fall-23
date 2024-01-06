namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise006;
    using TestMyCode.CSharp.API.Attributes;

    public partial class ProgramTest
    {
        [Fact]
        [Points("2-6")]
        public void TestPrintsToHundred()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "7"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                string comparison = "";
                for (int i = 7; i <= 100; i++)
                {
                    comparison += i + "\n";
                }
                Assert.Equal(comparison, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
