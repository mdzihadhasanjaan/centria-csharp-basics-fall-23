namespace Exercise020
{
  using System;
    public class Program
    {
        public static void Main(string[] args)
        {
          while(true)
          {
            string str = Console.ReadLine();

            if(str == "end")
              break;

            int num = int.Parse(str);
            Console.WriteLine(num * num * num);
          }
        }
    }
}