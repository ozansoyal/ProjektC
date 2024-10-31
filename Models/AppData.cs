using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AppData
    {
        public List<Podcast> Podcasts { get; set; }
        public List<Category> Categories { get; set; }

        public AppData()
        {
            Podcasts = new List<Podcast>();
            Categories = new List<Category>();
        }

    }
}
