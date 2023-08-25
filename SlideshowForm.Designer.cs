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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideshowForm));
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.firstUC1 = new WindowsFormsApp2023_Final.UserControls.FirstUC();
            this.secondUC1 = new WindowsFormsApp2023_Final.UserControls.SecondUC();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.thirdUC1 = new WindowsFormsApp2023_Final.UserControls.ThirdUC();
            this.forthUC1 = new WindowsFormsApp2023_Final.UserControls.ForthUC();
            this.fifthUC1 = new WindowsFormsApp2023_Final.UserControls.FifthUC();
            this.sixthUC1 = new WindowsFormsApp2023_Final.UserControls.SixthUC();
            this.seventhUC1 = new WindowsFormsApp2023_Final.UserControls.SeventhUC();
            this.eighthUC1 = new WindowsFormsApp2023_Final.UserControls.EighthUC();
            this.ninthUC1 = new WindowsFormsApp2023_Final.UserControls.NinthUC();
            this.seventhUC2 = new WindowsFormsApp2023_Final.UserControls.SeventhUC();
            this.tenthUC1 = new WindowsFormsApp2023_Final.UserControls.TenthUC();
            this.eleventhUC1 = new WindowsFormsApp2023_Final.UserControls.EleventhUC();
            this.twelfthUC1 = new WindowsFormsApp2023_Final.UserControls.TwelfthUC();
            this.guna2Transition2 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.twelfthUC1);
            this.ContentPanel.Controls.Add(this.eleventhUC1);
            this.ContentPanel.Controls.Add(this.tenthUC1);
            this.ContentPanel.Controls.Add(this.seventhUC2);
            this.ContentPanel.Controls.Add(this.ninthUC1);
            this.ContentPanel.Controls.Add(this.eighthUC1);
            this.ContentPanel.Controls.Add(this.seventhUC1);
            this.ContentPanel.Controls.Add(this.sixthUC1);
            this.ContentPanel.Controls.Add(this.fifthUC1);
            this.ContentPanel.Controls.Add(this.forthUC1);
            this.ContentPanel.Controls.Add(this.thirdUC1);
            this.ContentPanel.Controls.Add(this.secondUC1);
            this.ContentPanel.Controls.Add(this.firstUC1);
            this.guna2Transition2.SetDecoration(this.ContentPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.ContentPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ContentPanel.Location = new System.Drawing.Point(267, 30);
            this.ContentPanel.Size = new System.Drawing.Size(1045, 537);
            // 
            // AboutButton
            // 
            this.guna2Transition1.SetDecoration(this.AboutButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.AboutButton, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.ExportButton.BackgroundImage = null;
            this.guna2Transition1.SetDecoration(this.ExportButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.ExportButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ExportButton.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Text = "Play";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ListenButton
            // 
            this.ListenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.ListenButton.BackgroundImage = null;
            this.guna2Transition1.SetDecoration(this.ListenButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.ListenButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ListenButton.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ListenButton.ForeColor = System.Drawing.Color.White;
            this.ListenButton.Text = "Stop";
            this.ListenButton.UseVisualStyleBackColor = false;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
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
            this.firstUC1.Location = new System.Drawing.Point(17, 0);
            this.firstUC1.Name = "firstUC1";
            this.firstUC1.Size = new System.Drawing.Size(1011, 537);
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
            this.secondUC1.Location = new System.Drawing.Point(17, 0);
            this.secondUC1.Name = "secondUC1";
            this.secondUC1.Size = new System.Drawing.Size(1011, 537);
            this.secondUC1.TabIndex = 2;
            this.secondUC1.Visible = false;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // thirdUC1
            // 
            this.thirdUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thirdUC1.BackgroundImage")));
            this.thirdUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.thirdUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.thirdUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.thirdUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.thirdUC1.Location = new System.Drawing.Point(17, 0);
            this.thirdUC1.Name = "thirdUC1";
            this.thirdUC1.Size = new System.Drawing.Size(1011, 537);
            this.thirdUC1.TabIndex = 3;
            this.thirdUC1.Visible = false;
            // 
            // forthUC1
            // 
            this.forthUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forthUC1.BackgroundImage")));
            this.forthUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.forthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.forthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.forthUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forthUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.forthUC1.Location = new System.Drawing.Point(17, 0);
            this.forthUC1.Name = "forthUC1";
            this.forthUC1.Size = new System.Drawing.Size(1011, 537);
            this.forthUC1.TabIndex = 4;
            this.forthUC1.Visible = false;
            // 
            // fifthUC1
            // 
            this.fifthUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fifthUC1.BackgroundImage")));
            this.fifthUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.fifthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.fifthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.fifthUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fifthUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.fifthUC1.Location = new System.Drawing.Point(17, 0);
            this.fifthUC1.Name = "fifthUC1";
            this.fifthUC1.Size = new System.Drawing.Size(1011, 537);
            this.fifthUC1.TabIndex = 5;
            this.fifthUC1.Visible = false;
            // 
            // sixthUC1
            // 
            this.sixthUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sixthUC1.BackgroundImage")));
            this.sixthUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.sixthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.sixthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sixthUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixthUC1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sixthUC1.Location = new System.Drawing.Point(17, 0);
            this.sixthUC1.Name = "sixthUC1";
            this.sixthUC1.Size = new System.Drawing.Size(1011, 537);
            this.sixthUC1.TabIndex = 6;
            this.sixthUC1.Visible = false;
            // 
            // seventhUC1
            // 
            this.seventhUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seventhUC1.BackgroundImage")));
            this.seventhUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.seventhUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.seventhUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.seventhUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seventhUC1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.seventhUC1.Location = new System.Drawing.Point(17, 0);
            this.seventhUC1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.seventhUC1.Name = "seventhUC1";
            this.seventhUC1.Size = new System.Drawing.Size(1011, 537);
            this.seventhUC1.TabIndex = 7;
            this.seventhUC1.Visible = false;
            // 
            // eighthUC1
            // 
            this.eighthUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eighthUC1.BackgroundImage")));
            this.eighthUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.eighthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.eighthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.eighthUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eighthUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.eighthUC1.Location = new System.Drawing.Point(17, 0);
            this.eighthUC1.Name = "eighthUC1";
            this.eighthUC1.Size = new System.Drawing.Size(1011, 537);
            this.eighthUC1.TabIndex = 8;
            this.eighthUC1.Visible = false;
            // 
            // ninthUC1
            // 
            this.ninthUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ninthUC1.BackgroundImage")));
            this.ninthUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.ninthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.ninthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ninthUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ninthUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.ninthUC1.Location = new System.Drawing.Point(17, 0);
            this.ninthUC1.Name = "ninthUC1";
            this.ninthUC1.Size = new System.Drawing.Size(1011, 537);
            this.ninthUC1.TabIndex = 9;
            // 
            // seventhUC2
            // 
            this.seventhUC2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seventhUC2.BackgroundImage")));
            this.seventhUC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.seventhUC2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.seventhUC2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.seventhUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seventhUC2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.seventhUC2.Location = new System.Drawing.Point(17, 0);
            this.seventhUC2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.seventhUC2.Name = "seventhUC2";
            this.seventhUC2.Size = new System.Drawing.Size(1011, 537);
            this.seventhUC2.TabIndex = 10;
            this.seventhUC2.Visible = false;
            // 
            // tenthUC1
            // 
            this.tenthUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tenthUC1.BackgroundImage")));
            this.tenthUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.tenthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.tenthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tenthUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tenthUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tenthUC1.Location = new System.Drawing.Point(17, 0);
            this.tenthUC1.Margin = new System.Windows.Forms.Padding(4);
            this.tenthUC1.Name = "tenthUC1";
            this.tenthUC1.Size = new System.Drawing.Size(1011, 537);
            this.tenthUC1.TabIndex = 11;
            this.tenthUC1.Visible = false;
            // 
            // eleventhUC1
            // 
            this.eleventhUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eleventhUC1.BackgroundImage")));
            this.eleventhUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.eleventhUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.eleventhUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.eleventhUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eleventhUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.eleventhUC1.Location = new System.Drawing.Point(17, 0);
            this.eleventhUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eleventhUC1.Name = "eleventhUC1";
            this.eleventhUC1.Size = new System.Drawing.Size(1011, 537);
            this.eleventhUC1.TabIndex = 12;
            this.eleventhUC1.Visible = false;
            // 
            // twelfthUC1
            // 
            this.twelfthUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("twelfthUC1.BackgroundImage")));
            this.twelfthUC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Transition1.SetDecoration(this.twelfthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.twelfthUC1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.twelfthUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twelfthUC1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.twelfthUC1.Location = new System.Drawing.Point(17, 0);
            this.twelfthUC1.Name = "twelfthUC1";
            this.twelfthUC1.Size = new System.Drawing.Size(1011, 537);
            this.twelfthUC1.TabIndex = 13;
            // 
            // guna2Transition2
            // 
            this.guna2Transition2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Mosaic;
            this.guna2Transition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition2.DefaultAnimation = animation2;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.SecondUC secondUC1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private UserControls.FirstUC firstUC1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private UserControls.FifthUC fifthUC1;
        private UserControls.ForthUC forthUC1;
        private UserControls.ThirdUC thirdUC1;
        private UserControls.SixthUC sixthUC1;
        private UserControls.SeventhUC seventhUC1;
        private UserControls.EighthUC eighthUC1;
        private UserControls.SeventhUC seventhUC2;
        private UserControls.NinthUC ninthUC1;
        private UserControls.TenthUC tenthUC1;
        private UserControls.EleventhUC eleventhUC1;
        private UserControls.TwelfthUC twelfthUC1;
    }
}
