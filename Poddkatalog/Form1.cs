using BL;
using Datalagring;
using Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace PodcastCatalogue
{
    public partial class Form1 : Form
    {

        PoddController poddController;

        //Validering validering
        private Validator validator;
        private PoddRepository poddRepository;
        private List<Podcast> podds;

        public Form1()
        {
            InitializeComponent();
            validator = new Validator();
            poddController = new PoddController();
            poddRepository = new PoddRepository();

            // Hook up the event
            podcastDataGrid.SelectionChanged += podcastDataGrid_SelectionChanged;
            episodeDataGrid.SelectionChanged += episodeDataGrid_SelectionChanged;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = poddSearchField.Text;
            validator.ValidateSearchInput(text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void RefreshPodcastDataGrid()
        {
            podds = poddRepository.LäsFrånFil();
            podcastDataGrid.DataSource = null;
            podcastDataGrid.DataSource = podds;
            if (episodeDataGrid.Columns.Count > 0)
            {
                episodeDataGrid.Columns["Description"].Visible = false;
            }
        }





        private void rssLinkSubmitBtn_Click(object sender, EventArgs e)
        {
            string link = rssInputField.Text.Trim();
            if (validator.ValidateRssLink(link))
            {
                poddRepository.addPodcast(poddController.getFromRss(link)); //Lägger till i listan
                RefreshPodcastDataGrid();

            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

       


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Hardcoded RSS links, till för att testa
            //string rssLink = "https://api.sr.se/api/rss/pod/itunes/34530";
            //poddController.getFromRss(rssLink);
            //rssLink = "https://feed.pod.space/thisis40";
            //poddController.getFromRss(rssLink);
            podds = poddRepository.LäsFrånFil();          //första som måste ske är att vi läser från filen, annars riskerar vi att förlora all data

            RefreshPodcastDataGrid();
            
            
        }





        private void podcastDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (podcastDataGrid.CurrentRow.Index != 0)
            {
                Podcast selectedPodcast = (Podcast)podcastDataGrid.CurrentRow.DataBoundItem;
                if (selectedPodcast != null)
                {
                    episodeDataGrid.DataSource = selectedPodcast.Episode;

                    // Remove everything between <a> and </a> including the tags
                    string desc = selectedPodcast.Description;
                    desc = System.Text.RegularExpressions.Regex.Replace(desc, @"<a[^>]*>.*?</a>", "", System.Text.RegularExpressions.RegexOptions.Singleline).Trim();

                    // Remove specific HTML tags including <br>, <hr>, <p style="...">
                    string[] phrasesToRemove = new string[] { "<div>", "</div>", "<br>", "<hr>" };
                    foreach (string phrase in phrasesToRemove)
                    {
                        desc = desc.Replace(phrase, "").Trim();
                    }

                    // Remove <p style="..."> tags
                    desc = System.Text.RegularExpressions.Regex.Replace(desc, @"<p[^>]*>", "").Trim();

                    podcastDesc.Text = desc;
                }
            }
        }





        private void episodeDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (episodeDataGrid.CurrentRow != null)
            {

                Episode selectedEpisode = (Episode)episodeDataGrid.CurrentRow.DataBoundItem;
                if (selectedEpisode != null)
                {
                    //istället för att lägga in den direkt

                    //TODO
                    //tag bort allt mellan <a> och </a> inkluderar <a> och </a>

                    string desc = selectedEpisode.Description;
                    string[] phrasesToRemove = new string[] { "<div>", "</div>", "<p>", "</p>" };

                    foreach (string phrase in phrasesToRemove)
                    {
                        desc = desc.Replace(phrase, "").Trim();
                    }

                    episodeDesc.Text = desc;
                }
            }
        }



        private void podcastDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editWindowBtn_Click(object sender, EventArgs e)
        {
            try { 
            Podcast selectedPodcast = (Podcast)podcastDataGrid.CurrentRow.DataBoundItem;
            if (selectedPodcast != null)
            {
                if (selectedPodcast != null)
                {
                    Form2 form2 = new Form2(selectedPodcast, poddRepository, this);
                    form2.Show();
                }

            }
            }
            catch(Exception ex) {
                MessageBox.Show("Error: Podcast lista är tom");
            }
        }

        private void episodeDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void episodeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void podcastDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

