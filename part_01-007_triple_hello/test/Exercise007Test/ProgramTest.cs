namespace ProgramTests
{
  using System;
  using System.IO;
  using Xunit;
  using Exercise007;
  using TestMyCode.CSharp.API.Attributes;
  public partial class ProgramTest
  {
    [Fact]
    [Points("1-7")]
    public void TestThreePrints()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var input = new StringReader("Are you printing the string?");
        Console.SetIn(input);

        Program.Main(null!);

        Console.SetOut(stdout);

        Assert.Contains("Give input!\nAre you printing the string?\nAre you printing the string?\nAre you printing the string?\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }

    [Fact]
    [Points("1-7")]
    public void TestThreePrintsAgain()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var input = new StringReader("Print me three times?");
        Console.SetIn(input);

        Program.Main(null!);

        Console.SetOut(stdout);

        Assert.Equal("Give input!\nPrint me three times?\nPrint me three times?\nPrint me three times?\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }

    [Fact]
    [Points("1-7")]
    public void TestThreePrintsWithSimplePrint()
    {
      using (StringWriter sw = new StringWriter())
      {
        sw.NewLine = "\n";
        TextWriter stdout = Console.Out;

        Console.SetOut(sw);

        var input = new StringReader("Print");
        Console.SetIn(input);

        Program.Main(null!);

        Console.SetOut(stdout);

        Assert.Equal("Give input!\nPrint\nPrint\nPrint\n", sw.ToString());
      }
    }
  }
}
