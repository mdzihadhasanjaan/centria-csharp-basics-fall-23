namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise016;
    using TestMyCode.CSharp.API.Attributes;


    public partial class ProgramTest
    {
        [Fact]
        [Points("2-16")]
        public void TestMethod()
        {
            using (StringWriter sw = new StringWriter())
            {
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                string text = Program.Word();

                Console.SetOut(stdout);

                // Assert
                Assert.Equal(typeof(String), text.GetType());
            }
        }
    }
}
