namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise007;
    using TestMyCode.CSharp.API.Attributes;

    public partial class ProgramTest
    {
        [Fact]
        [Points("5-7.1")]
        public void TestHealthStationConstructor()
        {
            HealthStation station = new HealthStation();

            Assert.Equal(typeof(HealthStation), station.GetType());
        }

        [Fact]
        [Points("5-7.1")]
        public void TestPersonConstructor()
        {

            Person mannen = new Person("Heikki", 15, 110, 185);

            Assert.Equal(typeof(Person), mannen.GetType());
        }

        [Fact]
        [Points("5-7.1")]
        public void TestHealthStationWeighing()
        {
            Person mannen = new Person("Superman", 35, 200, 300);
            HealthStation station = new HealthStation();

            Assert.Equal(200, station.Weigh(mannen));
        }

        [Fact]
        [Points("5-7.1")]
        public void TestHealthStationWeighingAnother()
        {
            Person mannen = new Person("Master Blaster", 500, 3000, 300);
            HealthStation station = new HealthStation();

            Assert.Equal(3000, station.Weigh(mannen));
        }


        [Fact]
        [Points("5-7.2")]
        public void TestHealthStationFeeding()
        {
            Person mannen = new Person("Superman", 35, 200, 300);
            HealthStation station = new HealthStation();
            station.Feed(mannen);

            Assert.Equal(201, station.Weigh(mannen));
        }

        [Fact]
        [Points("5-7.2")]
        public void TestHealthStationFeedingMore()
        {
            Person mannen = new Person("Superman", 35, 200, 300);
            HealthStation station = new HealthStation();
            station.Feed(mannen);
            station.Feed(mannen);
            station.Feed(mannen);
            station.Feed(mannen);

            Assert.Equal(204, station.Weigh(mannen));
        }

        [Fact]
        [Points("5-7.3")]
        public void TestHealthStationWeighingCounter()
        {
            Person mannen = new Person("Superman", 35, 200, 300);
            HealthStation station = new HealthStation();
            station.Weigh(mannen);
            station.Weigh(mannen);
            station.Weigh(mannen);
            station.Weigh(mannen);

            Assert.Equal(4, station.weighings);
        }

        [Fact]
        [Points("5-7.3")]
        public void TestHealthStationWeighingCounterMultiplePeople()
        {
            Person mannen = new Person("Superman", 35, 200, 300);
            Person kvinnan = new Person("Catwoman", 24, 100, 180);
            Person annan = new Person("Lex", 50, 500, 180);
            HealthStation station = new HealthStation();
            station.Weigh(mannen);
            station.Weigh(kvinnan);
            station.Weigh(annan);
            station.Weigh(annan);
            station.Weigh(mannen);
            station.Weigh(annan);
            station.Weigh(mannen);
            station.Weigh(kvinnan);
            station.Weigh(mannen);
            station.Weigh(kvinnan);
            station.Weigh(annan);
            station.Weigh(kvinnan);
            station.Weigh(mannen);
            station.Weigh(mannen);
            station.Weigh(mannen);
            station.Weigh(annan);

            Assert.Equal(16, station.weighings);
        }
    }
}
