namespace WindowsFormsApp2023_Final
{
    partial class RegisterForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(574, 334);
            this.RegisterButton.Text = "Εγγραφή";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // VisitorButton
            // 
            this.VisitorButton.Location = new System.Drawing.Point(5, 184);
            this.VisitorButton.Size = new System.Drawing.Size(39, 25);
            this.VisitorButton.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(5, 184);
            this.LoginButton.Size = new System.Drawing.Size(39, 25);
            this.LoginButton.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(100, 300);
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.Text = "Ονοματεπώνυμο";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.Location = new System.Drawing.Point(5, 165);
            this.LanguageComboBox.Size = new System.Drawing.Size(39, 26);
            this.LanguageComboBox.Visible = false;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.CancelButton);
            this.ContentPanel.Controls.Add(this.MailTextBox);
            this.ContentPanel.Controls.Add(this.NameTextBox);
            this.ContentPanel.Controls.Add(this.label4);
            this.ContentPanel.Controls.SetChildIndex(this.LoginButton, 0);
            this.ContentPanel.Controls.SetChildIndex(this.VisitorButton, 0);
            this.ContentPanel.Controls.SetChildIndex(this.LanguageComboBox, 0);
            this.ContentPanel.Controls.SetChildIndex(this.label1, 0);
            this.ContentPanel.Controls.SetChildIndex(this.label2, 0);
            this.ContentPanel.Controls.SetChildIndex(this.UsernameTextBox, 0);
            this.ContentPanel.Controls.SetChildIndex(this.PasswordTextBox, 0);
            this.ContentPanel.Controls.SetChildIndex(this.label3, 0);
            this.ContentPanel.Controls.SetChildIndex(this.RegisterButton, 0);
            this.ContentPanel.Controls.SetChildIndex(this.label4, 0);
            this.ContentPanel.Controls.SetChildIndex(this.NameTextBox, 0);
            this.ContentPanel.Controls.SetChildIndex(this.MailTextBox, 0);
            this.ContentPanel.Controls.SetChildIndex(this.CancelButton, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(180, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-mail";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NameTextBox.Location = new System.Drawing.Point(261, 297);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(237, 26);
            this.NameTextBox.TabIndex = 16;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MailTextBox.Location = new System.Drawing.Point(261, 348);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(237, 26);
            this.MailTextBox.TabIndex = 17;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Brown;
            this.CancelButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(574, 264);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(154, 55);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Ακύρωση";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Name = "RegisterForm";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox MailTextBox;
        protected System.Windows.Forms.TextBox NameTextBox;
        protected System.Windows.Forms.Button CancelButton;
    }
}
