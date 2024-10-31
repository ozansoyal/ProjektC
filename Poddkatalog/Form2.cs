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
        private string category;

        public Form2(Podcast podcast, PoddRepository poddRepository, Form1 mainForm)
        {
            this.podcast = podcast;
            this.poddRepository = poddRepository;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void commitChangesBtn_Click(object sender, EventArgs e)
        {
            podcast.Name = textBox1.Text;
            podcast.Category = category;
            poddRepository.UpdatePodcast(podcast);
            MessageBox.Show("Changes saved.");
            mainForm.RefreshPodcastDataGrid();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            podcastNameLabel.Text = podcast.Title;

            var appData = poddRepository.ReadFromFile();
            var categories = appData.Categories;

            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
        }

        private async void removePodcastBtn_Click(object sender, EventArgs e)
        {
            await RemovePodcastAndUpdateGrid();
        }

        private async Task RemovePodcastAndUpdateGrid()
        {
            try
            {
                string podcastTitle = podcast.Title;
                await poddRepository.RemovePodcastByTitleAsync(podcastTitle);
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

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selectedCategory = categoryComboBox.SelectedItem as Category;
            if (selectedCategory != null)
            {
                category = selectedCategory.Name;
            }
        }
    }
}
