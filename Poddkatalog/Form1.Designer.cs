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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            categoryListBox = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            Redigera = new Button();
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
            podcastDataGrid.Location = new Point(69, 252);
            podcastDataGrid.Margin = new Padding(6);
            podcastDataGrid.MultiSelect = false;
            podcastDataGrid.Name = "podcastDataGrid";
            podcastDataGrid.ReadOnly = true;
            podcastDataGrid.RowHeadersVisible = false;
            podcastDataGrid.RowHeadersWidth = 82;
            podcastDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            podcastDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            podcastDataGrid.Size = new Size(853, 424);
            podcastDataGrid.TabIndex = 0;
            podcastDataGrid.CellContentClick += podcastDataGrid_CellContentClick;
            // 
            // rssLinkSubmitBtn
            // 
            rssLinkSubmitBtn.Location = new Point(703, 89);
            rssLinkSubmitBtn.Margin = new Padding(6);
            rssLinkSubmitBtn.Name = "rssLinkSubmitBtn";
            rssLinkSubmitBtn.Size = new Size(139, 49);
            rssLinkSubmitBtn.TabIndex = 1;
            rssLinkSubmitBtn.Text = "Lägg till";
            rssLinkSubmitBtn.UseVisualStyleBackColor = true;
            rssLinkSubmitBtn.Click += rssLinkSubmitBtn_Click;
            // 
            // editWindowBtn
            // 
            editWindowBtn.Cursor = Cursors.Hand;
            editWindowBtn.Location = new Point(783, 169);
            editWindowBtn.Margin = new Padding(6);
            editWindowBtn.Name = "editWindowBtn";
            editWindowBtn.Size = new Size(139, 49);
            editWindowBtn.TabIndex = 4;
            editWindowBtn.Text = "Ändra";
            editWindowBtn.UseVisualStyleBackColor = true;
            editWindowBtn.Click += editWindowBtn_Click;
            // 
            // poddSearchField
            // 
            poddSearchField.Location = new Point(69, 175);
            poddSearchField.Margin = new Padding(6);
            poddSearchField.Name = "poddSearchField";
            poddSearchField.Size = new Size(366, 39);
            poddSearchField.TabIndex = 5;
            poddSearchField.TextChanged += poddSearchField_TextChanged;
            // 
            // rssInputField
            // 
            rssInputField.Location = new Point(69, 94);
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
            episodeDataGrid.Location = new Point(985, 252);
            episodeDataGrid.Margin = new Padding(6);
            episodeDataGrid.MultiSelect = false;
            episodeDataGrid.Name = "episodeDataGrid";
            episodeDataGrid.ReadOnly = true;
            episodeDataGrid.RowHeadersVisible = false;
            episodeDataGrid.RowHeadersWidth = 82;
            episodeDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            episodeDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            episodeDataGrid.Size = new Size(853, 424);
            episodeDataGrid.TabIndex = 7;
            episodeDataGrid.CellContentClick += episodeDataGrid_CellContentClick;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(985, 185);
            textBox3.Margin = new Padding(6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(605, 39);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // podcastDesc
            // 
            podcastDesc.BackColor = Color.White;
            podcastDesc.Location = new Point(69, 700);
            podcastDesc.Margin = new Padding(4, 2, 4, 2);
            podcastDesc.Multiline = true;
            podcastDesc.Name = "podcastDesc";
            podcastDesc.ReadOnly = true;
            podcastDesc.ScrollBars = ScrollBars.Vertical;
            podcastDesc.Size = new Size(853, 402);
            podcastDesc.TabIndex = 9;
            podcastDesc.TextChanged += podcastDesc_TextChanged;
            // 
            // episodeDesc
            // 
            episodeDesc.BackColor = Color.White;
            episodeDesc.Location = new Point(985, 700);
            episodeDesc.Margin = new Padding(4, 2, 4, 2);
            episodeDesc.Multiline = true;
            episodeDesc.Name = "episodeDesc";
            episodeDesc.ReadOnly = true;
            episodeDesc.ScrollBars = ScrollBars.Vertical;
            episodeDesc.Size = new Size(853, 402);
            episodeDesc.TabIndex = 10;
            episodeDesc.TextChanged += episodeDesc_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(455, 174);
            categoryComboBox.Margin = new Padding(4, 2, 4, 2);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(318, 40);
            categoryComboBox.TabIndex = 11;
            categoryComboBox.SelectedIndexChanged += availableCategories_SelectedIndexChanged;
            // 
            // addCategoryTextbox
            // 
            addCategoryTextbox.Location = new Point(1389, 53);
            addCategoryTextbox.Margin = new Padding(4, 2, 4, 2);
            addCategoryTextbox.Name = "addCategoryTextbox";
            addCategoryTextbox.Size = new Size(201, 39);
            addCategoryTextbox.TabIndex = 12;
            addCategoryTextbox.TextChanged += textBox1_TextChanged;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.Location = new Point(1598, 49);
            addCategoryBtn.Margin = new Padding(4, 2, 4, 2);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(240, 47);
            addCategoryBtn.TabIndex = 13;
            addCategoryBtn.Text = "Lägg till kategori";
            addCategoryBtn.UseVisualStyleBackColor = true;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 56);
            label1.Name = "label1";
            label1.Size = new Size(294, 32);
            label1.TabIndex = 14;
            label1.Text = "Lägg till podcast med länk";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 139);
            label2.Name = "label2";
            label2.Size = new Size(268, 32);
            label2.TabIndex = 15;
            label2.Text = "Sök podcast efter namn";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 139);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 16;
            label3.Text = "Välj kategori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1071, 147);
            label4.Name = "label4";
            label4.Size = new Size(256, 32);
            label4.TabIndex = 17;
            label4.Text = "Sök episod efter namn";
            // 
            // categoryListBox
            // 
            categoryListBox.FormattingEnabled = true;
            categoryListBox.Location = new Point(1071, 12);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(240, 100);
            categoryListBox.TabIndex = 18;
            categoryListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(902, 7);
            button1.Name = "button1";
            button1.Size = new Size(150, 72);
            button1.TabIndex = 19;
            button1.Text = "Ta bort kategori";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(622, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // Redigera
            // 
            Redigera.Location = new Point(902, 79);
            Redigera.Name = "Redigera";
            Redigera.Size = new Size(150, 81);
            Redigera.TabIndex = 21;
            Redigera.Text = "Ändra namn";
            Redigera.UseVisualStyleBackColor = true;
            Redigera.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1171);
            Controls.Add(Redigera);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(categoryListBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Controls.Add(rssLinkSubmitBtn);
            Controls.Add(podcastDataGrid);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Podmania";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)podcastDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)episodeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView podcastDataGrid;
        private Button rssLinkSubmitBtn;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox categoryListBox;
        private Button button1;
        private TextBox textBox1;
        private Button Redigera;
    }
}
