namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            
            while (true)
            {
                string str = Console.ReadLine();

                if (str == "")
                    break;

                string[] pieces = str.Split(" ");

                foreach (string piece in pieces)
                {
                    if (piece.Contains("av"))
                    {
                        Console.WriteLine(piece);
                    }

        }
    }
}

    }
}