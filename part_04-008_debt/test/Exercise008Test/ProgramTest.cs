namespace ProgramTests
{
    using System;
    using System.IO;
    using System.Globalization;
    using Xunit;
    using Exercise008;
    using TestMyCode.CSharp.API.Attributes;
    [Points("4-8")]
    public partial class ProgramTest
    {
        [Fact]

        public void TestPrintBalance()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Debt debt = new Debt(1000000.00, 1.2);
                debt.PrintBalance();

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("1000000\n".Replace(",", "."), sw.ToString().Replace(",", "."));
            }
        }

        [Fact]
        public void TestPrintBalanceWithRandomInterest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Random random = new Random();
                double interest = random.NextDouble();
                double balance = random.NextDouble() * 100000;
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Debt debt = new Debt(balance, interest);
                debt.WaitOneYear();
                debt.WaitOneYear();
                debt.PrintBalance();

                // Restore the original standard output.
                Console.SetOut(stdout);

                double actual = balance * interest * interest;
                // Assert
                Assert.Equal(actual.ToString().Replace(",", ".") + "\n", sw.ToString().Replace(",", "."));
            }
        }

        [Fact]
        public void TestInterest()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Debt debt = new Debt(1000000.00, 1.2);
                debt.WaitOneYear();
                debt.WaitOneYear();
                debt.PrintBalance();

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Equal("1440000\n".Replace(",", "."), sw.ToString().Replace(",", "."));
            }
        }

        [Fact]
        public void TestLongDebt()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.NewLine = "\n";
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                Debt debt = new Debt(1000000.00, 1.2);
                for (int i = 0; i < 25; i++)
                {
                    debt.WaitOneYear();
                }
                debt.PrintBalance();

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.Contains("95396216.644".Replace(",", "."), sw.ToString().Replace(",", "."));
            }
        }

    }
}
