namespace WindowsFormsApp2023_Final
{
    partial class ViewEventsForm
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
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Location = new System.Drawing.Point(418, 48);
            this.ContentPanel.Size = new System.Drawing.Size(1160, 623);
            // 
            // NavButton1
            // 
            this.NavButton1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton1.Text = "Δραστηριοτήτες";
            // 
            // NavButton5
            // 
            this.NavButton5.Enabled = false;
            this.NavButton5.Location = new System.Drawing.Point(13, 493);
            this.NavButton5.Size = new System.Drawing.Size(240, 45);
            this.NavButton5.Text = "Άλλο";
            this.NavButton5.Visible = false;
            this.NavButton5.Click += new System.EventHandler(this.NavButton5_Click);
            // 
            // NavButton4
            // 
            this.NavButton4.Enabled = false;
            this.NavButton4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton4.Location = new System.Drawing.Point(14, 385);
            this.NavButton4.Size = new System.Drawing.Size(240, 100);
            this.NavButton4.Text = "Νέα Δραστηριότητα";
            this.NavButton4.Click += new System.EventHandler(this.NavButton4_Click);
            // 
            // NavButton3
            // 
            this.NavButton3.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.NavButton3.Location = new System.Drawing.Point(13, 330);
            this.NavButton3.Size = new System.Drawing.Size(240, 47);
            this.NavButton3.Text = "Ημερολόγιο";
            this.NavButton3.Click += new System.EventHandler(this.NavButton3_Click);
            // 
            // NavButton2
            // 
            this.NavButton2.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.NavButton2.Size = new System.Drawing.Size(240, 102);
            this.NavButton2.Text = "Προβολή Δραστηριοτήτων";
            this.NavButton2.Click += new System.EventHandler(this.NavButton2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(278, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Δραστηριότητες";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 690);
            this.Name = "ViewEventsForm";
            this.Text = "Events";
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}