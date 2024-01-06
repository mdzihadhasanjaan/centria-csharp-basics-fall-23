namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise009;
    using TestMyCode.CSharp.API.Attributes;
    [Points("4-9")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestPrintExample()
        {
            using (StringWriter sw = new StringWriter())
            {

                Dalmatian spotty = new Dalmatian("Spot", 306);
                string test = spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur";

                // Assert
                Assert.Equal("Spot is a very good dog. He has 306 darker spots in his fur", test);
            }
        }

        [Fact]
        public void TestAnotherDog()
        {
            using (StringWriter sw = new StringWriter())
            {

                Dalmatian spotty = new Dalmatian("Another", 34);
                string test = spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur";

                // Assert
                Assert.Equal("Another is a very good dog. He has 34 darker spots in his fur", test);
            }
        }

        [Fact]
        public void TestMultipleDogs()
        {
            using (StringWriter sw = new StringWriter())
            {

                Dalmatian spotty = new Dalmatian("Spotty", 42);
                string test = spotty.name + " is a very good dog. He has " + spotty.spots + " darker spots in his fur";

                Dalmatian naughty = new Dalmatian("Naughty", 777);
                string next = naughty.name + " is a very good dog. He has " + naughty.spots + " darker spots in his fur";

                Dalmatian nice = new Dalmatian("Nice", 666);
                string last = nice.name + " is a very good dog. He has " + nice.spots + " darker spots in his fur";
                // Assert
                Assert.Equal("Spotty is a very good dog. He has 42 darker spots in his fur", test);

                Assert.Equal("Naughty is a very good dog. He has 777 darker spots in his fur", next);

                Assert.Equal("Nice is a very good dog. He has 666 darker spots in his fur", last);
            }
        }
    }
}
