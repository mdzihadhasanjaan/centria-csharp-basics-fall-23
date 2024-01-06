namespace Exercise013
{
    public class Item
    {

        private string identifier;
        private string name;

        public Item(string identifier, string name)
        {
            this.identifier = identifier;
            this.name = name;
        }
        public override string ToString()
        {
            return this.identifier + ": " + this.name;
        }

        public override bool Equals(object compared)
        {
            //compare with Item.identifier
            if(compared == null || GetType() != compared.GetType())
                return false;
            
            Item other = (Item)compared;
            return identifier == other.identifier;
        }
    }

}