namespace Exercise009
{
    public class Pet
    {
        public string name { get; }
        public string breed { get; }

        public Pet(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
        public override string ToString()
        {
            return this.name + " " + "(" + this.breed + ")";
        }
    }
}