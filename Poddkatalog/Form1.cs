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

        private Validator validator;
        private PoddRepository poddRepository;
        private List<Podcast> podds;
        private List<Category> categories;

        public Form1()
        {
            InitializeComponent();
            validator = new Validator();
            poddController = new PoddController();
            poddRepository = new PoddRepository();

            podcastDataGrid.SelectionChanged += podcastDataGrid_SelectionChanged;
            episodeDataGrid.SelectionChanged += episodeDataGrid_SelectionChanged;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = poddSearchField.Text;
            validator.ValidateSearchInput(text);
        }

        private void poddSearchField_TextChanged(object sender, EventArgs e)
        {
            string searchText = poddSearchField.Text;
            FilterPodcastsByTitle(searchText);
        }

        public void RefreshPodcastDataGrid()
        {
            var appData = poddRepository.ReadFromFile();
            podds = appData.Podcasts;
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
                poddRepository.AddPodcast(poddController.getFromRss(link)); //Lägger till i listan
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
            var appData = poddRepository.ReadFromFile();
            podds = appData.Podcasts;
            var categories = appData.Categories;

            RefreshPodcastDataGrid();

            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name"; 
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
            try
            {
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
            catch (Exception ex)
            {
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
        public async Task SetEpisodeDatagridNull()
        {
            episodeDataGrid.DataSource = null;
            podcastDesc.Clear();
            episodeDesc.Clear();

        }

        public async Task RefreshPodcastDataGridAsync()
        {
            try
            {
                podcastDataGrid.SelectionChanged -= podcastDataGrid_SelectionChanged;
                var appData = await poddRepository.ReadFromFileAsync();
                List<Podcast> podds = appData.Podcasts;
                podcastDataGrid.DataSource = null;
                podcastDataGrid.DataSource = podds;
                podcastDataGrid.ClearSelection();
                if (episodeDataGrid.Columns.Count > 0)
                {
                    episodeDataGrid.Columns["Description"].Visible = false;
                }
            }
            finally
            {
                podcastDataGrid.SelectionChanged += podcastDataGrid_SelectionChanged;
            }
        }

        private void podcastDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (podcastDataGrid.Rows.Count > 0 && podcastDataGrid.CurrentRow != null)
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
                else
                {
                    episodeDataGrid.DataSource = null;
                    podcastDesc.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }

        private void FilterPodcastsByTitle(string title)
        {
            if (podds != null && podds.Count > 0)
            {
                var filteredPodcasts = podds
                    .Where(p => p.Title != null && p.Title.ToLower().Contains(title.ToLower()))
                    .ToList(); // Execute the query

                podcastDataGrid.DataSource = null; // Clear existing data source
                podcastDataGrid.DataSource = filteredPodcasts; // Set new data source
            }
            else
            {
                MessageBox.Show("No podcasts available to filter.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            if (poddRepository.ReadFromFile().Categories.Count == 0)
            {
                Category category = new Category(addCategoryTextbox.Text.Trim());
                poddRepository.AddCategory(category);
            }
            else
            {
                foreach (Category c in poddRepository.ReadFromFile().Categories)
                {
                    if (c.Name == addCategoryTextbox.Text.Trim())
                    {
                        MessageBox.Show("Category already exists");
                        return;
                    }
                }
                Category category = new Category(addCategoryTextbox.Text.Trim());
                poddRepository.AddCategory(category);
                RefreshComboBox();
            }



        }

        private void availableCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void RefreshComboBox()
        {
            var categories = poddRepository.ReadFromFile().Categories;
            categoryComboBox.DataSource = null;
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
            
        }

        


    }
}

