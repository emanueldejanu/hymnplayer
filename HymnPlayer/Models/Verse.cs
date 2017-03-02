namespace HymnPlayer.Models
{
    public class Verse
    {
        public string Text { get; set; }

        public Verse()
        {   
        }

        public Verse(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}