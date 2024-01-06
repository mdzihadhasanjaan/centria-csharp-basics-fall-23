namespace Exercise003
{
    using System;

    public class Fitbyte
    {
        public int age;
        public double restingHeartRate;

        public Fitbyte(int age, double restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maxHeartRate = 206.3 - (0.711 * age);
            double result = (maxHeartRate - restingHeartRate) * (percentageOfMaximum) + restingHeartRate;
            return result;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Fitbyte assistant = new Fitbyte(30, 60);
            double percentage = 0.5;

            while (percentage < 1.0)
            {
                double target = assistant.TargetHeartRate(percentage);
                Console.WriteLine("Target " + (percentage * 100) + "% of maximum: " + target);
                percentage = percentage + 0.1;
            }
        }
    }
}