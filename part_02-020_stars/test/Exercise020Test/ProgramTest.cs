namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise020;
    using TestMyCode.CSharp.API.Attributes;

    [Points("2-20.1")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestExerciseMethodCallPrintStars()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Program.PrintStars(3);
                // Call student's code


                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("***\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-20.2")]
        public void TestExerciseMethodCallPrintSquare()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Program.PrintSquare(5);
                // Call student's code


                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("*****\n*****\n*****\n*****\n*****\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-20.3")]
        public void TestExerciseMethodCallPrintRectangle()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Program.PrintRectangle(8, 4);
                // Call student's code


                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("********\n********\n********\n********\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-20.4")]
        public void TestExerciseMethodCallPrintTriangle()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Program.PrintTriangle(5);
                // Call student's code


                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("*\n**\n***\n****\n*****\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
