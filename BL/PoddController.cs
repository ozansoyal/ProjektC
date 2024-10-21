using Datalagring;
using Models;
using System.Xml;
using System.ServiceModel.Syndication;

namespace BL
{
    /// <summary>
    /// Klass som med hjälp av andra klasser och XML hämtar själva datan från RSS och sparar det i 
    /// en repository.
    /// </summary>
    public class PoddController
    {
        private PoddRepository poddRepository;

        public PoddController()
        {
            //konstruera en PoddRepository
            poddRepository = new PoddRepository();
        }

        public List<Podd> HämtaAllaPoddar()
        {
            return poddRepository.HämtaAllaPoddar();
        }

        public void getFromRss(string rssLink)
        {
            XmlReader myXmlReader = XmlReader.Create(rssLink);
            SyndicationFeed poddFeed = SyndicationFeed.Load(myXmlReader);

            foreach (SyndicationItem item in poddFeed.Items)
            {
                Podd aPod = new Podd
                {
                    Id = item.Id.ToString(),
                    Rubrik = item.Title.Text

                    //dataGridView.Rows.Add(item.Title.Text, item.Links[0].Uri.ToString());     eller liknande

                };
                poddRepository.LäggTillPodd(aPod);
            }
        }

    }
}