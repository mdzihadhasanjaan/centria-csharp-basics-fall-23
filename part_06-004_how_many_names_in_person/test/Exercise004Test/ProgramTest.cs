namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise004;
    using TestMyCode.CSharp.API.Attributes;
    [Points("6-4")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestPersonNameCount()
        {
            {
                Person jack = new Person("Jack The Ripper");

                Assert.Equal(3, jack.HowManyNames());
            }
        }

        [Fact]
        public void TestPersonNameMagicCount()
        {
            {
                Person jack = new Person("Mike the Magic house mouse");

                Assert.Equal(5, jack.HowManyNames());
            }
        }

        [Fact]
        public void TestSingleLetterNameCount()
        {
            {
                Person em = new Person("M");

                Assert.Equal(1, em.HowManyNames());
            }
        }

        [Fact]
        public void TestMMMNameCount()
        {
            {
                Person em = new Person("MMM");

                Assert.Equal(1, em.HowManyNames());
            }
        }

        [Fact]
        public void TestLowercaseNameCount()
        {
            {
                Person em = new Person("name other");

                Assert.Equal(2, em.HowManyNames());
            }
        }
    }
}
