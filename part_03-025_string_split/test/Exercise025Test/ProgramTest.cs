namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise025;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;

    [Points("3-25")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestReturnsInput()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
          "mickey mouse has a house",
          "i like it",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                string comparison = "mickey\nmouse\nhas\na\nhouse\ni\nlike\nit\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }
        [Fact]
        public void TestReturnsLongInput()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;
                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
          "I am the king of the world",
          "I can split strings!",
          "\n"
          });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);
                Console.SetOut(stdout);

                string comparison = "I\nam\nthe\nking\nof\nthe\nworld\nI\ncan\nsplit\nstrings!\n";
                Assert.Equal(comparison, sw.ToString());
            }
        }
    }
}
