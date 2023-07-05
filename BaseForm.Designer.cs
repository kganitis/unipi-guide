namespace WindowsFormsApp2023_Final
{
    partial class BaseForm
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
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NavigationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BaseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ListenButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.BaseTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 4;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.ExitButton, 3, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.ListenButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.ExportButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AboutButton, 0, 0);
            this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(179, 428);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(702, 70);
            this.ButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // NavigationTableLayoutPanel
            // 
            this.NavigationTableLayoutPanel.ColumnCount = 1;
            this.NavigationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.NavigationTableLayoutPanel.Name = "NavigationTableLayoutPanel";
            this.NavigationTableLayoutPanel.RowCount = 5;
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationTableLayoutPanel.Size = new System.Drawing.Size(170, 419);
            this.NavigationTableLayoutPanel.TabIndex = 0;
            // 
            // BaseTableLayoutPanel
            // 
            this.BaseTableLayoutPanel.ColumnCount = 2;
            this.BaseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BaseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.BaseTableLayoutPanel.Controls.Add(this.NavigationTableLayoutPanel, 0, 0);
            this.BaseTableLayoutPanel.Controls.Add(this.ButtonsTableLayoutPanel, 1, 1);
            this.BaseTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.BaseTableLayoutPanel.Name = "BaseTableLayoutPanel";
            this.BaseTableLayoutPanel.RowCount = 2;
            this.BaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.BaseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BaseTableLayoutPanel.Size = new System.Drawing.Size(884, 501);
            this.BaseTableLayoutPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.exit;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.Location = new System.Drawing.Point(545, 3);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(137, 64);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // ListenButton
            // 
            this.ListenButton.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.speaker;
            this.ListenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListenButton.Location = new System.Drawing.Point(370, 3);
            this.ListenButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(135, 64);
            this.ListenButton.TabIndex = 2;
            this.ListenButton.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.save;
            this.ExportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportButton.Location = new System.Drawing.Point(195, 3);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(135, 64);
            this.ExportButton.TabIndex = 1;
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.BackgroundImage = global::WindowsFormsApp2023_Final.Properties.Resources.users;
            this.AboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutButton.Location = new System.Drawing.Point(20, 3);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(135, 64);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.BaseTableLayoutPanel);
            this.Name = "BaseForm";
            this.Text = "Πανεπιστήμιο Πειραιώς";
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.BaseTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.TableLayoutPanel NavigationTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel BaseTableLayoutPanel;
    }
}

