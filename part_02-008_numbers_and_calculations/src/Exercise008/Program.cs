namespace Exercise008
{
    using System;
    public class Program
    { 
        public static void Main(string[] args)
        {
            // //Section 01
            // Console.WriteLine("Give numbers:");
            // while (true)
            // {
            //     int nums = int.Parse(Console.ReadLine());
            //     if (nums == -1)
            //     {
            //         Console.WriteLine("Thx! Bye!");
            //         break;
            //     }
            // }



            // //Section 02
            // Console.WriteLine("Give numbers:");
            // int sum = 0;
            // while (true)
            // {
            //     int nums = int.Parse(Console.ReadLine());
            //     if (nums == -1)
            //     {
            //         Console.WriteLine("Thx! Bye!");
            //         Console.WriteLine($"Sum: {sum}");
            //         break;
            //     }
            //     sum += nums;
            // }


            // //Section 03
            // Console.WriteLine("Give numbers:");
            // int sum = 0;
            // int count = 0;
            // while (true)
            // {
            //     int nums = int.Parse(Console.ReadLine());
            //     if (nums == -1)
            //     {
            //         double avg = sum / (double)count;
            //         Console.WriteLine("Thx! Bye!");
            //         Console.WriteLine($"Sum: {sum}");
            //         Console.WriteLine($"Numbers: {count}");
            //         break;
            //     }
            //     sum += nums;
            //     count++;
            // }




            // // //Section 04
            // Console.WriteLine("Give numbers:");
            // int sum = 0;
            // int count = 0;
            // while (true)
            // {
            //     int nums = int.Parse(Console.ReadLine());
            //     if (nums == -1)
            //     {
            //         double avg = sum / (double)count;
            //         Console.WriteLine("Thx! Bye!");
            //         Console.WriteLine($"Sum: {sum}");
            //         Console.WriteLine($"Numbers: {count}");
            //         Console.WriteLine($"Average: {avg}");
            //         break;
            //     }
            //     sum += nums;
            //     count++;
            // }




            //Section 05
            Console.WriteLine("Give numbers:");
            int sum = 0;
            int count = 0;
            int even_count = 0;
            int odd_count = 0;

            while (true)
            {
                int nums = int.Parse(Console.ReadLine());
                if (nums == -1)
                {
                    double avg = sum / (double)count;
                    Console.WriteLine("Thx! Bye!");
                    Console.WriteLine($"Sum: {sum}");
                    Console.WriteLine($"Numbers: {count}");
                    Console.WriteLine($"Average: {avg}");
                    Console.WriteLine($"Even: {even_count}");
                    Console.WriteLine($"Odd: {odd_count}");
                    break;
                }
                count++;
                sum += nums;
                
                if (nums % 2 == 0)
                {
                    even_count++;
                }
                else
                {
                    odd_count++;
                }
            }



        }
    }
}