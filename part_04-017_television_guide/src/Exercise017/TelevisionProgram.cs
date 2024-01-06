// DO NOT TOUCH THE CODE IN HERE

namespace Exercise017
{
    using System;
    public class TelevisionProgram
    {

        public string name { get; set; }
        public int duration { get; set; }

        public TelevisionProgram(string name, int duration)
        {
            this.name = name;
            this.duration = duration;
        }

        public override string ToString()
        {
            return this.name + ", " + this.duration + " minutes";
        }
    }
}