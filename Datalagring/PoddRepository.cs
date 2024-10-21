using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Datalagring
{
    public class PoddRepository
    {
        private List<Podcast> poddLista = new List<Podcast>();
        public void addPodcast(Podcast podd)
        {
            poddLista.Add(podd);
        }
        public List<Podcast> getAllPodcasts()
        { return poddLista; }
        }
}
