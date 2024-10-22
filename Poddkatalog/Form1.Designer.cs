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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            poddSearchField = new TextBox();
            rssInputField = new TextBox();
            episodeDataGrid = new DataGridView();
            textBox3 = new TextBox();
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
            podcastDataGrid.Location = new Point(97, 557);
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
            rssLinkSubmitBtn.Location = new Point(364, 158);
            rssLinkSubmitBtn.Margin = new Padding(6);
            rssLinkSubmitBtn.Name = "rssLinkSubmitBtn";
            rssLinkSubmitBtn.Size = new Size(139, 49);
            rssLinkSubmitBtn.TabIndex = 1;
            rssLinkSubmitBtn.Text = "button1";
            rssLinkSubmitBtn.UseVisualStyleBackColor = true;
            rssLinkSubmitBtn.Click += rssLinkSubmitBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(514, 493);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(139, 49);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1150, 491);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(139, 49);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1150, 331);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(139, 49);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // poddSearchField
            // 
            poddSearchField.Location = new Point(97, 495);
            poddSearchField.Margin = new Padding(6);
            poddSearchField.Name = "poddSearchField";
            poddSearchField.Size = new Size(403, 39);
            poddSearchField.TabIndex = 5;
            poddSearchField.TextChanged += textBox1_TextChanged;
            // 
            // rssInputField
            // 
            rssInputField.Location = new Point(139, 158);
            rssInputField.Margin = new Padding(6);
            rssInputField.Name = "rssInputField";
            rssInputField.Size = new Size(182, 39);
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
            episodeDataGrid.Location = new Point(747, 557);
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
            // 
            // textBox3
            // 
            textBox3.Location = new Point(747, 493);
            textBox3.Margin = new Padding(6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(388, 39);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 1056);
            Controls.Add(textBox3);
            Controls.Add(episodeDataGrid);
            Controls.Add(rssInputField);
            Controls.Add(poddSearchField);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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

        private DataGridView podcastDataGrid;
        private Button rssLinkSubmitBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox poddSearchField;
        private TextBox rssInputField;
        private DataGridView episodeDataGrid;
        private TextBox textBox3;
    }
}
