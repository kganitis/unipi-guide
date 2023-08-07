namespace WindowsFormsApp2023_Final
{
    partial class SlideshowForm
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideshowForm));
            Guna.UI2.AnimatorNS.Animation animation6 = new Guna.UI2.AnimatorNS.Animation();
            this.firstUC1 = new WindowsFormsApp2023_Final.UserControls.FirstUC();
            this.secondUC1 = new WindowsFormsApp2023_Final.UserControls.SecondUC();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.thirdUC1 = new WindowsFormsApp2023_Final.UserControls.ThirdUC();
            this.forthUC1 = new WindowsFormsApp2023_Final.UserControls.ForthUC();
            this.guna2Transition2 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.forthUC1);
            this.ContentPanel.Controls.Add(this.thirdUC1);
            this.ContentPanel.Controls.Add(this.button2);
            this.ContentPanel.Controls.Add(this.button1);
            this.ContentPanel.Controls.Add(this.secondUC1);
            this.ContentPanel.Controls.Add(this.firstUC1);
            this.guna2Transition2.SetDecoration(this.ContentPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.ContentPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ContentPanel.Controls.SetChildIndex(this.firstUC1, 0);
            this.ContentPanel.Controls.SetChildIndex(this.secondUC1, 0);
            this.ContentPanel.Controls.SetChildIndex(this.button1, 0);
            this.ContentPanel.Controls.SetChildIndex(this.button2, 0);
            this.ContentPanel.Controls.SetChildIndex(this.thirdUC1, 0);
            this.ContentPanel.Controls.SetChildIndex(this.forthUC1, 0);
            // 
            // AboutButton
            // 
            this.guna2Transition1.SetDecoration(this.AboutButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.AboutButton, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // ExportButton
            // 
            this.guna2Transition1.SetDecoration(this.ExportButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.ExportButton, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // ListenButton
            // 
            this.guna2Transition1.SetDecoration(this.ListenButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.ListenButton, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // ExitButton
            // 
            this.guna2Transition1.SetDecoration(this.ExitButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.ExitButton, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // NavButton1
            // 
            this.guna2Transition1.SetDecoration(this.NavButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.NavButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // NavButtonBack
            // 
            this.guna2Transition1.SetDecoration(this.NavButtonBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.NavButtonBack, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // NavButton5
            // 
            this.NavButton5.BackColor = System.Drawing.Color.BurlyWood;
            this.guna2Transition1.SetDecoration(this.NavButton5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.NavButton5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.NavButton5.Enabled = false;
            // 
            // NavButton4
            // 
            this.guna2Transition1.SetDecoration(this.NavButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.NavButton4, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // NavButton3
            // 
            this.guna2Transition1.SetDecoration(this.NavButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.NavButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // NavButton2
            // 
            this.guna2Transition1.SetDecoration(this.NavButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.NavButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // NavButtonHome
            // 
            this.guna2Transition1.SetDecoration(this.NavButtonHome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.NavButtonHome, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // firstUC1
            // 
            this.firstUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstUC1.BackgroundImage")));
            this.firstUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.firstUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.firstUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.firstUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstUC1.Location = new System.Drawing.Point(17, 31);
            this.firstUC1.Name = "firstUC1";
            this.firstUC1.Size = new System.Drawing.Size(1011, 508);
            this.firstUC1.TabIndex = 1;
            this.firstUC1.Visible = false;
            // 
            // secondUC1
            // 
            this.secondUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondUC1.BackgroundImage")));
            this.secondUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.secondUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.secondUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.secondUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondUC1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.secondUC1.Location = new System.Drawing.Point(17, 31);
            this.secondUC1.Name = "secondUC1";
            this.secondUC1.Size = new System.Drawing.Size(1011, 508);
            this.secondUC1.TabIndex = 2;
            this.secondUC1.Visible = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.guna2Transition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 1F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(357, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(577, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // thirdUC1
            // 
            this.thirdUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thirdUC1.BackgroundImage")));
            this.thirdUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.thirdUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.thirdUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.thirdUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.thirdUC1.Location = new System.Drawing.Point(17, 31);
            this.thirdUC1.Name = "thirdUC1";
            this.thirdUC1.Size = new System.Drawing.Size(1011, 508);
            this.thirdUC1.TabIndex = 5;
            this.thirdUC1.Visible = false;
            // 
            // forthUC1
            // 
            this.forthUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forthUC1.BackgroundImage")));
            this.forthUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.forthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.forthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.forthUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forthUC1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.forthUC1.Location = new System.Drawing.Point(17, 31);
            this.forthUC1.Name = "forthUC1";
            this.forthUC1.Size = new System.Drawing.Size(1011, 508);
            this.forthUC1.TabIndex = 6;
            this.forthUC1.Visible = false;
            // 
            // guna2Transition2
            // 
            this.guna2Transition2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Mosaic;
            this.guna2Transition2.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 20;
            animation6.Padding = new System.Windows.Forms.Padding(30);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.guna2Transition2.DefaultAnimation = animation6;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            // 
            // timer1
            // 
            this.timer1.Interval = 3500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SlideshowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.guna2Transition2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SlideshowForm";
            this.Text = "Φωτογραφίες";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.SecondUC secondUC1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private UserControls.FirstUC firstUC1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControls.ThirdUC thirdUC1;
        private System.Windows.Forms.Timer timer1;
        private UserControls.ForthUC forthUC1;
    }
}
