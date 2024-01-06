namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise023;
    using TestMyCode.CSharp.API.Attributes;
    [Points("4-23")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestExercise118NamesFileContent()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "names.txt",
                "arto",
                "leena",
                "test",
                "matthew",
                "dotnet",
                "heikki",
                "ada",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Name of the file:\n\nEnter names, an empty line quits.\nThe name is on the list.\nThe name is on the list.\nThe name is on the list.\nThe name is not on the list.\nThe name is not on the list.\nThe name is on the list.\nThe name is on the list.\nThank you!\n", sw.ToString());
            }
        }

        [Fact]
        public void TestExercise118OtherFilesHeikki()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";

                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "other-names.txt",
                "heikki",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Name of the file:\n\nEnter names, an empty line quits.\nThe name is not on the list.\nThank you!\n", sw.ToString());
            }
        }

        [Fact]
        public void TestExercise118OtherNamesFileContent()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
          "other-names.txt",
          "leo",
          "jarmo",
          "alicia",
          "mike",
          "potato",
          "\n"
        });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Name of the file:\n\nEnter names, an empty line quits.\nThe name is on the list.\nThe name is on the list.\nThe name is on the list.\nThe name is on the list.\nThe name is on the list.\nThank you!\n", sw.ToString());
            }
        }
    }
}
