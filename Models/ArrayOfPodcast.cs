using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    public class ArrayOfPodcast
    {
        [XmlElement("Podcast")]
        public List<Podcast> Podcasts { get; set; }
    }
}
