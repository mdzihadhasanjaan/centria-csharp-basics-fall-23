namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise024;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;

    [Points("3-24")]
    public partial class ProgramTest
    {
        [Fact]
        public void AlexSuccessfullLogin()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "alex",
                "sunshine"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Enter username:\nEnter password:\nYou have successfully logged in!\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void EmmaSuccessfullLogin()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "emma",
                "haskell"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Enter username:\nEnter password:\nYou have successfully logged in!\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void AlexWrongPasswordCheck()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "alex",
                "haskell"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Enter username:\nEnter password:\nIncorrect username or password!\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void EmmaWrongPasswordCheck()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "emma",
                "sunshine"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Enter username:\nEnter password:\nIncorrect username or password!\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }

        [Fact]
        public void BobWrongPasswordCheck()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "bob",
                "haskell"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison = "Enter username:\nEnter password:\nIncorrect username or password!\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }


    }
}
