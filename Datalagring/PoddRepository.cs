    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;
    using Models;

    namespace Datalagring
    {
        public class PoddRepository
        {
            private List<Podcast> podcastList = new List<Podcast>();
            private readonly string xmlFilnamn = "poddar.xml"; // Fil där poddar sparas
            public bool podcastAdded = false;

        public void addPodcast(Podcast podd)
        {

            if (podcastList.Count == 0)
            {
                podcastList.Add(podd);
                SparaTillFil(podcastList);
            }
            else { 
            foreach (Podcast p in podcastList)
            {
                if (p.Title == podd.Title)
                {
                    throw new Exception("Podcast already exists.");
                }
                else
                {
                    podcastList.Add(podd);
                    SparaTillFil(podcastList);
                        podcastAdded = true;
                }
                    if (podcastAdded == true) { break; }
                }
            }
        }

            public void removePodcast(Podcast podd)
            {
                podcastList.Remove(podd);
            }

            public List<Podcast> getPodcastList()
            {
                return podcastList;
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
                        podcastList = (List<Podcast>)serializer.Deserialize(fs);
                    }

                    if (podcastList == null || podcastList.Count == 0)
                    {
                        Console.WriteLine("Deserialization resulted in an empty list.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                    using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Create)) ;

                }
            }
            else
            {
                using (FileStream fs = new FileStream(xmlFilnamn, FileMode.Create)) ;
            }

            return podcastList; // Return the read list
        }

    }
     
}




