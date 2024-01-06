namespace ProgramTests
{
  using System;
  using System.IO;
  using Exercise027;
  using Xunit;
  using TestMyCode.CSharp.API.Attributes;

  [Points("1-27")]
  public partial class ProgramTest
  {
    [Fact]
    public void TestPositive()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "1985",
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null!);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.Contains("Give a number:\nIt is positive\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }

    [Fact]
    public void TestZero()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "0",
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null!);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.Contains("Give a number:\nIt is not positive\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }


    [Fact]
    public void TestNegative()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "-2",
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null!);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.Contains("Give a number:\nIt is not positive\n", sw.ToString().Replace("\r\n", "\n"));
      }
    }

  }
}


