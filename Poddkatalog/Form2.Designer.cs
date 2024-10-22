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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            removePodcastBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(73, 161);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Ändra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 2;
            // 
            // removePodcastBtn
            // 
            removePodcastBtn.BackColor = Color.Red;
            removePodcastBtn.Cursor = Cursors.Hand;
            removePodcastBtn.FlatAppearance.BorderColor = Color.Black;
            removePodcastBtn.FlatAppearance.BorderSize = 2;
            removePodcastBtn.ForeColor = Color.White;
            removePodcastBtn.Location = new Point(73, 213);
            removePodcastBtn.Name = "removePodcastBtn";
            removePodcastBtn.Size = new Size(150, 46);
            removePodcastBtn.TabIndex = 3;
            removePodcastBtn.Text = "Ta bort";
            removePodcastBtn.UseVisualStyleBackColor = false;
            removePodcastBtn.Click += removePodcastBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 311);
            Controls.Add(removePodcastBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(6);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button removePodcastBtn;
    }
}