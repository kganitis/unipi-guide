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
            this.ContentPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Size = new System.Drawing.Size(995, 539);
            // 
            // NavButton1
            // 
            this.NavButton1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NavButton1.Text = "Δραστηριοτήτες";
            // 
            // NavButton5
            // 
            this.NavButton5.Enabled = false;
            this.NavButton5.Text = "Καταχώρηση";
            this.NavButton5.Click += new System.EventHandler(this.NavButton5_Click);
            // 
            // NavButton4
            // 
            this.NavButton4.Text = "Ημερίδες";
            this.NavButton4.Click += new System.EventHandler(this.NavButton4_Click);
            // 
            // NavButton3
            // 
            this.NavButton3.Text = "Δράσεις";
            this.NavButton3.Click += new System.EventHandler(this.NavButton3_Click);
            // 
            // NavButton2
            // 
            this.NavButton2.Text = "Συνέδρια";
            this.NavButton2.Click += new System.EventHandler(this.NavButton2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(347, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 49);
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
            this.Text = "ViewEventsForm";
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}