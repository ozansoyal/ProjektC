﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Podcast
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public List<Episode> Episode { get; set; }

        public Podcast(string title, List<Episode> episode)
        {
            Title = title;
            Category = null;
            Episode = episode;
        }
    }

}

