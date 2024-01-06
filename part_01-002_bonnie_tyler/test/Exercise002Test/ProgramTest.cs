namespace ProgramTests
{
  using System;
  using System.IO;
  using Xunit;
  using Exercise002;
  using TestMyCode.CSharp.API.Attributes;
  using System.Linq;
  using Mono.Cecil;
  using Mono.Cecil.Cil;
  [Points("1-2")]
  public partial class ProgramTest
  {
    [Fact]
    public void TestThreeWriteLineBonnies()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.Main(null!);
        Console.SetOut(stdout);

        Assert.Contains("Once upon a time\nI was falling in love\nNow I'm only falling apart", sw.ToString().Replace("\r\n", "\n"));
      }
    }


    [Fact]
    public void CountThreeWriteLines()
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

        if (methodReference.FullName == "System.Void System.Console::WriteLine(System.String)")
        {
          counter++;
        }
      }
      Assert.Equal(3, counter);
    }
  }
}
