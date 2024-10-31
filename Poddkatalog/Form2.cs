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
            poddRepository.UpdatePodcast(podcast);
            MessageBox.Show("Changes saved.");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            podcastNameLabel.Text = podcast.Title;
        }

        private async void removePodcastBtn_Click(object sender, EventArgs e)
        {
            await RemovePodcastAsync();
        }
        private async Task RemovePodcastAsync()
        {
            try
            {
                string podcastTitle = podcast.Title;
                await poddRepository.RemovePodcastAsync(podcast);
                await mainForm.RefreshPodcastDataGridAsync();

                mainForm.podcastDataGrid.ClearSelection();

                MessageBox.Show($"{podcastTitle} has been removed.");
                await mainForm.SetEpisodeDatagridNull();
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }
    }
}
