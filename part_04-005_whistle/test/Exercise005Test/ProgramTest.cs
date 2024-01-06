namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise005;
    using TestMyCode.CSharp.API.Attributes;
    using System.Reflection;
    [Points("4-5")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestWhistleCreation()
        {
            Whistle whistle = new Whistle("Kvaak");
            // Assert
            Assert.Equal(typeof(Whistle), whistle.GetType());
        }

        [Fact]
        public void TestWhistleSound()
        {
            Whistle whistle = new Whistle("This is a test whistle");


            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);
                whistle.Sound();
                Console.SetOut(stdout);

                // Assert
                Assert.Equal(typeof(Whistle), whistle.GetType());
                Assert.Contains("This is a test whistle", sw.ToString());
            }
        }

        [Fact]
        public void TestWhistleAttributes()
        {
            Whistle whistle = new Whistle("Woof woof");

            Type typ = typeof(Whistle);
            FieldInfo sound = typ.GetField("sound", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            string actualWhistle = sound.GetValue(whistle) as string;
            // Assert
            Assert.Equal("Woof woof", actualWhistle);
        }
    }


}
