namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise012;
    using TestMyCode.CSharp.API.Attributes;
    [Points("5-12")]
    public partial class ProgramTest
    {
        [Fact]

        public void TestAreEqualBooks()
        {
            Book book = new Book("Novel idea", 2020);
            Book book2 = new Book("Novel idea", 2020);
            Assert.Equal(book, book2);
        }

        [Fact]
        public void TestAreEqualAgain()
        {
            Book book = new Book("Novel ideas", 2019);
            Book book2 = new Book("Novel ideas", 2019);
            Assert.Equal(book, book2);
        }

        [Fact]
        public void TestAreNotEqualDifferentName()
        {
            Book book = new Book("Novel idea", 2020);
            Book book2 = new Book("Novel ideas", 2020);
            Assert.NotEqual(book, book2);
        }

        [Fact]
        public void TestAreNotEqualDifferentNameAndYear()
        {
            Book book = new Book("Novel idea", 2020);
            Book book2 = new Book("Novel ideas", 2019);
            Assert.NotEqual(book, book2);
        }

        [Fact]
        public void TestAreNotEqualDifferentYear()
        {
            Book book = new Book("Novel idea", 2020);
            Book book2 = new Book("Novel idea", 2019);
            Assert.NotEqual(book, book2);
        }

        [Fact]
        public void TestExercise130Once()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "My Novel",
                "2020",
                "Hot potato",
                "2020",
                "Mein Bokken",
                "2019",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Name (empty will stop):\nPublication year:\nName (empty will stop):\nPublication year:\nName (empty will stop):\nPublication year:\nName (empty will stop):\nThank you! Books added: 3\n", sw.ToString());
            }
        }

        [Fact]
        public void TestExercise130Twice()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "My Novel",
                "2020",
                "My Novel",
                "2020",
                "Mein Bokken",
                "2019",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Name (empty will stop):\nPublication year:\nName (empty will stop):\nPublication year:\nThe book is already on the list. Let's not add the same book again.\nName (empty will stop):\nPublication year:\nName (empty will stop):\nThank you! Books added: 2\n", sw.ToString().Replace("\r\n", "\n"));
            }
        }
    }
}
