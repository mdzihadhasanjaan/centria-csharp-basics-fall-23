namespace Exercise001
{
  public class ClockHand
  {
    public int value { get; set; }
    public int limit { get; set; }

    public ClockHand(int limit)
    {
      this.limit = limit;
      this.value = 0;
    }

    public void Advance()
    {
      this.value = this.value + 1;

      if (this.value >= this.limit)
      {
        this.value = 0;
      }
    }

    public override string ToString()
    {
      if (this.value < 10)
      {
        return "0" + this.value;
      }

      return "" + this.value;
    }
  }


  public class Timer
    {
        private ClockHand seconds;
        private ClockHand hundredths;

        public Timer()
        {
            this.seconds = new ClockHand(60);
            this.hundredths = new ClockHand(100);
        }

        public void Advance()
        {
            this.hundredths.Advance();

            if (this.hundredths.value == 0)
            {
                this.seconds.Advance();
            }
        }

        public override string ToString()
        {
            return $"{this.seconds}:{this.hundredths}";
        }
    }
}