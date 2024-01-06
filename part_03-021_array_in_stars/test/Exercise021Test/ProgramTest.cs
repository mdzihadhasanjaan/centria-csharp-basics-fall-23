namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise021;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;

    [Points("3-21")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestExampleArray()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                int[] array = { 5, 1, 3, 4, 2 };
                Program.PrintArrayInStars(array);


                // Restore the original standard output.
                Console.SetOut(stdout);


                Assert.Equal("*****\n*\n***\n****\n**\n", sw.ToString());
            }
        }

        [Fact]
        public void TestDifferentArray()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                int[] array = { 5, 2, 3, 4, 2 };
                Program.PrintArrayInStars(array);


                // Restore the original standard output.
                Console.SetOut(stdout);


                Assert.Equal("*****\n**\n***\n****\n**\n", sw.ToString());
            }
        }

        [Fact]
        public void TestLargerArray()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                int[] array = { 5, 2, 3, 4, 2, 3, 4 };
                Program.PrintArrayInStars(array);


                // Restore the original standard output.
                Console.SetOut(stdout);


                Assert.Equal("*****\n**\n***\n****\n**\n***\n****\n", sw.ToString());
            }
        }

        [Fact]
        public void TestSingleElementArray()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                int[] array = { 5 };
                Program.PrintArrayInStars(array);


                // Restore the original standard output.
                Console.SetOut(stdout);


                Assert.Equal("*****\n", sw.ToString());
            }
        }

    }
}
