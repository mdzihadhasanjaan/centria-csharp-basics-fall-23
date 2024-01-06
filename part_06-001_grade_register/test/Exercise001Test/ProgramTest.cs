namespace ProgramTests
{
    using System;
    using System.IO;
    using Xunit;
    using Exercise001;
    using TestMyCode.CSharp.API.Attributes;
    public partial class ProgramTest
    {

        [Fact]
        [Points("6-1.1")]
        public void TestAverageOfGrades()
        {
            GradeRegister register = new GradeRegister();
            register.AddGradeBasedOnPoints(51);
            register.AddGradeBasedOnPoints(50);
            register.AddGradeBasedOnPoints(49);
            Assert.Equal(Math.Round(Convert.ToDouble("0.67", System.Globalization.CultureInfo.InvariantCulture), 2), register.AverageOfGrades());
        }

        [Fact]
        [Points("6-1.1")]
        public void TestAverageOfGradesLarger()
        {
            GradeRegister register = new GradeRegister();
            register.AddGradeBasedOnPoints(151);
            register.AddGradeBasedOnPoints(80);
            register.AddGradeBasedOnPoints(89);
            register.AddGradeBasedOnPoints(99);
            register.AddGradeBasedOnPoints(89);
            register.AddGradeBasedOnPoints(79);
            register.AddGradeBasedOnPoints(61);
            register.AddGradeBasedOnPoints(50);
            register.AddGradeBasedOnPoints(49);
            Assert.Equal(Math.Round(Convert.ToDouble("3.11", System.Globalization.CultureInfo.InvariantCulture), 2), register.AverageOfGrades());
        }

        [Fact]
        [Points("6-1.2")]
        public void TestAverageOfPoints()
        {
            GradeRegister register = new GradeRegister();
            register.AddGradeBasedOnPoints(51);
            register.AddGradeBasedOnPoints(50);
            register.AddGradeBasedOnPoints(49);
            Assert.Equal(50, register.AverageOfPoints());
        }

        [Fact]
        [Points("6-1.2")]
        public void TestAverageOfPointsLarger()
        {
            GradeRegister register = new GradeRegister();
            register.AddGradeBasedOnPoints(51);
            register.AddGradeBasedOnPoints(50);
            register.AddGradeBasedOnPoints(51);
            register.AddGradeBasedOnPoints(50);
            register.AddGradeBasedOnPoints(51);
            register.AddGradeBasedOnPoints(50);
            register.AddGradeBasedOnPoints(51);
            register.AddGradeBasedOnPoints(50);
            register.AddGradeBasedOnPoints(49);
            Assert.Equal(Math.Round(Convert.ToDouble("50.33", System.Globalization.CultureInfo.InvariantCulture), 2), register.AverageOfPoints());
        }


        [Fact]
        [Points("6-1.3")]
        public void TestUserInterfaceWithExample()
        {

            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "82",
                "83",
                "96",
                "51",
                "48",
                "56",
                "61",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Points:\nPoints:\nPoints:\nPoints:\nPoints:\nPoints:\nPoints:\nPoints:\n\n5: *\n4: **\n3: \n2: *\n1: **\n0: *\nThe average of points: " + Convert.ToDouble("68.14", System.Globalization.CultureInfo.InvariantCulture) + "\nThe average of grades: " + Convert.ToDouble("2.43", System.Globalization.CultureInfo.InvariantCulture) + "\n", sw.ToString());
            }
        }

        [Fact]
        [Points("6-1.3")]
        public void TestUserInterfaceWithOtherValues()
        {

            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                TextWriter stdout = Console.Out;

                Console.SetOut(sw);

                var data = String.Join(Environment.NewLine, new[]
                {
                "0",
                "28",
                "99",
                "45",
                "77",
                "31",
                "4",
                "4",
                "4",
                "4",
                "\n"
                });

                Console.SetIn(new System.IO.StringReader(data));

                Program.Main(null!);

                Console.SetOut(stdout);

                // Assert
                Assert.Equal("Points:\nPoints:\nPoints:\nPoints:\nPoints:\nPoints:\nPoints:\nPoints:\nPoints:\nPoints:\nPoints:\n\n5: *\n4: \n3: *\n2: \n1: \n0: ********\nThe average of points: " + Convert.ToDouble("29.6", System.Globalization.CultureInfo.InvariantCulture) + "\nThe average of grades: " + Convert.ToDouble("0.8", System.Globalization.CultureInfo.InvariantCulture) + "\n", sw.ToString());
            }
        }
    }
}
