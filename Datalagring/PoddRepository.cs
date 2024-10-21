using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Datalagring
{
    public class Repository
    {
        private List<Podd> poddLista = new List<Podd>();
        public void LäggTillPodd(Podd podd)
        {
            poddLista.Add(podd);
        }
        public List<Podd> HämtaAllaPoddar()
        { return poddLista; }
        }
}
