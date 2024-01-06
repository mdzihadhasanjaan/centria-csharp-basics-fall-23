namespace Exercise011
{
    public class Song
    {
        private string artist;
        private string name;
        private int durationInSeconds;

        public Song(string artist, string name, int durationInSeconds)
        {
            this.artist = artist;
            this.name = name;
            this.durationInSeconds = durationInSeconds;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song songs = (Song)obj;
            return artist == songs.artist &&
                   name == songs.name &&
                   durationInSeconds == songs.durationInSeconds;
        }

        public override string ToString()
        {
            return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
        }
    }
}