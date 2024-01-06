namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise007;
    using TestMyCode.CSharp.API.Attributes;

    public partial class ProgramTest
    {
        [Fact]
        [Points("2-7.1")]
        public void TestFirstSection()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
        "5",
        "1"
        });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                string comparisonOut = "Where to?\n";
                string comparisonIn = "";
                for (int i = 1; i <= 5; i++)
                {
                    comparisonIn += i + "\n";
                }
                Assert.Contains(comparisonOut, sw.ToString().Replace("\r\n", "\n"));
                Assert.Contains(comparisonIn, sw.ToString().Replace("\r\n", "\n"));

            }
        }

        [Fact]
        [Points("2-7.2")]
        public void TestSecondSection()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "100",
                "12"
                });
                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                string comparisonOut = "Where to?\nWhere from?\n";
                string comparisonIn = "";
                for (int i = 12; i <= 100; i++)
                {
                    comparisonIn += i + "\n";
                }
                Assert.Contains(comparisonOut, sw.ToString().Replace("\r\n", "\n"));
                Assert.Contains(comparisonIn, sw.ToString().Replace("\r\n", "\n"));

            }
        }

        [Fact]
        public void TestNegative()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "100",
                "-12"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                string comparisonOut = "Where to?\nWhere from?\n";
                string comparisonIn = "";
                for (int i = -12; i <= 100; i++)
                {
                    comparisonIn += i + "\n";
                }
                Assert.Contains(comparisonOut, sw.ToString().Replace("\r\n", "\n"));
                Assert.Contains(comparisonIn, sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestWrongOrder()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "10",
                "12"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                string comparisonOut = "Where to?\nWhere from?\n";

                Assert.Contains(comparisonOut, sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
