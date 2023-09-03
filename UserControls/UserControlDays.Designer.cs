namespace WindowsFormsApp2023_Final
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdays = new System.Windows.Forms.Label();
            this.lbevent1 = new System.Windows.Forms.Label();
            this.lbevent2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbdays.Location = new System.Drawing.Point(2, 1);
            this.lbdays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(27, 20);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            this.lbdays.Click += new System.EventHandler(this.lbdays_Click);
            // 
            // lbevent1
            // 
            this.lbevent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbevent1.Location = new System.Drawing.Point(-2, 24);
            this.lbevent1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbevent1.Name = "lbevent1";
            this.lbevent1.Size = new System.Drawing.Size(142, 31);
            this.lbevent1.TabIndex = 1;
            this.lbevent1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbevent1.Click += new System.EventHandler(this.lbevent1_Click);
            // 
            // lbevent2
            // 
            this.lbevent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbevent2.Location = new System.Drawing.Point(-2, 55);
            this.lbevent2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbevent2.Name = "lbevent2";
            this.lbevent2.Size = new System.Drawing.Size(142, 31);
            this.lbevent2.TabIndex = 2;
            this.lbevent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbevent2.Click += new System.EventHandler(this.lbevent2_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbdays);
            this.Controls.Add(this.lbevent1);
            this.Controls.Add(this.lbevent2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(140, 89);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdays;
        private System.Windows.Forms.Label lbevent1;
        private System.Windows.Forms.Label lbevent2;
    }
}
