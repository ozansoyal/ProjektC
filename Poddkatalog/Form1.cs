using BL;
using Datalagring;
using Models;
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

            // Hook up the event
            podcastDataGrid.SelectionChanged += podcastDataGrid_SelectionChanged;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = poddSearchField.Text;
            validator.ValidateSearchInput(text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rssLinkSubmitBtn_Click(object sender, EventArgs e)
        {
            string link = rssInputField.Text;
            MessageBox.Show(link);

            //link skall valideras
            //validering.valideraLank(link);

            if (validator.ValidateRssLink(link))
            {
                poddController.getFromRss(link);
                //Hamnar i poddRepository.poddLista;
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
            // Hardcoded RSS links, till för att testa
            string rssLink = "https://api.sr.se/api/rss/pod/itunes/34530";
            poddController.getFromRss(rssLink);
            rssLink = "https://feed.pod.space/thisis40";
            poddController.getFromRss(rssLink);

            List<Podcast> podds = poddController.getAllPodcasts();
            podcastDataGrid.DataSource = podds;  // Set the data source directly
        }

        private void podcastDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (podcastDataGrid.CurrentRow != null)
            {
                Podcast selectedPodcast = (Podcast)podcastDataGrid.CurrentRow.DataBoundItem;
                if (selectedPodcast != null)
                {
                    episodeDataGrid.DataSource = selectedPodcast.Episode;

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
    }
}

