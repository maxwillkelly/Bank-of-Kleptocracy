namespace Bank_of_Kleptocracy
{
    partial class ATM
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
            this.title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCard1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCard2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCard3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(282, 96);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(538, 65);
            this.title.TabIndex = 1;
            this.title.Text = "Bank of Kleptocracy";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.cardsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1060, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cardsToolStripMenuItem
            // 
            this.cardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertCard1ToolStripMenuItem,
            this.insertCard2ToolStripMenuItem,
            this.insertCard3ToolStripMenuItem,
            this.ejectToolStripMenuItem});
            this.cardsToolStripMenuItem.Name = "cardsToolStripMenuItem";
            this.cardsToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.cardsToolStripMenuItem.Text = "Cards";
            // 
            // insertCard1ToolStripMenuItem
            // 
            this.insertCard1ToolStripMenuItem.Name = "insertCard1ToolStripMenuItem";
            this.insertCard1ToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.insertCard1ToolStripMenuItem.Text = "Insert Card 1";
            this.insertCard1ToolStripMenuItem.Click += new System.EventHandler(this.insertCardToolStripMenuItem_Click);
            // 
            // insertCard2ToolStripMenuItem
            // 
            this.insertCard2ToolStripMenuItem.Name = "insertCard2ToolStripMenuItem";
            this.insertCard2ToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.insertCard2ToolStripMenuItem.Text = "Insert Card 2";
            this.insertCard2ToolStripMenuItem.Click += new System.EventHandler(this.insertCardToolStripMenuItem_Click);
            // 
            // insertCard3ToolStripMenuItem
            // 
            this.insertCard3ToolStripMenuItem.Name = "insertCard3ToolStripMenuItem";
            this.insertCard3ToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.insertCard3ToolStripMenuItem.Text = "Insert Card 3";
            this.insertCard3ToolStripMenuItem.Click += new System.EventHandler(this.insertCardToolStripMenuItem_Click);
            // 
            // ejectToolStripMenuItem
            // 
            this.ejectToolStripMenuItem.Name = "ejectToolStripMenuItem";
            this.ejectToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.ejectToolStripMenuItem.Text = "Eject";
            this.ejectToolStripMenuItem.Click += new System.EventHandler(this.ejectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Bank_of_Kleptocracy.Properties.Resources.sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 841);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.title);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ATM";
            this.Text = "ATM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCard1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCard2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertCard3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}