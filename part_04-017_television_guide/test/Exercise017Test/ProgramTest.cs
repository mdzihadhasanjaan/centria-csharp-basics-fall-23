namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise017;
    using TestMyCode.CSharp.API.Attributes;
    using System.Linq;
    using Mono.Cecil;
    using Mono.Cecil.Cil;
    [Points("4-17")]
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
                "Hoolahoop",
                "30",
                "Potato show",
                "45",
                "Masterchef",
                "60",
                "",
                "45"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "Name: Duration: Name: Duration: Name: Duration: Name: \nProgram's maximum duration? Hoolahoop, 30 minutes\nPotato show, 45 minutes\n";
                Assert.Equal(comparison1, sw.ToString());
            }
        }

        [Fact]
        public void TestAddingToListWorksSingleTooShort()
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
                "Hoolahoop",
                "60",
                "",
                "45"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "Name: Duration: Name: \nProgram's maximum duration? ";
                Assert.Equal(comparison1, sw.ToString());
            }
        }

        [Fact]
        public void TestAddingToListWorksSingleExactlyAsLong()
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
                "Hoolahoopsan",
                "60",
                "",
                "60"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);
                string comparison1 = "Name: Duration: Name: \nProgram's maximum duration? Hoolahoopsan, 60 minutes\n";
                Assert.Equal(comparison1, sw.ToString());
            }
        }
    }
}
