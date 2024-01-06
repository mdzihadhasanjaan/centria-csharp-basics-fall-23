namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise018;
    using TestMyCode.CSharp.API.Attributes;
    using System.Linq;
    using Mono.Cecil;
    using Mono.Cecil.Cil;
    public partial class ProgramTest
    {
        [Fact]
        [Points("4-18.1")]
        public void TestBookCreation()
        {
            Book book = new Book("To kill a mocking test", 147, 2021);
            // Assert
            Assert.Equal(typeof(Book), book.GetType());
        }

        [Fact]
        [Points("4-18.2")]
        public void TestMainContainsFourReadLines()
        {
            int counter = 0;
            AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(typeof(Program).Module.FullyQualifiedName);
            TypeDefinition type = assembly.MainModule.GetType(typeof(Program).FullName);

            MethodDefinition method = type.Methods.FirstOrDefault(m => m.Name == "Main");

            foreach (Instruction instruction in method.Body.Instructions)
            {
                if (instruction.OpCode != OpCodes.Call)
                {
                    continue;
                }

                if (instruction.Operand is not MethodReference methodReference)
                {
                    continue;
                }

                if (methodReference.FullName == "System.String System.Console::ReadLine()")
                {
                    counter++;
                }
            }
            Assert.Equal(4, counter);
        }


        [Fact]
        [Points("4-18.2")]
        public void TestPrintEverything()
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
                "My book",
                "30",
                "1945",
                "Your book",
                "60",
                "1999",
                "",
                "everything"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "Name: Pages: Publication year: Name: Pages: Publication year: Name: \nWhat information will be printed? My book, 30 pages, 1945\nYour book, 60 pages, 1999\n";
                Assert.Equal(comparison1, sw.ToString());
            }
        }

        [Fact]
        [Points("4-18.2")]
        public void TestPrintTitle()
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
                "My book",
                "30",
                "1945",
                "Your book",
                "60",
                "1999",
                "",
                "title"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "Name: Pages: Publication year: Name: Pages: Publication year: Name: \nWhat information will be printed? My book\nYour book\n";
                Assert.Equal(comparison1, sw.ToString());
            }
        }

        [Fact]
        [Points("4-18.2")]
        public void TestPrintWrongInput()
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
                "My book",
                "30",
                "1945",
                "Your book",
                "60",
                "1999",
                "",
                "names"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "Name: Pages: Publication year: Name: Pages: Publication year: Name: \nWhat information will be printed? ";
                Assert.Equal(comparison1, sw.ToString());
            }
        }
    }
}