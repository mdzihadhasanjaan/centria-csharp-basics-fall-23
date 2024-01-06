namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise007;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    public partial class ProgramTest
    {

        [Fact]
        [Points("4-7.1")]
        public void TestDecreasingCounterSection1()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                DecreasingCounter tester = new DecreasingCounter(3);
                tester.Decrement();
                tester.PrintValue();

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("value: 2\n", sw.ToString());
            }
        }


        [Fact]
        [Points("4-7.2")]
        public void TestDecreasingCounterSection2()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                DecreasingCounter tester = new DecreasingCounter(3);
                tester.Decrement();
                tester.Decrement();
                tester.Decrement();
                tester.Decrement();
                tester.Decrement();
                tester.PrintValue();

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("value: 0\n", sw.ToString());
            }
        }


        [Fact]
        [Points("4-7.3")]
        public void TestDecreasingCounterSection3()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                DecreasingCounter tester = new DecreasingCounter(3);
                tester.PrintValue();
                tester.Reset();
                tester.PrintValue();

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("value: 3\nvalue: 0\n", sw.ToString());
            }
        }

    }
}
