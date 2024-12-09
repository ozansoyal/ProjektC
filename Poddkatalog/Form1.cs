using BL;
using Datalagring;
using Models;
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
                MessageBox.Show("Kunde inte hämta från RSS, se över länk");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var appData = poddRepository.ReadFromFile();
            podds = appData.Podcasts;
            var categories = appData.Categories;



            RefreshPodcastDataGrid();
            podcastDataGrid.Columns["Description"].Visible = false;


            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
            RefreshCategoryListBox();
            visaAlla();


        }

        private void RefreshCategoryListBox()
        {
            var categories = poddRepository.ReadFromFile().Categories;

            categoryListBox.Items.Clear();
            foreach (var category in categories)
            {
                categoryListBox.Items.Add(category.Name);
            }
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
                MessageBox.Show("Podcast lista är tom");
            }
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
                MessageBox.Show("Inga podcasts att filtrera.");
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
                MessageBox.Show("Inga avsnitt att filtrera.");
            }
        }




        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addCategoryTextbox.Text.Trim()))
            {
                MessageBox.Show("Kategori namn får ej vara tomt");
                return;
            }

            var categories = poddRepository.ReadFromFile().Categories;

            if (categories.Any(c => c.Name.Equals(addCategoryTextbox.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Kategori finns redan");
                return;
            }

            Category category = new Category(addCategoryTextbox.Text.Trim());
            poddRepository.AddCategory(category);
            RefreshCategoriesWithVisaAlla();

        }

        private void RefreshCategoriesWithVisaAlla()
        {
            var categories = poddRepository.ReadFromFile().Categories;

            categoryComboBox.DataSource = null;
            categoryListBox.Items.Clear();

            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";

            foreach (var category in categories)
            {
                categoryListBox.Items.Add(category.Name);
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
                MessageBox.Show("Finns ej podcast med vald kategori.");
            }
        }

        private void availableCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem != null && categoryComboBox.SelectedItem is Category selectedCategory)
            {
                //if (selectedCategory.Name == "Visa alla")
                //{
                //    RefreshPodcastDataGrid();
                //}
                //else
                //{
                FilterPodcastsByCategory(selectedCategory.Name);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Error: Invalid category selected.");
                //}
            }
        }

        private void RefreshComboBox()
        {
            var categories = poddRepository.ReadFromFile().Categories;

            categoryComboBox.DataSource = null;
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
        }

        private void episodeSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = episodeSearchTextBox.Text;
            FilterEpisodeByTitle(searchText);
        }



        private void removeCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryListBox.SelectedItem != null)
                {
                    string selectedCategoryName = categoryListBox.SelectedItem.ToString();

                    var confirmationResult = MessageBox.Show(
                        $"Tag bort '{selectedCategoryName}'?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmationResult == DialogResult.Yes)
                    {
                        var appData = poddRepository.ReadFromFile();
                        var categoryToRemove = appData.Categories.FirstOrDefault(c => c.Name.Equals(selectedCategoryName, StringComparison.OrdinalIgnoreCase));

                        if (categoryToRemove != null)
                        {
                            poddRepository.RemoveCategory(categoryToRemove);

                            RefreshCategoryListBox();
                            RefreshComboBox();
                            RefreshPodcastDataGrid();

                            MessageBox.Show("Kategori borttagen.");
                        }
                        else
                        {
                            MessageBox.Show("Kategori finns ej.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Välj en kategori.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kunde inte ta bort kategori");
            }
        }

        private void renameCategoryBtn_Click_1(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem == null)
            {
                MessageBox.Show("Välj en kategori.");
                return;
            }

            string newCategoryName = categoryNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCategoryName))
            {
                MessageBox.Show("Välj en kategori.");
                return;
            }

            string selectedCategoryName = categoryListBox.SelectedItem.ToString();

            var appData = poddRepository.ReadFromFile();
            var categories = appData.Categories;
            var podcasts = appData.Podcasts;

            var categoryToRename = categories.FirstOrDefault(c => c.Name.Equals(selectedCategoryName, StringComparison.OrdinalIgnoreCase));

            if (categoryToRename != null)
            {
                if (categories.Any(c => c.Name.Equals(newCategoryName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Finns redan en kategori med det namn.");
                    return;
                }

                categoryToRename.Name = newCategoryName;

                foreach (var podcast in podcasts)
                {
                    if (podcast.Category.Equals(selectedCategoryName, StringComparison.OrdinalIgnoreCase))
                    {
                        podcast.Category = newCategoryName;
                    }
                }

                poddRepository.SaveToFile(appData);

                RefreshCategoryListBox();
                RefreshComboBox();
                RefreshPodcastDataGrid();

                MessageBox.Show("Kategori har bytt namn.");
            }
            else
            {
                MessageBox.Show("Vald kategori hittades ej.");
            }
        }



        private void VisaAllaBtn_Click(object sender, EventArgs e)
        {
            visaAlla();
        }
        private void visaAlla()
        {
            try
            {
                categoryListBox.ClearSelected();
                categoryComboBox.SelectedIndex = -1;
                RefreshComboBox();
                RefreshCategoryListBox();
                RefreshPodcastDataGrid();
            }
            catch
            {
                MessageBox.Show("Visar redan alla podcast");
            }
        }

    }
}


