namespace Exercise017
{
  using System;
  using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {

            List<TelevisionProgram> list = new List<TelevisionProgram>();
            // IMPLEMENT YOUR CODE IN HERE!
            while(true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if(name == "")
                    break;

                Console.Write("Duration: ");
                int duration = int.Parse(Console.ReadLine());

                TelevisionProgram newProgram = new TelevisionProgram(name, duration);
                list.Add(newProgram);
            }

            Console.WriteLine();
            Console.Write("Program's maximum duration? ");
            int inputDuration = int.Parse(Console.ReadLine());
            
            foreach(TelevisionProgram item in list)
            {
                if(item.duration <= inputDuration)
                {
                    Console.WriteLine($"{item.name}, {item.duration} minutes");
                }
            }

        }
    }
}