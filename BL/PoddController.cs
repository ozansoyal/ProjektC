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
            return poddRepository.getAllPodcasts();
        }

        public void getFromRss(string rssLink)
        {
            XmlReader myXmlReader = XmlReader.Create(rssLink);
            SyndicationFeed poddFeed = SyndicationFeed.Load(myXmlReader);

            // Podcast title
            string podcastTitle = poddFeed.Title.Text;

            // Collect all episodes
            List<Episode> episodes = new List<Episode>();

            foreach (SyndicationItem item in poddFeed.Items)
            {
                // Vad vi sparar och sen kan ta ut. Hittas ej data lägg till ??
                // Vi kan välja vilken data vi vill ha kvar, detta är rätt maximerat.
                string episodeId = item.Id ?? "N/A";
                string episodeTitle = item.Title?.Text ?? "No Title";
                string episodeDescription = item.Summary?.Text ?? "No Description";
                DateTimeOffset episodePublishDate = item.PublishDate;
                string episodeLink = item.Links.FirstOrDefault()?.Uri.ToString() ?? "No Link";
                string episodeAuthor = item.Authors.FirstOrDefault()?.Name ?? "Unknown Author";

                Episode episode = new Episode(
                    episodeId,
                    episodeTitle,
                    episodeDescription,
                    episodePublishDate,
                    episodeLink,
                    episodeAuthor
                );

                episodes.Add(episode);
            }

        
            Podcast aPodcast = new Podcast(podcastTitle, episodes);

            poddRepository.addPodcast(aPodcast);
        }

    }
}
