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
        public string Rubrik { get; set; }

        //public string Kategori { get; set; }

        public Podd() { 
        }
        public Podd(string id, string rubrik) 
        {   
            Id = id;
            Rubrik = rubrik;
            //Kategori = kategori;
    }
    }
}

