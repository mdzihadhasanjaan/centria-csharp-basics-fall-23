namespace Exercise005
{
  public class Whistle
  {
    private string sound;
    public Whistle(string whistleSoung)
    {
      this.sound = whistleSoung;
    }

    public void Sound()
    {
      Console.WriteLine(sound);
    }
  }
  public class Program
  {
    public static void Main(string[] args)
    {
      Whistle duckWhistle = new Whistle("kvaak");
      Whistle roosterWhistle = new Whistle("Peef");

      duckWhistle.Sound();
      roosterWhistle.Sound();
      duckWhistle.Sound();
    }
  }
}