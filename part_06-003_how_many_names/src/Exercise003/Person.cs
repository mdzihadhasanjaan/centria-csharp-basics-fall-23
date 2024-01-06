namespace Exercise003
{
    public class Person
    {
        public string name {get;}
        public int age;

        public Person(string givenName)
        {
            this.name = givenName;
            this.age = 0;
        }

        public bool IsOfAge()
        {
            return (this.age >= 18);
        }

        public void GrowOlder()
        {
            this.age++;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}