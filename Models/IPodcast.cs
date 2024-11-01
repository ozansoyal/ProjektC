using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IPodcast
    {
        string Title { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        public List<Episode> Episode { get; set; }
        int Count { get; set; }
    }
}
