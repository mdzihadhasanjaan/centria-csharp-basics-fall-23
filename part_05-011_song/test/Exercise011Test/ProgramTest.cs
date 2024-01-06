namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise011;
    using TestMyCode.CSharp.API.Attributes;
    [Points("5-11")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestAreEqualSongs()
        {
            Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Assert.Equal(jackSparrow, anotherSparrow);
        }

        [Fact]
        public void TestAreEqualAgain()
        {
            Song jackSparrow = new Song("The Lonely Islanders", "Jack Sparrows", 1960);
            Song anotherSparrow = new Song("The Lonely Islanders", "Jack Sparrows", 1960);
            Assert.Equal(jackSparrow, anotherSparrow);
        }

        [Fact]
        public void TestAreNotEqualDifferentTime()
        {
            Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 197);
            Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Assert.NotEqual(jackSparrow, anotherSparrow);
        }

        [Fact]
        public void TestAreNotEqualDifferentArtists()
        {
            Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrows", 196);
            Assert.NotEqual(jackSparrow, anotherSparrow);
        }

        [Fact]
        public void TestAreNotEqualDifferentSongs()
        {
            Song jackSparrow = new Song("The Lonely Island", "Jack Sparrows", 196);
            Song anotherSparrow = new Song("The Lonely Islands", "Jack Sparrows", 196);
            Assert.NotEqual(jackSparrow, anotherSparrow);
        }

        [Fact]
        public void TestAreNotEqualDifferentAll()
        {
            Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 1960);
            Song anotherSparrow = new Song("The Lonely Islands", "Jack Sparrows", 196);
            Assert.NotEqual(jackSparrow, anotherSparrow);
        }

        [Fact]
        public void TestIsNotEqualWithNull()
        {
            Song jackSparrow = null;
            Song anotherSparrow = new Song("The Lonely Islands", "Jack Sparrows", 196);
            Assert.NotEqual(jackSparrow, anotherSparrow);
        }

        [Fact]
        public void TestIsNotEqualWithNullOtherWay()
        {
            Song jackSparrow = null;
            Song anotherSparrow = new Song("The Lonely Islands", "Jack Sparrows", 196);
            Assert.NotEqual(anotherSparrow, jackSparrow);
        }

    }
}
