namespace ProgramTests
{
  using System;
  using System.IO;
  using Xunit;
  using Exercise017;
  using TestMyCode.CSharp.API.Attributes;

  [Points("2-17")]
  public partial class ProgramTest
  {
    [Fact]
    public void TestSumOfNumbersMain()
    {

      int test = Program.Sum(4, 3, 6, 1);
      Assert.Equal(14, test);
    }

    [Fact]
    public void TestSumOfNumbersMethodNewNumbers()
    {
      int test = Program.Sum(3, 5, 7, 2);
      Assert.Equal(17, test);
    }


    [Fact]
    public void TestSumOfNumbersMethodWithDifferentNumbers()
    {
      int test = Program.Sum(5, 15, 14, 12);
      Assert.Equal(46, test);
    }

    [Fact]
    public void TestSumOfNumbersMethodWithFirstFour()
    {
      int test = Program.Sum(1, 2, 3, 4);
      Assert.Equal(10, test);

    }
  }
}