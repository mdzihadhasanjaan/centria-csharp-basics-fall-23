namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise030;
    using TestMyCode.CSharp.API.Attributes;


    [Points("1-30")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestGradeFail()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "18"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give your percent [0 - 100]:\nFail\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestGradeImpossible()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "-2"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give your percent [0 - 100]:\nImpossible\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestGradeOutstanding()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "180"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give your percent [0 - 100]:\nOutstanding!\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestGrade1()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "50"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give your percent [0 - 100]:\nGrade: 1\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestGrade2()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "60"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give your percent [0 - 100]:\nGrade: 2\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestGrade3()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "70"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give your percent [0 - 100]:\nGrade: 3\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestGrade4()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "82"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give your percent [0 - 100]:\nGrade: 4\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void Test5()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "98"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Give your percent [0 - 100]:\nGrade: 5\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
