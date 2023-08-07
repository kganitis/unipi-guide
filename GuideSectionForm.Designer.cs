namespace WindowsFormsApp2023_Final
{
    partial class GuideSectionForm
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
            this.MainContentTextBox = new System.Windows.Forms.RichTextBox();
            this.SectionTitleTextBox = new System.Windows.Forms.RichTextBox();
            this.ContentPictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContentPictureBox2 = new System.Windows.Forms.PictureBox();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.MainContentTextBox);
            this.ContentPanel.Controls.Add(this.SectionTitleTextBox);
            this.ContentPanel.Controls.Add(this.ContentPictureBox1);
            this.ContentPanel.Controls.Add(this.ContentPictureBox2);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            // 
            // NavButton1
            // 
            this.NavButton1.BackColor = System.Drawing.Color.BurlyWood;
            this.NavButton1.Enabled = false;
            this.NavButton1.Text = "";
            // 
            // NavButton5
            // 
            this.NavButton5.Text = "";
            // 
            // NavButton4
            // 
            this.NavButton4.Text = "";
            // 
            // NavButton3
            // 
            this.NavButton3.Text = "";
            // 
            // NavButton2
            // 
            this.NavButton2.Text = "";
            // 
            // NavButtonHome
            // 
            this.NavButtonHome.Enabled = true;
            // 
            // MainContentTextBox
            // 
            this.MainContentTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.MainContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainContentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MainContentTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainContentTextBox.Location = new System.Drawing.Point(50, 113);
            this.MainContentTextBox.Name = "MainContentTextBox";
            this.MainContentTextBox.ReadOnly = true;
            this.MainContentTextBox.Size = new System.Drawing.Size(492, 316);
            this.MainContentTextBox.TabIndex = 1;
            this.MainContentTextBox.Text = "Κυρίως περιεχόμενο";
            // 
            // SectionTitleTextBox
            // 
            this.SectionTitleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.SectionTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SectionTitleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SectionTitleTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionTitleTextBox.Location = new System.Drawing.Point(47, 48);
            this.SectionTitleTextBox.Name = "SectionTitleTextBox";
            this.SectionTitleTextBox.ReadOnly = true;
            this.SectionTitleTextBox.Size = new System.Drawing.Size(721, 46);
            this.SectionTitleTextBox.TabIndex = 2;
            this.SectionTitleTextBox.Text = "Τίτλος τμήματος";
            // 
            // ContentPictureBox1
            // 
            this.ContentPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ContentPictureBox1.Location = new System.Drawing.Point(548, 113);
            this.ContentPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPictureBox1.Name = "ContentPictureBox1";
            this.ContentPictureBox1.Size = new System.Drawing.Size(225, 150);
            this.ContentPictureBox1.TabIndex = 4;
            this.ContentPictureBox1.TabStop = false;
            // 
            // ContentPictureBox2
            // 
            this.ContentPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ContentPictureBox2.Location = new System.Drawing.Point(548, 279);
            this.ContentPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPictureBox2.Name = "ContentPictureBox2";
            this.ContentPictureBox2.Size = new System.Drawing.Size(225, 150);
            this.ContentPictureBox2.TabIndex = 5;
            this.ContentPictureBox2.TabStop = false;
            // 
            // GuideSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GuideSectionForm";
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContentPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.RichTextBox MainContentTextBox;
        protected System.Windows.Forms.RichTextBox SectionTitleTextBox;
        protected System.Windows.Forms.PictureBox ContentPictureBox1;
        protected System.Windows.Forms.PictureBox ContentPictureBox2;
    }
}
