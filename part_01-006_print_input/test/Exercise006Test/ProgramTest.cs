namespace ProgramTests
{
  using System;
  using System.IO;
  using Xunit;
  using Exercise006;
  using TestMyCode.CSharp.API.Attributes;


  public partial class ProgramTest
  {
    [Fact]
    [Points("1-6")]
    public void TestPrintsInput()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        var input = new StringReader("Are you printing the string?");
        Console.SetIn(input);
        Program.Main(null!);
        Console.SetOut(stdout);

        Assert.Contains("Give input!\nAre you printing the string?\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }

    [Fact]
    [Points("1-6")]
    public void TestPrintsDifferentInput()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        var input = new StringReader("Are you printing this string?");
        Console.SetIn(input);
        Program.Main(null!);
        Console.SetOut(stdout);

        Assert.Equal("Give input!\nAre you printing this string?\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }

    [Fact]
    [Points("1-6")]
    public void TestPrintsDifferentMessage()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        var input = new StringReader("Well done!");
        Console.SetIn(input);
        Program.Main(null!);
        Console.SetOut(stdout);

        Assert.Equal("Give input!\nWell done!\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }
  }
}
