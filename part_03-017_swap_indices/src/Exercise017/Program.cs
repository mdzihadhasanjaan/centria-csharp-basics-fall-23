﻿namespace Exercise017
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[5];
      array[0] = 1;
      array[1] = 3;
      array[2] = 5;
      array[3] = 7;
      array[4] = 9;

      int index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
      // Implement here
      // asking for the two indices
      // and then swapping them
      Console.WriteLine("Give two indices to swap:");
      int idx1 = int.Parse(Console.ReadLine());
      int idx2 = int.Parse(Console.ReadLine());

      int temp = array[idx1];
      array[idx1] = array[idx2];
      array[idx2] = temp;
      // DO NOT CHANGE THE FOLLOWING CODE!
      Console.WriteLine("");
      index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }

    }
  }
}
