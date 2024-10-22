using BL;
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
       
        public Form1()
        {
            InitializeComponent();
            Validator validator = new Validator();
            poddController = new PoddController();
            //validering = new Validering();


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

            // Example RSS link
            string rssLink = "https://api.sr.se/api/rss/pod/itunes/34530";
            poddController.getFromRss(rssLink);

            List<Podcast> podds = poddController.getAllPodcasts();

            foreach (var podd in podds)
            {
                //podcastDataGrid.Rows.Add(podd.Title, podd.customTitle, podd.Episode.Count, podd.Category);
                podcastDataGrid.Rows.Add(podd.Title, podd.Category, podd.Episode.Count);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
