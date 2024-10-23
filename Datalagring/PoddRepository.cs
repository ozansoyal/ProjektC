using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Models;

namespace Datalagring
{
    public class PoddRepository
    {
        private List<Podcast> poddLista = new List<Podcast>();
        private readonly string xmlFilnamn = "poddar.xml"; // Fil där poddar sparas

        public void addPodcast(Podcast podd)
        {
            poddLista.Add(podd);
        }

        public void removePodcast(Podcast podd)
        {
            poddLista.Remove(podd);
        }

        public List<Podcast> getAllPodcasts()
        {
            return poddLista;
        }

        
        public void SparaTillFil()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Create))
            {
                serializer.Serialize(fs, poddLista);
            }
        }


        public void LäsFrånFil()
        {
            if (File.Exists(xmlFilnamn))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Open))
                {
                    poddLista = (List<Podcast>)serializer.Deserialize(fs);
                }
            }
        }
    }
}
