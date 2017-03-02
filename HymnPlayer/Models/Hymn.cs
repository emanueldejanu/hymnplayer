using System.Collections.Generic;

namespace HymnPlayer.Models
{
    public class Hymn
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public List<Verse> Verses { get; set; }
    }
}
