﻿namespace Exercise027
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
             {
            while(true)
            {
                string str = Console.ReadLine();
                if(str == "")
                    break;
                
                string[] words = str.Split(" ");
                Console.WriteLine(words[0]);
            }
        }

        }
    }
}