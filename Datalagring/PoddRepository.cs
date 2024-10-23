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


            public void SparaTillFil(List<Podcast> podds)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Create))
                {
                    serializer.Serialize(fs, podds);
                }
            }

        public List<Podcast> LäsFrånFil()
        {
            if (File.Exists(xmlFilnamn))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
                    using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Open))
                    {
                        poddLista = (List<Podcast>)serializer.Deserialize(fs);
                    }

                    if (poddLista == null || poddLista.Count == 0)
                    {
                        Console.WriteLine("Deserialization resulted in an empty list.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            return poddLista; // Return the read list
        }

    }
}



