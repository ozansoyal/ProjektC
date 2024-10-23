using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Text.RegularExpressions;
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
            if (link.StartsWith("http") || link.StartsWith("https"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Rss feed has to start with http:// or https://");

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

        public bool ValidateAddCategory(string userInput)
        {
            string reg = "^[a-öA-Ö]+$";
            return Regex.IsMatch(userInput, reg);
        }
    
    
    }




    }


