namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise016;
    using TestMyCode.CSharp.API.Attributes;
    using System.Linq;
    using Mono.Cecil;
    using Mono.Cecil.Cil;
    [Points("4-16")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestMainContainsThreeReadLines()
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
            Assert.Equal(3, counter);
        }

        [Fact]
        public void TestSinglePersonWorks()
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
                "Heikki",
                "Ahonen",
                "110101",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "First name:\nLast name:\nIdentification number:\nFirst name:\n\nHeikki Ahonen\n";
                Assert.Equal(comparison1, sw.ToString());
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
                "Pence",
                "11111111",
                "Hank",
                "Toms",
                "12121912",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "First name:\nLast name:\nIdentification number:\nFirst name:\nLast name:\nIdentification number:\nFirst name:\n\nMike Pence\nHank Toms\n";
                Assert.Equal(comparison1, sw.ToString());
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
                "Pence",
                "11111111",
                "Hank",
                "Toms",
                "12121912",
                "Hillary",
                "Claimer",
                "13131970",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "First name:\nLast name:\nIdentification number:\nFirst name:\nLast name:\nIdentification number:\nFirst name:\nLast name:\nIdentification number:\nFirst name:\n\nMike Pence\nHank Toms\nHillary Claimer\n";
                Assert.Equal(comparison1, sw.ToString());
            }
        }
    }
}
