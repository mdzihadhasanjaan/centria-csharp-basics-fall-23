namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise003;
    using TestMyCode.CSharp.API.Attributes;
    [Points("5-3")]
    public partial class ProgramTest
    {
        [Fact]

        public void TestRandomFitbyte()
        {
            Random rnd = new Random();
            int age = rnd.Next(1, 100);
            int restingHeartRate = rnd.Next(25, 200);
            Fitbyte Fitbyte = new Fitbyte(age, restingHeartRate);
            double percentageOfMaximum = rnd.NextDouble();
            double result = (206.3 - (0.711 * age) - restingHeartRate) * percentageOfMaximum + restingHeartRate;

            Assert.Equal(result, Fitbyte.TargetHeartRate(percentageOfMaximum));
        }

        [Fact]
        public void TestAnotherRandomFitbyte()
        {
            Random rnd = new Random();
            int age = rnd.Next(1, 100);
            int restingHeartRate = rnd.Next(25, 200);
            Fitbyte Fitbyte = new Fitbyte(age, restingHeartRate);
            double percentageOfMaximum = rnd.NextDouble();
            double result = (206.3 - (0.711 * age) - restingHeartRate) * percentageOfMaximum + restingHeartRate;

            Assert.Equal(result, Fitbyte.TargetHeartRate(percentageOfMaximum));
        }

        [Fact]
        public void TestExampleFitByte()
        {
            int age = 30;
            int restingHeartRate = 60;
            Fitbyte assistant = new Fitbyte(age, restingHeartRate);
            double percentageOfMaximum = 0.5;
            double result = (206.3 - (0.711 * age) - restingHeartRate) * percentageOfMaximum + restingHeartRate;

            Assert.Equal(result, assistant.TargetHeartRate(percentageOfMaximum));
        }
    }
}
