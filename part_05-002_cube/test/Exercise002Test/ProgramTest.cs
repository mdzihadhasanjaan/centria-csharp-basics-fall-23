namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise002;
    using TestMyCode.CSharp.API.Attributes;
    [Points("5-02")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestCubeConstructor()
        {
            Cube cube = new Cube(2);

            Assert.Equal(cube.GetType(), typeof(Cube));
        }

        [Fact]
        public void TestCubeVolume()
        {
            Cube cube = new Cube(3);

            Assert.Equal(27, cube.Volume());
        }

        [Fact]
        public void TestHugeCubeVolume()
        {
            Cube cube = new Cube(42);

            Assert.Equal(74088, cube.Volume());
        }

        [Fact]
        public void TestRandomCubeVolume()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 100);
            Cube cube = new Cube(rand);

            Assert.Equal((rand * rand * rand), cube.Volume());
        }

        [Fact]
        public void TestFourCubeToString()
        {
            Cube cube = new Cube(4);
            Assert.Equal("The length of the edge is 4 and the volume 64", cube.ToString());
        }

        [Fact]
        public void TestRandomCubeToString()
        {

            Random rnd = new Random();
            int rand = rnd.Next(1, 100);
            Cube cube = new Cube(rand);
            Assert.Equal("The length of the edge is " + rand + " and the volume " + rand * rand * rand, cube.ToString());
        }

    }
}
