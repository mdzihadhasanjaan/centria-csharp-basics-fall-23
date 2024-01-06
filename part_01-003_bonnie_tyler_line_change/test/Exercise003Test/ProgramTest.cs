namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise003;
    using TestMyCode.CSharp.API.Attributes;
    [Points("1-3")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestSingleWriteLineBonnie()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                Program.Main(null!);

                Console.SetOut(stdout);

                Assert.Contains("Once upon a time\nI was falling in love\nNow I'm only falling apart\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void CountSingleWriteLine()
        {
            int counter = 0;
            Mono.Cecil.AssemblyDefinition assembly = Mono.Cecil.AssemblyDefinition.ReadAssembly(typeof(Program).Module.FullyQualifiedName);
            Mono.Cecil.TypeDefinition type = assembly.MainModule.GetType(typeof(Program).FullName);

            Mono.Cecil.MethodDefinition method = null;
            foreach (Mono.Cecil.MethodDefinition iter in type.Methods)
            {
                if (iter.Name == "Main")
                {
                    method = iter;
                }
            }

            foreach (Mono.Cecil.Cil.Instruction instruction in method.Body.Instructions)
            {
                if (instruction.OpCode != Mono.Cecil.Cil.OpCodes.Call)
                {
                    continue;
                }

                if (instruction.Operand is not Mono.Cecil.MethodReference methodReference)
                {
                    continue;
                }

                if (methodReference.FullName == "System.Void System.Console::WriteLine(System.String)")
                {
                    counter++;
                }
            }
            Assert.Equal(1, counter);
        }
    }
}
