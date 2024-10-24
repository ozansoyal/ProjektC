﻿using Datalagring;
using Models;
using System.Xml;
using System.ServiceModel.Syndication;

namespace BL
{
    public class PoddController
    {
        private PoddRepository poddRepository;
        
        public PoddController()
        {
            poddRepository = new PoddRepository();
        }

        public List<Podcast> getAllPodcasts()
        {
            return poddRepository.getAllPodcasts();
        }

        public void getFromRss(string rssLink)
        {
            XmlReaderSettings settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Parse
            };

            using (XmlReader myXmlReader = XmlReader.Create(rssLink, settings))
            {
                SyndicationFeed poddFeed = SyndicationFeed.Load(myXmlReader);

                // Podcast title
                string podcastTitle = poddFeed.Title.Text;
                string podcastDesc = poddFeed.Description.Text;

                // Collect all episodes
                List<Episode> episodes = new List<Episode>();

                foreach (SyndicationItem item in poddFeed.Items)
                {
                    string episodeTitle = item.Title?.Text ?? "No Title";
                    string episodeDescription = item.Summary?.Text ?? "No Description";
                    DateTimeOffset episodePublishDate = item.PublishDate;
                    string episodeLink = item.Links.FirstOrDefault()?.Uri.ToString() ?? "No Link";
                    var durationElement = item.ElementExtensions
                                 .FirstOrDefault(ext => ext.OuterName == "duration");
                    string episodeDuration = durationElement?.GetObject<XmlElement>().InnerText ?? "No Duration";

                    Episode episode = new Episode(
                        episodeTitle,
                        episodeDescription,
                        episodePublishDate,
                        episodeLink,
                        episodeDuration
                    );

                    episodes.Add(episode);
                }

                Podcast aPodcast = new Podcast(podcastTitle, episodes, podcastDesc);
                poddRepository.addPodcast(aPodcast);
            }
        }

    }
}
