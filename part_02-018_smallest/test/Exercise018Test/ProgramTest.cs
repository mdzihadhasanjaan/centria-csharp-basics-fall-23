namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise018;
    using TestMyCode.CSharp.API.Attributes;

    [Points("2-18")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestWhenFirstIsSmallest()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                int number = Program.Smallest(3, 8);
                Console.SetOut(stdout);

                Assert.Equal(3, number);
            }
        }

        [Fact]
        public void TestWhenSecondIsSmallest()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                int number = Program.Smallest(38, 8);
                Console.SetOut(stdout);

                Assert.Equal(8, number);
            }
        }

        [Fact]
        public void TestWhenEqual()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                int number = Program.Smallest(8, 8);
                Console.SetOut(stdout);

                Assert.Equal(8, number);
            }
        }
    }
}
