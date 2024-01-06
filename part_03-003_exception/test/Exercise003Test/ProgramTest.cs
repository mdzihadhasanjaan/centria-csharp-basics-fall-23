namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise003;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-3")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestException()
        {
            using (StringWriter sw = new StringWriter())
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => Program.Main(null!));
            }
        }
    }
}
