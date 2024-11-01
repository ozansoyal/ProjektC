using BL;
using Datalagring;
using Models;

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
            podcastDataGrid.ClearSelection();

            podcastDataGrid.Columns["Title"].Width = 240;
            podcastDataGrid.Columns["Name"].Width = 240;

            if (podcastDataGrid.Columns["Description"] != null)
            {
                podcastDataGrid.Columns["Description"].Visible = false;
            }
            if (episodeDataGrid.Columns.Count > 0)
            {
                episodeDataGrid.Columns["Description"].Visible = false;
            }
        }


        private void rssLinkSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string link = rssInputField.Text.Trim();
                if (validator.ValidateRssLink(link))
                {
                    poddRepository.AddPodcast(poddController.getFromRss(link)); //Lägger till i listan
                    RefreshPodcastDataGrid();

                }
                else
                {
                    MessageBox.Show("Se över länk");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: kunde inte hämta från RSS, se över länk");
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

            categories.Insert(0, new Category { Name = "Visa alla" });

            RefreshPodcastDataGrid();
            podcastDataGrid.Columns["Description"].Visible = false;


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
                    string desc = selectedEpisode.Description;

                    //tag bort <> och allt däri
                    desc = System.Text.RegularExpressions.Regex.Replace(desc, "<.*?>", "").Trim();

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

                podcastDataGrid.Columns["Title"].Width = 240;
                podcastDataGrid.Columns["Name"].Width = 240;

                if (podcastDataGrid.Columns["Description"] != null)
                {
                    podcastDataGrid.Columns["Description"].Visible = false;
                }
                if (episodeDataGrid.Columns.Count > 0)
                {
                    if (episodeDataGrid.Columns["Description"] != null)
                    {
                        episodeDataGrid.Columns["Description"].Visible = false;
                    }
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

                        string desc = selectedPodcast.Description;

                        //tag bort <> och allt däri
                        desc = System.Text.RegularExpressions.Regex.Replace(desc, "<.*?>", "").Trim();

                        podcastDesc.Text = desc;
                        episodeDataGrid.Columns["Description"].Visible = false;
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
            }
        }


        private void FilterPodcastsByTitle(string title)
        {
            if (podds != null && podds.Count > 0)
            {
                var filteredPodcasts = podds
                    .Where(p => p.Title != null && p.Title.ToLower().Contains(title.ToLower()))
                    .ToList();

                podcastDataGrid.DataSource = null;
                podcastDataGrid.DataSource = filteredPodcasts;

                podcastDataGrid.Columns["Title"].Width = 240;
                podcastDataGrid.Columns["Name"].Width = 240;

                if (podcastDataGrid.Columns["Description"] != null)
                {
                    podcastDataGrid.Columns["Description"].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No podcasts available to filter.");
            }
        }

        private void FilterEpisodeByTitle(string title)
        {
            if (podds != null && podds.Count > 0)
            {
                var trimmedTitle = title.Trim();

                var filteredEpisodes = podds
                    .Where(p => p.Episode != null)
                    .SelectMany(p => p.Episode)
                    .Where(e => e.Title != null && e.Title.Trim().ToLower().Contains(trimmedTitle.ToLower()))
                    .ToList();

                episodeDataGrid.DataSource = null;
                episodeDataGrid.DataSource = filteredEpisodes;

                if (episodeDataGrid.Columns["Description"] != null)
                {
                    episodeDataGrid.Columns["Description"].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No episodes available to filter.");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addCategoryTextbox.Text.Trim()))
            {
                MessageBox.Show("Category name cannot be empty");
                return;
            }
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

        private void FilterPodcastsByCategory(string categoryName)
        {
            if (podds != null && podds.Count > 0)
            {
                var filteredPodcasts = podds
                    .Where(p => p.Category != null && p.Category.Equals(categoryName, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                podcastDataGrid.DataSource = null;
                podcastDataGrid.DataSource = filteredPodcasts;
            }
            else
            {
                MessageBox.Show("No podcasts available to filter.");
            }
        }

        private void availableCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem != null && categoryComboBox.SelectedItem is Category selectedCategory)
            {
                if (selectedCategory.Name == "Visa alla")
                {
                    RefreshPodcastDataGrid();
                }
                else
                {
                    FilterPodcastsByCategory(selectedCategory.Name);
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid category selected.");
            }
        }

        private void RefreshComboBox()
        {
            var categories = poddRepository.ReadFromFile().Categories;

            categoryComboBox.DataSource = null;
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox3.Text;
            FilterEpisodeByTitle(searchText);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

