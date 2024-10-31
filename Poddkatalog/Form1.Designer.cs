using System.Windows.Forms;

namespace PodcastCatalogue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            podcastDataGrid = new DataGridView();
            rssLinkSubmitBtn = new Button();
            searchPodcastBtn = new Button();
            searchEpisodeBtn = new Button();
            editWindowBtn = new Button();
            poddSearchField = new TextBox();
            rssInputField = new TextBox();
            episodeDataGrid = new DataGridView();
            textBox3 = new TextBox();
            podcastDesc = new TextBox();
            episodeDesc = new TextBox();
            categoryComboBox = new ComboBox();
            addCategoryTextbox = new TextBox();
            addCategoryBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)podcastDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)episodeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // podcastDataGrid
            // 
            podcastDataGrid.AllowUserToAddRows = false;
            podcastDataGrid.AllowUserToDeleteRows = false;
            podcastDataGrid.AllowUserToResizeColumns = false;
            podcastDataGrid.AllowUserToResizeRows = false;
            podcastDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            podcastDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            podcastDataGrid.Location = new Point(68, 251);
            podcastDataGrid.Margin = new Padding(6);
            podcastDataGrid.MultiSelect = false;
            podcastDataGrid.Name = "podcastDataGrid";
            podcastDataGrid.ReadOnly = true;
            podcastDataGrid.RowHeadersVisible = false;
            podcastDataGrid.RowHeadersWidth = 82;
            podcastDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            podcastDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            podcastDataGrid.Size = new Size(639, 403);
            podcastDataGrid.TabIndex = 0;
            podcastDataGrid.CellContentClick += podcastDataGrid_CellContentClick;
            // 
            // rssLinkSubmitBtn
            // 
            rssLinkSubmitBtn.Location = new Point(723, 93);
            rssLinkSubmitBtn.Margin = new Padding(6);
            rssLinkSubmitBtn.Name = "rssLinkSubmitBtn";
            rssLinkSubmitBtn.Size = new Size(139, 49);
            rssLinkSubmitBtn.TabIndex = 1;
            rssLinkSubmitBtn.Text = "Lägg till";
            rssLinkSubmitBtn.UseVisualStyleBackColor = true;
            rssLinkSubmitBtn.Click += rssLinkSubmitBtn_Click;
            // 
            // searchPodcastBtn
            // 
            searchPodcastBtn.Location = new Point(511, 176);
            searchPodcastBtn.Margin = new Padding(6);
            searchPodcastBtn.Name = "searchPodcastBtn";
            searchPodcastBtn.Size = new Size(139, 49);
            searchPodcastBtn.TabIndex = 2;
            searchPodcastBtn.Text = "Sök";
            searchPodcastBtn.UseVisualStyleBackColor = true;
            searchPodcastBtn.Click += button2_Click;
            // 
            // searchEpisodeBtn
            // 
            searchEpisodeBtn.Location = new Point(1292, 181);
            searchEpisodeBtn.Margin = new Padding(6);
            searchEpisodeBtn.Name = "searchEpisodeBtn";
            searchEpisodeBtn.Size = new Size(139, 49);
            searchEpisodeBtn.TabIndex = 3;
            searchEpisodeBtn.Text = "Sök avs";
            searchEpisodeBtn.UseVisualStyleBackColor = true;
            // 
            // editWindowBtn
            // 
            editWindowBtn.Cursor = Cursors.Hand;
            editWindowBtn.Location = new Point(662, 176);
            editWindowBtn.Margin = new Padding(6);
            editWindowBtn.Name = "editWindowBtn";
            editWindowBtn.Size = new Size(139, 49);
            editWindowBtn.TabIndex = 4;
            editWindowBtn.Text = "Edit";
            editWindowBtn.UseVisualStyleBackColor = true;
            editWindowBtn.Click += editWindowBtn_Click;
            // 
            // poddSearchField
            // 
            poddSearchField.Location = new Point(68, 176);
            poddSearchField.Margin = new Padding(6);
            poddSearchField.Name = "poddSearchField";
            poddSearchField.Size = new Size(403, 39);
            poddSearchField.TabIndex = 5;
            poddSearchField.TextChanged += poddSearchField_TextChanged;
            // 
            // rssInputField
            // 
            rssInputField.Location = new Point(68, 93);
            rssInputField.Margin = new Padding(6);
            rssInputField.Name = "rssInputField";
            rssInputField.Size = new Size(622, 39);
            rssInputField.TabIndex = 6;
            rssInputField.TextChanged += textBox2_TextChanged;
            // 
            // episodeDataGrid
            // 
            episodeDataGrid.AllowUserToAddRows = false;
            episodeDataGrid.AllowUserToDeleteRows = false;
            episodeDataGrid.AllowUserToResizeColumns = false;
            episodeDataGrid.AllowUserToResizeRows = false;
            episodeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            episodeDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            episodeDataGrid.Location = new Point(866, 251);
            episodeDataGrid.Margin = new Padding(6);
            episodeDataGrid.MultiSelect = false;
            episodeDataGrid.Name = "episodeDataGrid";
            episodeDataGrid.ReadOnly = true;
            episodeDataGrid.RowHeadersVisible = false;
            episodeDataGrid.RowHeadersWidth = 82;
            episodeDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            episodeDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            episodeDataGrid.Size = new Size(637, 403);
            episodeDataGrid.TabIndex = 7;
            episodeDataGrid.CellContentClick += episodeDataGrid_CellContentClick;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(866, 181);
            textBox3.Margin = new Padding(6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(388, 39);
            textBox3.TabIndex = 8;
            // 
            // podcastDesc
            // 
            podcastDesc.BackColor = Color.White;
            podcastDesc.Enabled = false;
            podcastDesc.Location = new Point(76, 700);
            podcastDesc.Multiline = true;
            podcastDesc.Name = "podcastDesc";
            podcastDesc.ReadOnly = true;
            podcastDesc.Size = new Size(631, 195);
            podcastDesc.TabIndex = 9;
            podcastDesc.TextChanged += podcastDesc_TextChanged;
            // 
            // episodeDesc
            // 
            episodeDesc.BackColor = Color.White;
            episodeDesc.Cursor = Cursors.IBeam;
            episodeDesc.Enabled = false;
            episodeDesc.Location = new Point(866, 700);
            episodeDesc.Multiline = true;
            episodeDesc.Name = "episodeDesc";
            episodeDesc.ReadOnly = true;
            episodeDesc.Size = new Size(631, 195);
            episodeDesc.TabIndex = 10;
            episodeDesc.TextChanged += episodeDesc_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(891, 98);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(276, 40);
            categoryComboBox.TabIndex = 11;
            categoryComboBox.SelectedIndexChanged += availableCategories_SelectedIndexChanged;
            // 
            // addCategoryTextbox
            // 
            addCategoryTextbox.Location = new Point(1188, 98);
            addCategoryTextbox.Name = "addCategoryTextbox";
            addCategoryTextbox.Size = new Size(200, 39);
            addCategoryTextbox.TabIndex = 12;
            addCategoryTextbox.TextChanged += textBox1_TextChanged;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.Location = new Point(1406, 94);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(240, 46);
            addCategoryBtn.TabIndex = 13;
            addCategoryBtn.Text = "Lägg till kategori";
            addCategoryBtn.UseVisualStyleBackColor = true;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1172);
            Controls.Add(addCategoryBtn);
            Controls.Add(addCategoryTextbox);
            Controls.Add(categoryComboBox);
            Controls.Add(episodeDesc);
            Controls.Add(podcastDesc);
            Controls.Add(textBox3);
            Controls.Add(episodeDataGrid);
            Controls.Add(rssInputField);
            Controls.Add(poddSearchField);
            Controls.Add(editWindowBtn);
            Controls.Add(searchEpisodeBtn);
            Controls.Add(searchPodcastBtn);
            Controls.Add(rssLinkSubmitBtn);
            Controls.Add(podcastDataGrid);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)podcastDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)episodeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView podcastDataGrid;
        private Button rssLinkSubmitBtn;
        private Button searchPodcastBtn;
        private Button searchEpisodeBtn;
        private Button editWindowBtn;
        private TextBox poddSearchField;
        private TextBox rssInputField;
        private DataGridView episodeDataGrid;
        private TextBox textBox3;
        private TextBox podcastDesc;
        private TextBox episodeDesc;
        private ComboBox categoryComboBox;
        private TextBox addCategoryTextbox;
        private Button addCategoryBtn;
    }
}
