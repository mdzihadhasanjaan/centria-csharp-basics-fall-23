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
        [Points("2-21.1")]
        public void TestExerciseMethodCallPrintStars()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Program.PrintStars(12);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("************\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestExerciseMethodCallPrintSpaces()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Program.PrintSpaces(5);
                // Call student's code

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("     ", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-21.2")]
        public void TestExerciseMethodCallPrintRightTriangle()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Program.PrintRightTriangle(3);
                // Call student's code


                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("  *\n **\n***\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-21.3")]
        public void TestExerciseMethodCallChristmasTreeFive()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Program.ChristmasTree(5);
                // Call student's code


                // Restore the original standard output.
                Console.SetOut(stdout);


                // Assert
                Assert.Equal("    *\n   ***\n  *****\n *******\n*********\n   ***\n   ***\n", sw.ToString().Replace("\r\n", "\n"));
            }

        }

        [Fact]
        [Points("2-21.3")]
        public void TestExerciseMethodCallChristmasTreeSeven()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Program.ChristmasTree(7);
                // Call student's code


                // Restore the original standard output.
                Console.SetOut(stdout);


                // Assert
                Assert.Equal("      *\n     ***\n    *****\n   *******\n  *********\n ***********\n*************\n     ***\n     ***\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        [Points("2-21.3")]
        public void TestExerciseMethodCallChristmasTreeThree()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Program.ChristmasTree(3);
                // Call student's code


                // Restore the original standard output.
                Console.SetOut(stdout);


                // Assert
                Assert.Equal("  *\n ***\n*****\n ***\n ***\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}


