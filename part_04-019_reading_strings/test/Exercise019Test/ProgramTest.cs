namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise019;
    using TestMyCode.CSharp.API.Attributes;
    using System.Linq;
    using Mono.Cecil;
    using Mono.Cecil.Cil;
    [Points("4-19")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestReadingLines()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "Ada",
                "Data Scientist",
                "Is a cool person",
                "end"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("3\n", sw.ToString());
            }
        }


        [Fact]
        public void TestReadingOnlyEnd()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "end"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("0\n", sw.ToString());
            }
        }

        [Fact]
        public void TestMainContainsOnlyOneReadLine()
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
            Assert.Equal(1, counter);
        }
    }
}
