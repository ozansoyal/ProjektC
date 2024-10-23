using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   

namespace Models
{
    [Serializable]
    public class Episode: IEpisode
    {
       
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset PublishDate { get; set; }

        public string Duration { get; set; }

        public string Link { get; set; }
        public Episode(string title, string description, DateTimeOffset publishDate, string link, string duration)
        { 
            
            Title = title;
            Description = description;
            PublishDate = publishDate;
            Link = link;
            Duration = duration;
        }
        public Episode() { }
    }

}
