namespace ProgramTests
{
  using System;
  using System.IO;
  using Xunit;
  using Exercise001;
  using TestMyCode.CSharp.API.Attributes;
  
  [Points("1-1")]
  public partial class ProgramTest
  {
    [Fact]
    public void TestHelloWorldWriteLine()
    {
      using (StringWriter sw = new StringWriter())
      {
        sw.NewLine = "\n";
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.Main(null!);
        Console.SetOut(stdout);

        Assert.Contains("Hello World", sw.ToString());
      }
    }

    [Fact]
    public void TestHelloWorldWriteLineWithExclamation()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Program.Main(null!);
        Console.SetOut(stdout);

        Assert.Contains("Hello World!", sw.ToString().Replace("\r\n", "\n"));
      }
    }
  }
}
