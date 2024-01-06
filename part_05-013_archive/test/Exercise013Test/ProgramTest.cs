namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise013;
    using TestMyCode.CSharp.API.Attributes;
    [Points("5-13")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestConstructor()
        {
            Item item = new Item("B07H8ND8HH", "He-Man figure");

            Assert.Equal(typeof(Item), item.GetType());
        }

        [Fact]
        public void TestAreEqualHeMen()
        {
            Item item = new Item("B07H8ND8HH", "He-Man figure");
            Item item2 = new Item("B07H8ND8HH", "He-Man figure");
            Assert.Equal(item, item2);
        }

        [Fact]
        public void TestAreEqualHeManAndKenDoll()
        {
            Item item = new Item("B07H8ND8HH", "He-Man figure");
            Item item2 = new Item("B07H8ND8HH", "Ken doll");
            Assert.Equal(item, item2);
        }

        [Fact]
        public void TestAreNotEqualWithSameNameDifferentID()
        {
            Item item = new Item("B07H8ND8H", "He-Man figure");
            Item item2 = new Item("B07H8ND8HH", "He-Man figure");
            Assert.NotEqual(item, item2);
        }

        [Fact]
        public void TestAreNotEqualWithDifferentNameDifferentID()
        {
            Item item = new Item("B07H8ND8HHH", "He-Man figure");
            Item item2 = new Item("B07H8ND8HH", "He-Man");
            Assert.NotEqual(item, item2);
        }

        [Fact]
        public void TestMainMethodAskingThreeSameDolls()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "B07H8ND8HHH",
                "He-Man figure",
                "B07H8ND8HHH",
                "He-Man figurine",
                "B07H8ND8HHH",
                "Barbie fig",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Identifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\n==Items==\nB07H8ND8HHH: He-Man figure\n", sw.ToString());
            }
        }

        [Fact]
        public void TestMainMethodWithMultipleDifferentItems()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "B07H8ND8HHH",
                "He-Man figure",
                "B07H8ND8H",
                "He-Man figure",
                "B07H8ND8HHHJK",
                "He-Man figure",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Identifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\nName? (empty will stop):\nIdentifier? (empty will stop):\n==Items==\nB07H8ND8HHH: He-Man figure\nB07H8ND8H: He-Man figure\nB07H8ND8HHHJK: He-Man figure\n", sw.ToString());
            }
        }
    }
}
