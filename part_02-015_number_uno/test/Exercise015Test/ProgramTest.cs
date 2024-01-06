namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise015;
    using TestMyCode.CSharp.API.Attributes;


    [Points("2-15")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestReturnsUno()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                int uno = Program.NumberUno();
                Console.SetOut(stdout);

                Assert.Equal(1, uno);
            }
        }

        [Fact]
        public void TestReturnsInteger()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                int uno = Program.NumberUno();
                Console.SetOut(stdout);

                Assert.Equal(typeof(Int32), uno.GetType());
            }
        }
    }
}
