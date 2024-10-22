using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   

namespace Models
{
    [Serializable]
    public class Episode
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public string Link { get; set; }
        public string Author { get; set; }

        public Episode(string id, string title, string description, DateTimeOffset publishDate, string link, string author)
        {
            Id = id;
            Title = title;
            Description = description;
            PublishDate = publishDate;
            Link = link;
            Author = author;
        }
    }

}
