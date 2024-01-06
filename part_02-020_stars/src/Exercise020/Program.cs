namespace Exercise020
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
   {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");

      //Section 01
      PrintStars(5);
      PrintStars(3);
      PrintStars(9);

      //Section 02
      PrintSquare(4);

      //Section 02
      PrintRectangle(17, 3);

      //Section 02
      PrintTriangle(4);

    }
    
    //Write you methods here
    //Section 01
    public static void PrintStars(int num)
    {
      for(int i = 0; i < num; i++)
      {
        Console.Write("*");
      }
      Console.Write("\n");
    }

  //Section 02
    public static void PrintSquare(int size)
    {
      for(int i = 0; i < size; i++)
      {
        for(int j = 0; j < size; j++)
        {
          Console.Write("*");
        }
        Console.Write("\n");
      }
    }

    //Section 03
    public static void PrintRectangle(int width, int height)
    {
      for(int i = 0; i < height; i++)
      {
        for(int j = 0; j < width; j++)
        {
          Console.Write("*");
        }
        Console.Write("\n");
      }
    }

     //Section 04
    public static void PrintTriangle(int size)
    {
      for(int i = 1; i <= size; i++)
      {
        for(int j = 1; j <= i; j++)
        {
          Console.Write("*");
        }
        Console.Write("\n");
      }
      
    }

    
    //Write you methods here
  }
}
