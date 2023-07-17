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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.button5);
            this.ContentPanel.Controls.Add(this.button4);
            this.ContentPanel.Controls.Add(this.button3);
            this.ContentPanel.Controls.Add(this.button2);
            this.ContentPanel.Controls.Add(this.button1);
            this.ContentPanel.Controls.Add(this.pictureBox3);
            this.ContentPanel.Controls.Add(this.pictureBox2);
            this.ContentPanel.Controls.Add(this.pictureBox1);
            this.ContentPanel.Size = new System.Drawing.Size(1176, 676);
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            this.ContentPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.ContentPanel.Controls.SetChildIndex(this.pictureBox2, 0);
            this.ContentPanel.Controls.SetChildIndex(this.pictureBox3, 0);
            this.ContentPanel.Controls.SetChildIndex(this.button1, 0);
            this.ContentPanel.Controls.SetChildIndex(this.button2, 0);
            this.ContentPanel.Controls.SetChildIndex(this.button3, 0);
            this.ContentPanel.Controls.SetChildIndex(this.button4, 0);
            this.ContentPanel.Controls.SetChildIndex(this.button5, 0);
            // 
            // AboutButton
            // 
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // NavButton1
            // 
            this.NavButton1.Click += new System.EventHandler(this.NavButton1_Click);
            // 
            // NavButton5
            // 
            this.NavButton5.Click += new System.EventHandler(this.NavButton5_Click);
            // 
            // NavButton4
            // 
            this.NavButton4.BackColor = System.Drawing.Color.BurlyWood;
            this.NavButton4.Enabled = false;
            this.NavButton4.Click += new System.EventHandler(this.NavButton4_Click);
            // 
            // NavButton3
            // 
            this.NavButton3.Click += new System.EventHandler(this.NavButton3_Click);
            // 
            // NavButton2
            // 
            this.NavButton2.Click += new System.EventHandler(this.NavButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 246);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2023_Final.Properties.Resources.pic11;
            this.pictureBox2.Location = new System.Drawing.Point(120, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 246);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.pictureBox3.Location = new System.Drawing.Point(912, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(264, 246);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(120, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Αξιολόγηση Μαθημάτων";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(498, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "Αξιολογήσεις Καθηγητών";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(887, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "Σχόλια";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(120, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(277, 71);
            this.button4.TabIndex = 6;
            this.button4.Text = "Προπτυχιακό";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(498, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(277, 71);
            this.button5.TabIndex = 7;
            this.button5.Text = "Μεταπτυχιακό";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1476, 863);
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "ReviewsForm";
            this.Text = "Αξιολογήσεις";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReviewsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReviewsForm_FormClosed);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}
