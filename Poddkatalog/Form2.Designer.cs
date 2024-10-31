namespace PodcastCatalogue
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            commitChangesBtn = new Button();
            removePodcastBtn = new Button();
            podcastNameLabel = new Label();
            podcastCostumNameLabel = new Label();
            categoryLabel = new Label();
            textBox1 = new TextBox();
            categoryComboBox = new ComboBox();
            SuspendLayout();
            // 
            // commitChangesBtn
            // 
            commitChangesBtn.Location = new Point(152, 248);
            commitChangesBtn.Name = "commitChangesBtn";
            commitChangesBtn.Size = new Size(150, 46);
            commitChangesBtn.TabIndex = 0;
            commitChangesBtn.Text = "Ändra";
            commitChangesBtn.UseVisualStyleBackColor = true;
            commitChangesBtn.Click += commitChangesBtn_Click;
            // 
            // removePodcastBtn
            // 
            removePodcastBtn.BackColor = Color.Red;
            removePodcastBtn.Cursor = Cursors.Hand;
            removePodcastBtn.FlatAppearance.BorderColor = Color.Black;
            removePodcastBtn.FlatAppearance.BorderSize = 2;
            removePodcastBtn.ForeColor = Color.White;
            removePodcastBtn.Location = new Point(152, 300);
            removePodcastBtn.Name = "removePodcastBtn";
            removePodcastBtn.Size = new Size(150, 46);
            removePodcastBtn.TabIndex = 3;
            removePodcastBtn.Text = "Ta bort";
            removePodcastBtn.UseVisualStyleBackColor = false;
            removePodcastBtn.Click += removePodcastBtn_Click;
            // 
            // podcastNameLabel
            // 
            podcastNameLabel.AutoSize = true;
            podcastNameLabel.Location = new Point(21, 22);
            podcastNameLabel.Name = "podcastNameLabel";
            podcastNameLabel.Size = new Size(139, 32);
            podcastNameLabel.TabIndex = 4;
            podcastNameLabel.Text = "placeholder";
            podcastNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // podcastCostumNameLabel
            // 
            podcastCostumNameLabel.AutoSize = true;
            podcastCostumNameLabel.Location = new Point(21, 131);
            podcastCostumNameLabel.Name = "podcastCostumNameLabel";
            podcastCostumNameLabel.Size = new Size(79, 32);
            podcastCostumNameLabel.TabIndex = 5;
            podcastCostumNameLabel.Text = "Namn";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(21, 189);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(103, 32);
            categoryLabel.TabIndex = 6;
            categoryLabel.Text = "Kategori";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 39);
            textBox1.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(130, 181);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(242, 40);
            categoryComboBox.TabIndex = 7;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 404);
            Controls.Add(categoryComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(podcastCostumNameLabel);
            Controls.Add(podcastNameLabel);
            Controls.Add(removePodcastBtn);
            Controls.Add(textBox1);
            Controls.Add(commitChangesBtn);
            Margin = new Padding(6);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button commitChangesBtn;
        private Button removePodcastBtn;
        private Label podcastNameLabel;
        private Label podcastCostumNameLabel;
        private Label categoryLabel;
        private TextBox textBox1;
        private ComboBox categoryComboBox;
    }
}