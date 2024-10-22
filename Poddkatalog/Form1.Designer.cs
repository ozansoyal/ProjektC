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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            rssLinkSubmitBtn = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            poddSearchField = new TextBox();
            rssInputField = new TextBox();
            episodeDataGrid = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)podcastDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)episodeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // podcastDataGrid
            // 
            podcastDataGrid.AllowUserToAddRows = false;
            podcastDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            podcastDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            podcastDataGrid.Location = new Point(52, 261);
            podcastDataGrid.Name = "podcastDataGrid";
            podcastDataGrid.RowHeadersVisible = false;
            podcastDataGrid.RowHeadersWidth = 82;
            podcastDataGrid.Size = new Size(344, 189);
            podcastDataGrid.TabIndex = 0;
            podcastDataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Namn";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Titel";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Kategori";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // rssLinkSubmitBtn
            // 
            rssLinkSubmitBtn.Location = new Point(196, 74);
            rssLinkSubmitBtn.Name = "rssLinkSubmitBtn";
            rssLinkSubmitBtn.Size = new Size(75, 23);
            rssLinkSubmitBtn.TabIndex = 1;
            rssLinkSubmitBtn.Text = "button1";
            rssLinkSubmitBtn.UseVisualStyleBackColor = true;
            rssLinkSubmitBtn.Click += rssLinkSubmitBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 231);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(619, 230);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(619, 155);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // poddSearchField
            // 
            poddSearchField.Location = new Point(52, 232);
            poddSearchField.Name = "poddSearchField";
            poddSearchField.Size = new Size(219, 23);
            poddSearchField.TabIndex = 5;
            poddSearchField.TextChanged += textBox1_TextChanged;
            // 
            // rssInputField
            // 
            rssInputField.Location = new Point(75, 74);
            rssInputField.Name = "rssInputField";
            rssInputField.Size = new Size(100, 23);
            rssInputField.TabIndex = 6;
            rssInputField.TextChanged += textBox2_TextChanged;
            // 
            // episodeDataGrid
            // 
            episodeDataGrid.AllowUserToAddRows = false;
            episodeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            episodeDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            episodeDataGrid.Location = new Point(402, 261);
            episodeDataGrid.Name = "episodeDataGrid";
            episodeDataGrid.RowHeadersVisible = false;
            episodeDataGrid.RowHeadersWidth = 82;
            episodeDataGrid.Size = new Size(343, 189);
            episodeDataGrid.TabIndex = 7;
            // 
            // Column4
            // 
            Column4.HeaderText = "Avsnitt";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Titel";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Length";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(402, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 23);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 495);
            Controls.Add(textBox3);
            Controls.Add(episodeDataGrid);
            Controls.Add(rssInputField);
            Controls.Add(poddSearchField);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(rssLinkSubmitBtn);
            Controls.Add(podcastDataGrid);
            Margin = new Padding(2, 1, 2, 1);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button rssLinkSubmitBtn;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox poddSearchField;
        private TextBox rssInputField;
        private DataGridView episodeDataGrid;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBox3;
    }
}
