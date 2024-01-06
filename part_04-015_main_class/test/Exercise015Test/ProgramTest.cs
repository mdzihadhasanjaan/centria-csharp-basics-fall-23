namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise015;
    using TestMyCode.CSharp.API.Attributes;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    [Points("4-15")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestToString()
        {
            {
                Item item = new Item("testName");

                // Assert
                Assert.Equal(item.name + " (created at: " + item.createdAt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fi-FI")) + ")", item.ToString());

            }
        }
        [Fact]
        public void TestAddingToListWorks()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Mike",
                "Matt",
                "Hank",
                "Lily",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "Name: Name: Name: Name: Name:";
                Assert.Contains(comparison1, sw.ToString());

                string comparison2 = "Mike (created at: ";
                Assert.Contains(comparison2, sw.ToString());

                string comparison3 = "Hank (created at: ";
                Assert.Contains(comparison3, sw.ToString());

                string comparison4 = "Lily (created at: ";
                Assert.Contains(comparison4, sw.ToString());

            }
        }

        [Fact]
        public void TestAddingToListWorksMore()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Mike",
                "Matt",
                "Hank",
                "Lily",
                "Lilly",
                "Eliza",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "Name: Name: Name: Name: Name: Name: Name: \n";
                Assert.Contains(comparison1, sw.ToString());
                string comparison2 = "Mike (created at: ";
                Assert.Contains(comparison2, sw.ToString());
                string comparison3 = "Hank (created at: ";
                Assert.Contains(comparison3, sw.ToString());
                string comparison4 = "Lily (created at: ";
                Assert.Contains(comparison4, sw.ToString());
                string comparison5 = "Lilly (created at: ";
                Assert.Contains(comparison5, sw.ToString());
                string comparison6 = "Eliza (created at: ";
                Assert.Contains(comparison6, sw.ToString());
            }
        }
    }
}

