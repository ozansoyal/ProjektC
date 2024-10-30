using Datalagring;
using Models;
using System;
using System.Windows.Forms;

namespace PodcastCatalogue
{
    public partial class Form2 : Form
    {
        private Podcast podcast;
        private PoddRepository poddRepository;
        private Form1 mainForm;

        public Form2(Podcast podcast, PoddRepository poddRepository, Form1 mainForm)
        {
            this.podcast = podcast;
            this.poddRepository = poddRepository;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            podcast.Name = textBox1.Text;
            podcast.Category = textBox2.Text;
            MessageBox.Show("Changes saved.");
        }

        private void removePodcastBtn_Click(object sender, EventArgs e)
        {

            string podcastTitle = podcast.Title;
            poddRepository.removePodcast(podcast);
            mainForm.RefreshPodcastDataGrid();
            MessageBox.Show($"{podcastTitle} has been removed.");
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
