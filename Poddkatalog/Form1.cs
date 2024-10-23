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

        private void RefreshPodcastDataGrid(List<Podcast> podds)
        {
            podds = poddController.getAllPodcasts();
            podcastDataGrid.DataSource = null;
            podcastDataGrid.DataSource = podds;
            episodeDataGrid.Columns["Description"].Visible = false;

        }

        


        private void rssLinkSubmitBtn_Click(object sender, EventArgs e)
        {
            string link = rssInputField.Text.Trim();
            MessageBox.Show(link);
            if (validator.ValidateRssLink(link))
            {
                poddController.getFromRss(link);
                List<Podcast> podds = poddController.getAllPodcasts();
                RefreshPodcastDataGrid(podds);
                poddRepository.SparaTillFil();

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
            poddRepository.LäsFrånFil();
            // Hardcoded RSS links, till för att testa
            string rssLink = "https://api.sr.se/api/rss/pod/itunes/34530";
            poddController.getFromRss(rssLink);
            rssLink = "https://feed.pod.space/thisis40";
            poddController.getFromRss(rssLink);
            List<Podcast> podds = poddController.getAllPodcasts();

            RefreshPodcastDataGrid(podds);
        }

        



        private void podcastDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (podcastDataGrid.CurrentRow != null)
            {
                Podcast selectedPodcast = (Podcast)podcastDataGrid.CurrentRow.DataBoundItem;
                if (selectedPodcast != null)
                {
                    episodeDataGrid.DataSource = selectedPodcast.Episode;

                    //TODO
                    //tag bort allt mellan <a> och </a>

                    string desc = selectedPodcast.Description;
                    string[] phrasesToRemove = new string[] { "<div>", "</div>", "<p>", "</p>" };

                    foreach (string phrase in phrasesToRemove)
                    {
                        desc = desc.Replace(phrase, "").Trim();
                    }

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

            if (podcastDataGrid.CurrentRow != null)
            {
                Podcast selectedPodcast = (Podcast)podcastDataGrid.CurrentRow.DataBoundItem;
                if (selectedPodcast != null)
                {
                    Form2 form2 = new Form2(selectedPodcast, poddRepository);
                    form2.Show();
                }

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

