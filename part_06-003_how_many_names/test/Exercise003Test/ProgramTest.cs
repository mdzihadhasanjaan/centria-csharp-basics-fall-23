namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise003;
    using TestMyCode.CSharp.API.Attributes;
    [Points("6-3")]
    public partial class ProgramTest
    {


        [Fact]
        public void TestProgramRun()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Person ada = new Person("Ada Lovelace");
                Person jack = new Person("Jack The Ripper");
                Person mike = new Person("Mike The Incredible Magic House Mouse");

                Program.HowManyNames(ada);
                Program.HowManyNames(jack);
                Program.HowManyNames(mike);

                // Restore the original standard output.
                Console.SetOut(stdout);

                Assert.Equal("Ada Lovelace has 2 names.\nJack The Ripper has 3 names.\nMike The Incredible Magic House Mouse has 6 names.\n", sw.ToString());
            }

        }


        [Fact]
        public void TestProgramRunAgain()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                // Call student's code
                Person ada = new Person("Ada Lovelace");
                Person jack = new Person("Jack The Ripper");
                Person mike = new Person("Mike The Incredible Magic House Mouse");

                Program.HowManyNames(ada);
                Program.HowManyNames(jack);
                Program.HowManyNames(mike);
                Program.HowManyNames(mike);

                // Restore the original standard output.
                Console.SetOut(stdout);

                Assert.Equal("Ada Lovelace has 2 names.\nJack The Ripper has 3 names.\nMike The Incredible Magic House Mouse has 6 names.\nMike The Incredible Magic House Mouse has 6 names.\n", sw.ToString());
            }
        }
    }
}