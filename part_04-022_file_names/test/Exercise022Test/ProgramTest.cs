namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise022;
    using TestMyCode.CSharp.API.Attributes;
    [Points("4-22")]
    public partial class ProgramTest
    {
        [Fact]

        public void TestSongContent()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                        {
                "song.txt"
                });
                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                // Assert
                Assert.Contains(@"DO NOT TOUCH THIS TEST FILE!

No option for duality 
The old is where we come 
Clockspeed is fast, but we'll survive 
The new will overcome 
We are challengers, not followers 
We take the ball to build 
Easy safe services 
Are here to stay

Value for society 
Value for life 
For you and me 
Tieto is here allright!

ALL RIGHT!", sw.ToString());
            }
        }

        [Fact]
        public void TestDataContent()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                        {
                "data.txt"
                });
                Console.SetIn(new System.IO.StringReader(data));
                Program.Main(null!);
                Console.SetOut(stdout);

                // Assert
                Assert.Contains(@"In a world
Where code is built
There are magical creatures
We call them unicorns

DO NOT TOUCH THIS TEST FILE", sw.ToString());
            }
        }
    }
}
