namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise006;
    using TestMyCode.CSharp.API.Attributes;
    [Points("4-6")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestProductCreation()
        {
            Product product = new Product("banana", 1.5, 8);
            // Assert
            Assert.Equal(typeof(Product), product.GetType());
        }

        [Fact]
        public void TestExamplePrintProduct()
        {
            Product banana = new Product("Banana", 1.1, 13);

            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                banana.PrintProduct();
                Console.SetOut(stdout);

                // Assert
                //Assert.Contains("Banana: price 1.1: 13 pcs", sw.ToString());
                Assert.Contains("Banana: price " + Convert.ToDouble("1.1", System.Globalization.CultureInfo.InvariantCulture).ToString() + ": 13 pcs", sw.ToString());

            }
        }

        [Fact]
        public void TestManyKiwis()
        {
            Product kiwi = new Product("Kiwi", 0.2, 1275);

            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                kiwi.PrintProduct();
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Kiwi: price " + Convert.ToDouble("0.2", System.Globalization.CultureInfo.InvariantCulture).ToString() + ": 1275 pcs", sw.ToString());
            }
        }
        [Fact]
        public void TestRandomPriceAndAmount()
        {
            Random random = new Random();
            int randomPrice = random.Next();
            int randomAmount = random.Next();
            Product potato = new Product("Potato", randomPrice, randomAmount);

            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                potato.PrintProduct();
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("Potato: price " + randomPrice + ": " + randomAmount + " pcs", sw.ToString());
            }
        }

    }
}
