namespace WindowsFormsApp2023_Final
{
    partial class AddEventForm
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
            this.txdate = new System.Windows.Forms.TextBox();
            this.lbdate = new System.Windows.Forms.Label();
            this.lbdescr = new System.Windows.Forms.Label();
            this.rtxdescr = new System.Windows.Forms.RichTextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txdate
            // 
            this.txdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txdate.Enabled = false;
            this.txdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txdate.Location = new System.Drawing.Point(128, 68);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(336, 30);
            this.txdate.TabIndex = 0;
            // 
            // lbdate
            // 
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbdate.Location = new System.Drawing.Point(126, 35);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(125, 30);
            this.lbdate.TabIndex = 2;
            this.lbdate.Text = "Ημερομηνία";
            // 
            // lbdescr
            // 
            this.lbdescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbdescr.Location = new System.Drawing.Point(127, 166);
            this.lbdescr.Name = "lbdescr";
            this.lbdescr.Size = new System.Drawing.Size(125, 30);
            this.lbdescr.TabIndex = 3;
            this.lbdescr.Text = "Περιγραφή";
            // 
            // rtxdescr
            // 
            this.rtxdescr.Location = new System.Drawing.Point(128, 199);
            this.rtxdescr.Name = "rtxdescr";
            this.rtxdescr.Size = new System.Drawing.Size(336, 114);
            this.rtxdescr.TabIndex = 4;
            this.rtxdescr.Text = "";
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(234, 357);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(121, 40);
            this.btnregister.TabIndex = 5;
            this.btnregister.Text = "Καταχώρηση";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.rtxdescr);
            this.Controls.Add(this.lbdescr);
            this.Controls.Add(this.lbdate);
            this.Controls.Add(this.txdate);
            this.Name = "AddEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Καταχώρηση Νέας Δραστηριότητας";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Label lbdescr;
        private System.Windows.Forms.RichTextBox rtxdescr;
        private System.Windows.Forms.Button btnregister;
    }
}