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

        public Form2(Podcast podcast, PoddRepository poddRepository)
        {
            this.podcast = podcast;
            this.poddRepository = poddRepository;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            podcast.Title = textBox1.Text;
            podcast.Category = textBox2.Text;
            MessageBox.Show("Changes saved.");
        }

        private void removePodcastBtn_Click(object sender, EventArgs e)
        {
            poddRepository.removePodcast(podcast);
            MessageBox.Show($"{podcast.Title} has been removed.");
            Form2.ActiveForm.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
