using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Podd
    {
        public string Id { get; set; }
        public string Namn { get; set; }
        public List<Episode> Avsnitt { get; set;}

    public Podd() { 
        }
        public Podd(string id, string namn) 
        {   
            Id = id;
            Namn = namn;

    }
    }
}

