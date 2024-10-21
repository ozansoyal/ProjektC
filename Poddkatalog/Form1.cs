using BL;
using Models;
using System.Windows.Forms;

namespace Poddkatalog
{
    public partial class Form1 : Form
    {

        PoddController poddController;
        //Validering validering
        public Form1()
        {
            poddController = new PoddController();
            //validering = new Validering();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

            if (link != null)
            {
                poddController.getFromRss(link);
                //Hamnar i poddRepository.poddLista;
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
