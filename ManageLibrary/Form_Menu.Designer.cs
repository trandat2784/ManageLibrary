namespace ManageLibrary
{
    partial class Form_Menu
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            bookToolStripMenuItem = new ToolStripMenuItem();
            authorToolStripMenuItem = new ToolStripMenuItem();
            nXBToolStripMenuItem = new ToolStripMenuItem();
            muonTraToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            Slider = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Slider).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, informationToolStripMenuItem, helpToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(139, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.AutoSize = false;
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, exitToolStripMenuItem });
            accountToolStripMenuItem.Font = new Font("#9Slide03 SVND Sari", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            accountToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(150, 50);
            accountToolStripMenuItem.Text = "Account";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(183, 34);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(183, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.AutoSize = false;
            informationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookToolStripMenuItem, authorToolStripMenuItem, nXBToolStripMenuItem, muonTraToolStripMenuItem });
            informationToolStripMenuItem.Font = new Font("#9Slide03 SVND Sari", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            informationToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            informationToolStripMenuItem.ImageTransparentColor = Color.WhiteSmoke;
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(150, 50);
            informationToolStripMenuItem.Text = " Manage";
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(270, 34);
            bookToolStripMenuItem.Text = "Book";
            bookToolStripMenuItem.Click += bookToolStripMenuItem_Click;
            // 
            // authorToolStripMenuItem
            // 
            authorToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            authorToolStripMenuItem.Size = new Size(270, 34);
            authorToolStripMenuItem.Text = "Author";
            authorToolStripMenuItem.Click += authorToolStripMenuItem_Click;
            // 
            // nXBToolStripMenuItem
            // 
            nXBToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            nXBToolStripMenuItem.ForeColor = SystemColors.ControlText;
            nXBToolStripMenuItem.Name = "nXBToolStripMenuItem";
            nXBToolStripMenuItem.Size = new Size(270, 34);
            nXBToolStripMenuItem.Text = "NXB";
            nXBToolStripMenuItem.Click += nXBToolStripMenuItem_Click;
            // 
            // muonTraToolStripMenuItem
            // 
            muonTraToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            muonTraToolStripMenuItem.ForeColor = SystemColors.ControlText;
            muonTraToolStripMenuItem.Name = "muonTraToolStripMenuItem";
            muonTraToolStripMenuItem.Size = new Size(270, 34);
            muonTraToolStripMenuItem.Text = "Muon Tra";
            muonTraToolStripMenuItem.Click += muonTraToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.AutoSize = false;
            helpToolStripMenuItem.Font = new Font("#9Slide03 SVND Sari", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(150, 50);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.Font = new Font("#9Slide03 SVND Sari", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(150, 50);
            toolStripMenuItem1.Text = "About";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // Slider
            // 
            Slider.Image = Properties.Resources.Screenshot_2023_12_09_104925;
            Slider.Location = new Point(244, 59);
            Slider.Name = "Slider";
            Slider.Size = new Size(656, 368);
            Slider.SizeMode = PictureBoxSizeMode.CenterImage;
            Slider.TabIndex = 1;
            Slider.TabStop = false;
            Slider.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(344, 9);
            label1.Name = "label1";
            label1.Size = new Size(445, 38);
            label1.TabIndex = 2;
            label1.Text = "Nhũng Cuốn Sách Đang Phổ Biến ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 450);
            Controls.Add(label1);
            Controls.Add(Slider);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Menu";
            Text = "Form_Menu";
            Load += Form_Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Slider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem authorToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem nXBToolStripMenuItem;
        private ToolStripMenuItem muonTraToolStripMenuItem;
        private PictureBox Slider;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}