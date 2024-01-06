namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise004;
    using TestMyCode.CSharp.API.Attributes;
    [Points("5-4")]
    public partial class ProgramTest
    {
        [Fact]

        public void TestProductNameAndWeightConstructor()
        {
            Product product = new Product("Measure", 5);

            Assert.Equal(typeof(Product), product.GetType());
        }

        [Fact]
        public void TestProductNameConstructor()
        {
            Product product = new Product("Measure");

            Assert.Equal(typeof(Product), product.GetType());
        }

        [Fact]
        public void TestProductNameAndLocationConstructor()
        {
            Product product = new Product("Measure", "Farm");

            Assert.Equal(typeof(Product), product.GetType());
        }

        [Fact]
        public void TestProductNameAndWeightConstructorToString()
        {
            Product product = new Product("Master Blaster", 666);

            Assert.Equal("Master Blaster (666 kg) can be found from the warehouse.", product.ToString());
        }

        [Fact]
        public void TestProductNameConstructorToString()
        {
            Product product = new Product("Holy hand granade");

            Assert.Equal("Holy hand granade (1 kg) can be found from the shelf.", product.ToString());
        }

        [Fact]
        public void TestProductNameAndLocationConstructorToString()
        {
            Product product = new Product("Unholy water cannon", "Magic pond");

            Assert.Equal("Unholy water cannon (1 kg) can be found from the Magic pond.", product.ToString());
        }

    }
}
