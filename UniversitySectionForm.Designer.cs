﻿namespace WindowsFormsApp2023_Final
{
    partial class UniversitySectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ContentPanel.Controls.Add(this.label2);
            this.ContentPanel.Controls.Add(this.pictureBox2);
            this.ContentPanel.Controls.Add(this.pictureBox1);
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Location = new System.Drawing.Point(267, 30);
            this.ContentPanel.Size = new System.Drawing.Size(1045, 537);
            // 
            // NavButton1
            // 
            this.NavButton1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton1.Location = new System.Drawing.Point(13, 128);
            this.NavButton1.Text = "Πανεπιστήμιο";
            // 
            // NavButton5
            // 
            this.NavButton5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton5.Location = new System.Drawing.Point(13, 465);
            this.NavButton5.Size = new System.Drawing.Size(240, 72);
            this.NavButton5.Text = "Events";
            this.NavButton5.Click += new System.EventHandler(this.NavButton5_Click);
            // 
            // NavButton4
            // 
            this.NavButton4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton4.Location = new System.Drawing.Point(13, 371);
            this.NavButton4.Size = new System.Drawing.Size(240, 86);
            this.NavButton4.Text = "Στρατηγικη Πάνεπιστημίου";
            this.NavButton4.Click += new System.EventHandler(this.NavButton4_Click);
            // 
            // NavButton3
            // 
            this.NavButton3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton3.Location = new System.Drawing.Point(13, 308);
            this.NavButton3.Size = new System.Drawing.Size(240, 55);
            this.NavButton3.Text = "Εγκαταστάσεις";
            this.NavButton3.Click += new System.EventHandler(this.NavButton3_Click);
            // 
            // NavButton2
            // 
            this.NavButton2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton2.Location = new System.Drawing.Point(13, 210);
            this.NavButton2.Size = new System.Drawing.Size(240, 90);
            this.NavButton2.Text = "Ιστορική Αναδρομή";
            this.NavButton2.Click += new System.EventHandler(this.NavButton2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(306, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Πανεπιστήμιο";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(734, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 157);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(734, 336);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 151);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(648, 382);
            this.label2.TabIndex = 4;
            // 
            // UniversitySectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "UniversitySectionForm";
            this.Text = "Πανεπιστήμιο";
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
