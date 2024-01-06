namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise009;
    using TestMyCode.CSharp.API.Attributes;
    [Points("5-9")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestPersonConstructorWithName()
        {
            Person mike = new Person("Mike");
            Assert.Equal("Mike, has a friend called Toothless (dragon)", mike.ToString());
        }

        [Fact]
        public void TestPersonConstructorNoParams()
        {
            Person lilo = new Person();
            Assert.Equal("Lilo, has a friend called Stitch (blue alien)", lilo.ToString());
        }

        [Fact]
        public void TestPersonConstructorAllParams()
        {
            Pet lucy = new Pet("Lucille", "golden dragon");
            Person leo = new Person("Leonard", lucy);
            Assert.Equal("Leonard, has a friend called Lucille (golden dragon)", leo.ToString());
        }

        [Fact]
        public void TestPetIsNotModified()
        {
            Pet churro = new Pet("Churro", "Hot pocket");
            Assert.Equal("Churro (Hot pocket)", churro.ToString());
        }
    }
}
