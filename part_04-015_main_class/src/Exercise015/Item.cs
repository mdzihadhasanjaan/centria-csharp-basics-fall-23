// DO NOT TOUCH THE CODE IN HERE!

namespace Exercise015
{
    using System;
    public class Item
    {
        public string name { get; }
        public DateTime createdAt { get; }

        public Item(string name)
        {
            this.name = name;
            this.createdAt = DateTime.Now;
        }

        public override string ToString()
        {
            return this.name + " (created at: " + this.createdAt.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("fi-FI")) + ")";
        }
    }
}