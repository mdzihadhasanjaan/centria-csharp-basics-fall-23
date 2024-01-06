namespace Exercise002
{
  using System;
  public class Cube
  {
    public int edgeLength;
    public Cube(int edgeLength)
    {
      this.edgeLength = edgeLength;
    }

    public int Volume()
    {
      return edgeLength * edgeLength * edgeLength;
    }

    public override string ToString()
    {
      return $"The length of the edge is {edgeLength} and the volume {Volume()}";
    }
  }
  public class Program
  {
    public static void Main(string[] args)
    {
      // You can test different cubes here.
      Cube myCube = new Cube(5);
      Console.WriteLine(myCube.ToString());

      int cubeVolume = myCube.Volume();
      Console.WriteLine($"The volume of cube1: {cubeVolume}");
      
    }
  }
}