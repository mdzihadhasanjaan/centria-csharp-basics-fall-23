namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise020;
    using TestMyCode.CSharp.API.Attributes;
    using System.Linq;
    using Mono.Cecil;
    using Mono.Cecil.Cil;
    [Points("4-20")]
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
                "12",
                "11",
                "-1",
                "-3",
                "end"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("1728\n1331\n-1\n-27\n", sw.ToString());
            }
        }


        [Fact]
        public void TestDifferentNumbers()
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
                "111",
                "42",
                "-17",
                "4",
                "end"
                });

                Console.SetIn(new System.IO.StringReader(data));

                // Call student's code
                Program.Main(null!);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("1367631\n74088\n-4913\n64\n", sw.ToString());
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
                Assert.Equal("", sw.ToString());
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
