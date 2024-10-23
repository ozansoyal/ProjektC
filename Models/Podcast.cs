using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Models
{
    [Serializable]

    
    public class Podcast
    {
        
            [XmlElement("Title")]
            public string Title { get; set; }

            [XmlArray("Episodes")]
            [XmlArrayItem("Episode")]
            public List<Episode> Episodes { get; set; }
        }



        //public Podcast(string title, List<Episode> episode, string description)
        //{
        //    Title = title;
        //    Name = null;
        //    Category = null;
        //    Episode = episode;
        //    Count = episode.Count;
        //    Description = description;


        //}

        //public Podcast() { }
    }



