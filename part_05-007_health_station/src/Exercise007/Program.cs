namespace Exercise007
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            // create new Station
            HealthStation childrensHospital = new HealthStation();

            // create two new persons
            Person ethan = new Person("Ethan", 1, 110, 7);
            Person peter = new Person("Peter", 33, 176, 85);

            // Try out the Persons and method Weigh
            Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Test feeding the persons
            childrensHospital.Feed(ethan);
            childrensHospital.Feed(peter);

            // See that the weights have changed
            Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Keep weighing to increase the 'int weighings'
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);

            // See that the variable has increased to 8
            Console.WriteLine("weighings performed: " + childrensHospital.weighings); 
        }
    }
}