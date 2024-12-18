﻿using System.Windows.Forms;

namespace PodcastCatalogue
{
    //test kommentar.
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
            episodeSearchTextBox = new TextBox();
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
            removeCategoryBtn = new Button();
            categoryNameTextBox = new TextBox();
            renameCategoryBtn = new Button();
            VisaAllaBtn = new Button();
            label5 = new Label();
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
            podcastDataGrid.Location = new Point(69, 278);
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
            
            // 
            // episodeDataGrid
            // 
            episodeDataGrid.AllowUserToAddRows = false;
            episodeDataGrid.AllowUserToDeleteRows = false;
            episodeDataGrid.AllowUserToResizeColumns = false;
            episodeDataGrid.AllowUserToResizeRows = false;
            episodeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            episodeDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            episodeDataGrid.Location = new Point(985, 278);
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
            // 
            // episodeSearchTextBox
            // 
            episodeSearchTextBox.Location = new Point(985, 185);
            episodeSearchTextBox.Margin = new Padding(6);
            episodeSearchTextBox.Name = "episodeSearchTextBox";
            episodeSearchTextBox.Size = new Size(605, 39);
            episodeSearchTextBox.TabIndex = 8;
            episodeSearchTextBox.TextChanged += episodeSearchTextBox_TextChanged;
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
            addCategoryTextbox.Location = new Point(1401, 6);
            addCategoryTextbox.Margin = new Padding(4, 2, 4, 2);
            addCategoryTextbox.Name = "addCategoryTextbox";
            addCategoryTextbox.Size = new Size(240, 39);
            addCategoryTextbox.TabIndex = 12;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.Location = new Point(1649, 2);
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 139);
            label2.Name = "label2";
            label2.Size = new Size(268, 32);
            label2.TabIndex = 15;
            label2.Text = "Sök podcast efter namn";
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
            categoryListBox.Location = new Point(1401, 56);
            categoryListBox.Name = "categoryListBox";
            categoryListBox.Size = new Size(240, 100);
            categoryListBox.TabIndex = 18;
            // 
            // removeCategoryBtn
            // 
            removeCategoryBtn.BackColor = Color.Red;
            removeCategoryBtn.ForeColor = SystemColors.ButtonHighlight;
            removeCategoryBtn.Location = new Point(1204, 56);
            removeCategoryBtn.Name = "removeCategoryBtn";
            removeCategoryBtn.Size = new Size(191, 48);
            removeCategoryBtn.TabIndex = 19;
            removeCategoryBtn.Text = "Ta bort kategori";
            removeCategoryBtn.UseVisualStyleBackColor = false;
            removeCategoryBtn.Click += removeCategoryBtn_Click;
            // 
            // categoryNameTextBox
            // 
            categoryNameTextBox.Location = new Point(1647, 89);
            categoryNameTextBox.Name = "categoryNameTextBox";
            categoryNameTextBox.Size = new Size(242, 39);
            categoryNameTextBox.TabIndex = 20;
            // 
            // renameCategoryBtn
            // 
            renameCategoryBtn.Location = new Point(1649, 134);
            renameCategoryBtn.Name = "renameCategoryBtn";
            renameCategoryBtn.Size = new Size(240, 45);
            renameCategoryBtn.TabIndex = 21;
            renameCategoryBtn.Text = "Ändra namn";
            renameCategoryBtn.UseVisualStyleBackColor = true;
            renameCategoryBtn.Click += renameCategoryBtn_Click_1;
            // 
            // VisaAllaBtn
            // 
            VisaAllaBtn.Location = new Point(69, 223);
            VisaAllaBtn.Name = "VisaAllaBtn";
            VisaAllaBtn.Size = new Size(150, 46);
            VisaAllaBtn.TabIndex = 22;
            VisaAllaBtn.Text = "Visa Alla";
            VisaAllaBtn.UseVisualStyleBackColor = true;
            VisaAllaBtn.Click += VisaAllaBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1649, 51);
            label5.Name = "label5";
            label5.Size = new Size(128, 32);
            label5.TabIndex = 23;
            label5.Text = "Nytt namn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1171);
            Controls.Add(label5);
            Controls.Add(VisaAllaBtn);
            Controls.Add(renameCategoryBtn);
            Controls.Add(categoryNameTextBox);
            Controls.Add(removeCategoryBtn);
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
            Controls.Add(episodeSearchTextBox);
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
        private TextBox episodeSearchTextBox;
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
        private Button removeCategoryBtn;
        private TextBox categoryNameTextBox;
        private Button renameCategoryBtn;
        private Button VisaAllaBtn;
        private Label label5;
    }
}
