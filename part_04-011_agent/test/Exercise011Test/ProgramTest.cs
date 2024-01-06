namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise011;
    using TestMyCode.CSharp.API.Attributes;
    using System.Collections.Generic;
    [Points("4-11")]
    public partial class ProgramTest
    {

        [Fact]
        public void TestToStringBond()
        {
            Agent bond = new Agent("James", "Bond");

            Assert.Equal("My name is Bond. James Bond.", bond.ToString());
        }

        [Fact]
        public void TestToStringBourne()
        {
            Agent bourne = new Agent("Jason", "Bourne");

            Assert.Equal("My name is Bourne. Jason Bourne.", bourne.ToString());
        }

        [Fact]
        public void TestToStringDoctor()
        {
            Agent evil = new Agent("Dr.", "Evil");

            Assert.Equal("My name is Evil. Dr. Evil.", evil.ToString());
        }

    }
}

