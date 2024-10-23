using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    [Serializable]
    public class Podcast
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<Episode> Episode { get; set; }
        public int Count { get; set; }

        public string Description { get; set; }

        public Podcast() { }

        public Podcast(string title, List<Episode> episode, string description)
        {
            Title = title;
            Name = null;
            Category = null;
            Episode = episode;
            Count = episode.Count;
            Description = description;


        }
        

        

    }

}

