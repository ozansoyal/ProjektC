using Datalagring;
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
            return poddRepository.GetPodcastList();
        }

        public Podcast getFromRss(string rssLink)
        {
            XmlReader myXmlReader = XmlReader.Create(rssLink);
            SyndicationFeed poddFeed = SyndicationFeed.Load(myXmlReader);

            string podcastTitle = poddFeed.Title.Text;
            string podcastDesc = poddFeed.Description.Text;

            List<Episode> episodes = new List<Episode>();

            foreach (SyndicationItem item in poddFeed.Items)
            {
                // Vad vi sparar och sen kan ta ut. Hittas ej data lägg till ??
                // Vi kan välja vilken data vi vill ha kvar, detta är rätt maximerat.
              
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

            return aPodcast;
        }

    }
}
