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

            // If necessary, update podcasts' categories here based on your specific needs.

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

            

            RefreshPodcastDataGrid();
            podcastDataGrid.Columns["Description"].Visible = false;


            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
            RefreshCategoryListBox();

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

            var categories = poddRepository.ReadFromFile().Categories;

            // Check if the category already exists
            if (categories.Any(c => c.Name.Equals(addCategoryTextbox.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Category already exists");
                return;
            }

            // Add the new category
            Category category = new Category(addCategoryTextbox.Text.Trim());
            poddRepository.AddCategory(category);
            RefreshCategoriesWithVisaAlla();

        }

        private void RefreshCategoriesWithVisaAlla()
        {
            // Read categories from the repository
            var categories = poddRepository.ReadFromFile().Categories;

            // Clear existing items
            categoryComboBox.DataSource = null;
            categoryListBox.Items.Clear();

            // Re-add "Visa alla" to the category list
            

            // Set the new data source for the combo box
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";

            // Refresh the list box
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
                MessageBox.Show("No podcasts available to filter.");
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem != null)
            {
                string selectedCategoryName = categoryListBox.SelectedItem.ToString();

                // Show confirmation dialog
                var confirmationResult = MessageBox.Show(
                    $"Are you sure you want to delete the category '{selectedCategoryName}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmationResult == DialogResult.Yes)
                {
                    var appData = poddRepository.ReadFromFile();
                    var categoryToRemove = appData.Categories.FirstOrDefault(c => c.Name.Equals(selectedCategoryName, StringComparison.OrdinalIgnoreCase));

                    if (categoryToRemove != null)
                    {
                        // Call to remove the category from the repository
                        poddRepository.RemoveCategory(categoryToRemove);

                        // Refresh both the category ListBox and the podcast DataGrid
                        RefreshCategoryListBox(); // Refresh the ListBox to show updated categories
                        RefreshComboBox(); // Refresh the ComboBox to remove the deleted category
                        RefreshPodcastDataGrid(); // Refresh the DataGrid to reflect the changes in podcasts

                        MessageBox.Show("Category deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Category not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a category to rename.");
                return;
            }

            string newCategoryName = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCategoryName))
            {
                MessageBox.Show("Category name cannot be empty.");
                return;
            }

            // Get the selected category
            string selectedCategoryName = categoryListBox.SelectedItem.ToString();

            // Find the category in the repository
            var categoryToRename = poddRepository.ReadFromFile().Categories
                .FirstOrDefault(c => c.Name.Equals(selectedCategoryName, StringComparison.OrdinalIgnoreCase));

            if (categoryToRename != null)
            {
                // Check if the new category name already exists
                if (poddRepository.ReadFromFile().Categories.Any(c => c.Name.Equals(newCategoryName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Category name already exists.");
                    return;
                }

                // Change the name of the selected category
                categoryToRename.Name = newCategoryName;

                // Save the updated categories
                poddRepository.SaveToFile(poddRepository.ReadFromFile()); // Ensure the changes are saved

                // Refresh UI components
                RefreshCategoryListBox();
                RefreshComboBox();

                // Optionally, refresh the podcast data grid if necessary
                RefreshPodcastDataGrid(); // To refresh podcasts with the updated category

                MessageBox.Show("Category renamed successfully.");
            }
            else
            {
                MessageBox.Show("Selected category not found.");
            }
        }




        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void VisaAllaBtn_Click(object sender, EventArgs e)
        {

            try { 
            categoryListBox.ClearSelected();
            categoryComboBox.SelectedIndex = -1;
                RefreshComboBox();
                RefreshCategoryListBox();
                RefreshPodcastDataGrid();
            }
            catch
            {
                MessageBox.Show("visar redan alla");
            }

        }
    }
}


