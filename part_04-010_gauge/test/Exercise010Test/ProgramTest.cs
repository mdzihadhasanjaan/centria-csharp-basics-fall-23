namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise010;
    using TestMyCode.CSharp.API.Attributes;
    [Points("4-10")]
    public partial class ProgramTest
    {
        [Fact]

        public void TestInitialValue()
        {
            {
                Gauge g = new Gauge();
                int test = g.value;
                // Assert
                Assert.Equal(0, test);
            }
        }

        [Fact]
        public void TestIncreaseOver5()
        {
            {

                Gauge g = new Gauge();
                g.Increase();
                g.Increase();
                g.Increase();
                g.Increase();
                g.Increase();
                g.Increase();
                int test = g.value;

                // Assert
                Assert.Equal(5, test);
            }
        }

        [Fact]
        public void TestDecreaseUnderZero()
        {
            {
                Gauge g = new Gauge();
                g.Decrease();
                int test = g.value;

                // Assert
                Assert.Equal(0, test);
            }
        }

        [Fact]
        public void TestExample()
        {
            {
                Gauge g = new Gauge();

                while (!g.Full())
                {
                    g.Increase();
                }
                Assert.Equal(5, g.value);
                g.Decrease();

                // Assert
                Assert.Equal(4, g.value);
            }
        }

    }
}
