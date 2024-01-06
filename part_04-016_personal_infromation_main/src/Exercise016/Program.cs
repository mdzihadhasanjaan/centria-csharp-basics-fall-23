namespace Exercise016
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<PersonalInformation> list = new List<PersonalInformation>();
            // IMPLEMENT YOUR CODE IN HERE!
            while (true)
            {
                Console.WriteLine("First name:");
                string firstName = Console.ReadLine();

                if (firstName == "")
                    break;

                Console.WriteLine("Last name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Identification number:");
                string identificationNumber = Console.ReadLine();

                PersonalInformation personalInfo = new PersonalInformation(firstName, lastName, identificationNumber);
                list.Add(personalInfo);
            }

            Console.WriteLine();

            foreach (PersonalInformation item in list)
            {
                // Print only first and last name!
                Console.WriteLine($"{item.firstName} {item.lastName}");
            }

        }
    }
}