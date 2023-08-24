namespace WindowsFormsApp2023_Final
{
    partial class ReviewsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ReviewsTextBox = new System.Windows.Forms.RichTextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ReviewSubmitButton = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.ReviewSubmitButton);
            this.ContentPanel.Controls.Add(this.TitleLabel);
            this.ContentPanel.Controls.Add(this.ReviewsTextBox);
            this.ContentPanel.Controls.Add(this.pictureBox3);
            this.ContentPanel.Controls.Add(this.pictureBox2);
            this.ContentPanel.Controls.Add(this.pictureBox1);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(6);
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.ContentPanel.Size = new System.Drawing.Size(784, 436);
            // 
            // NavButton4
            // 
            this.NavButton4.BackColor = System.Drawing.Color.BurlyWood;
            this.NavButton4.Enabled = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2023_Final.Properties.Resources.pic11;
            this.pictureBox2.Location = new System.Drawing.Point(80, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(533, 160);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pictureBox3.Location = new System.Drawing.Point(608, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 160);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // ReviewsTextBox
            // 
            this.ReviewsTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReviewsTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ReviewsTextBox.Location = new System.Drawing.Point(4, 188);
            this.ReviewsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ReviewsTextBox.Name = "ReviewsTextBox";
            this.ReviewsTextBox.ReadOnly = true;
            this.ReviewsTextBox.Size = new System.Drawing.Size(786, 189);
            this.ReviewsTextBox.TabIndex = 6;
            this.ReviewsTextBox.Text = "";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(287, 163);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(22, 2, 22, 2);
            this.TitleLabel.Size = new System.Drawing.Size(209, 23);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Σχόλια σπουδαστών";
            // 
            // ReviewSubmitButton
            // 
            this.ReviewSubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.ReviewSubmitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ReviewSubmitButton.ForeColor = System.Drawing.Color.White;
            this.ReviewSubmitButton.Location = new System.Drawing.Point(279, 381);
            this.ReviewSubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReviewSubmitButton.Name = "ReviewSubmitButton";
            this.ReviewSubmitButton.Size = new System.Drawing.Size(226, 50);
            this.ReviewSubmitButton.TabIndex = 8;
            this.ReviewSubmitButton.Text = "Γράψε το δικό σου σχόλιο";
            this.ReviewSubmitButton.UseVisualStyleBackColor = false;
            this.ReviewSubmitButton.Click += new System.EventHandler(this.ReviewSubmitButton_Click);
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReviewsForm";
            this.Text = "Αξιολογήσεις";
            this.Activated += new System.EventHandler(this.ReviewsForm_Activated);
            this.Load += new System.EventHandler(this.ReviewsForm_Load);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox ReviewsTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ReviewSubmitButton;
    }
}
