using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PodcastCatalogue
{
 
        internal class Validator
        {
            public Validator() { 
        
        }
            
            public bool ValidateRssLink(string link)
            {
                try
                {
                    XmlReader myXmlReader = XmlReader.Create(link);
                    SyndicationFeed poddFeed = SyndicationFeed.Load(myXmlReader);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
       
            public bool ValidateSearchInput(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }
            return true;
        }
    
    
    }




    }


