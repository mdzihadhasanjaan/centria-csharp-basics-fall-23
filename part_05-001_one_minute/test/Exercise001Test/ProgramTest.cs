namespace ProgramTests
{
  using System;
  using System.IO;
  using Xunit;
  using Exercise001;
  using TestMyCode.CSharp.API.Attributes;
  [Points("5-01")]
  public partial class ProgramTest
  {

    [Fact]
    public void TestTimerConstructor()
    {
      Timer testTimer = new Timer();

      Assert.Equal("00:00", testTimer.ToString());
    }

    [Fact]
    public void TestTimerAdvance()
    {
      Timer testTimer = new Timer();
      testTimer.Advance();

      Assert.Equal("00:01", testTimer.ToString());
    }

    [Fact]
    public void TestTimerAdvanceOneHundred()
    {
      Timer testTimer = new Timer();
      for (int i = 0; i < 100; i++)
      {
        testTimer.Advance();
      }
      Assert.Equal("01:00", testTimer.ToString());
    }

    [Fact]
    public void TestTimerAdvanceOneMinute()
    {
      Timer testTimer = new Timer();
      for (int i = 0; i < 6000; i++)
      {
        testTimer.Advance();
      }
      Assert.Equal("00:00", testTimer.ToString());
    }

    [Fact]
    public void TestTimerAdvance5999()
    {
      Timer testTimer = new Timer();
      for (int i = 0; i < 5999; i++)
      {
        testTimer.Advance();
      }
      Assert.Equal("59:99", testTimer.ToString());
    }
  }
}
