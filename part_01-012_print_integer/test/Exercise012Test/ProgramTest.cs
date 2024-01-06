namespace ProgramTests
{
  using System;
  using System.IO;
  using Xunit;
  using Exercise012;
  using TestMyCode.CSharp.API.Attributes;


  [Points("1-12")]
  public partial class ProgramTest
  {
    [Fact]
    public void TestGivenIntegerIsPrinted()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                12
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null!);
        Console.SetOut(stdout);

        Assert.Contains("Give a number!\nYou gave 12\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }

    [Fact]
    public void TestGivenDifferentIntegerIsPrinted()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                47
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null!);
        Console.SetOut(stdout);

        Assert.Equal("Give a number!\nYou gave 47\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }


    [Fact]
    public void TestGivenYetDifferentIntegerIsPrinted()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                7779
                });

        Console.SetIn(new System.IO.StringReader(data));

        Program.Main(null!);
        Console.SetOut(stdout);

        Assert.Equal("Give a number!\nYou gave 7779\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }
  }
}
