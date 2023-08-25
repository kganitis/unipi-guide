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
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ContentPanel.Size = new System.Drawing.Size(746, 437);
            // 
            // NavButton1
            // 
            this.NavButton1.Text = "Δραστηριοτήτες";
            // 
            // NavButton5
            // 
            this.NavButton5.Text = "Άλλο";
            this.NavButton5.Visible = false;
            // 
            // NavButton4
            // 
            this.NavButton4.Enabled = false;
            this.NavButton4.Text = "Νέα Δραστηριότητα";
            // 
            // NavButton3
            // 
            this.NavButton3.Text = "Ημερολόγιο";
            // 
            // NavButton2
            // 
            this.NavButton2.Text = "Προβολή Δραστηριοτήτων";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(208, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Δραστηριότητες";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 561);
            this.Margin = new System.Windows.Forms.Padding(3);
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