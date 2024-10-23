using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IEpisode
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset PublishDate { get; set; }

        public string Duration { get; set; }

        public string Link { get; set; }
       
    }
}
