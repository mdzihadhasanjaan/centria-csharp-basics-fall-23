namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise016;
    using System.Collections.Generic;
    using TestMyCode.CSharp.API.Attributes;
    [Points("3-16")]
    public partial class ProgramTest
    {
        [Fact]
        public void TestRemoveLastString()
        {
            using (StringWriter sw = new StringWriter())
            {
                List<string> strings = new List<string>();
                strings.Add("Hakuna matata");
                strings.Add("What a wonderful phrase");
                strings.Add("Hakuna matata");
                strings.Add("This will be removed");

                Program.RemoveLast(strings);

                string compare = "";
                for (int i = 0; i < strings.Count; i++)
                {
                    compare += strings[i] + "\n";
                }

                Assert.Equal("Hakuna matata\nWhat a wonderful phrase\nHakuna matata\n", compare.Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestWhenOneString()
        {
            using (StringWriter sw = new StringWriter())
            {
                List<string> strings = new List<string>();
                strings.Add("This will be removed");

                Program.RemoveLast(strings);

                string compare = "";
                for (int i = 0; i < strings.Count; i++)
                {
                    compare += strings[i] + "\n";
                }

                Assert.Equal("", compare.Replace("\r\n", "\n"));
            }
        }

        [Fact]
        public void TestRemoveMultipleStrings()
        {
            using (StringWriter sw = new StringWriter())
            {
                List<string> strings = new List<string>();
                strings.Add("This will not be removed");
                strings.Add("This will be removed");
                strings.Add("This will be removed");
                strings.Add("This will be removed");

                Program.RemoveLast(strings);
                Program.RemoveLast(strings);
                Program.RemoveLast(strings);

                string compare = "";
                for (int i = 0; i < strings.Count; i++)
                {
                    compare += strings[i] + "\n";
                }

                Assert.Equal("This will not be removed\n", compare.Replace("\r\n", "\n"));
            }
        }
    }
}
