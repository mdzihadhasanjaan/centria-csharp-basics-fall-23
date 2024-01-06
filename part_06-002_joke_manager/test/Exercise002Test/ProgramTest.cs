namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise002;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {
        [Fact]
        [Points("6-2.1")]
        public void PointForSectionOne()
        {
            Assert.True(true);
        }

        [Fact]
        [Points("6-2.2")]
        public void AnotherPointForSectionOne()
        {
            Assert.True(true);
        }

        [Fact]
        [Points("6-2.3")]
        public void PointForSectionTwo()
        {
            Assert.True(true);
        }

        [Fact]
        [Points("6-2.4")]
        public void AnotherPointForSectionTwo()
        {
            Assert.True(true);
        }
    }
}
