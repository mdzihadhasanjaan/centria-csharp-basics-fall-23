namespace Exercise007
{
    public class HealthStation
    {
        public int weighings { get; private set; }
        public int count;

        // Create a constructor here, if needed
 

        public int Weigh(Person person)
        {
            // return the weight of the person passed as the parameter
            weighings++;
            return person.weight;
        }

        public void Feed(Person person)
        {
            person.weight++;
        }


    }
}