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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCard1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCard2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertCard3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejectCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectorTopLeft = new System.Windows.Forms.Button();
            this.selectorBottomLeft = new System.Windows.Forms.Button();
            this.selectorMiddleLeft = new System.Windows.Forms.Button();
            this.selectorBottomRight = new System.Windows.Forms.Button();
            this.selectorMiddleRight = new System.Windows.Forms.Button();
            this.selectorTopRight = new System.Windows.Forms.Button();
            this.keypad1 = new System.Windows.Forms.Button();
            this.keypad2 = new System.Windows.Forms.Button();
            this.keypad3 = new System.Windows.Forms.Button();
            this.keypadCancel = new System.Windows.Forms.Button();
            this.keypad4 = new System.Windows.Forms.Button();
            this.keypadClear = new System.Windows.Forms.Button();
            this.keypad6 = new System.Windows.Forms.Button();
            this.keypad5 = new System.Windows.Forms.Button();
            this.keypad0 = new System.Windows.Forms.Button();
            this.keypad9 = new System.Windows.Forms.Button();
            this.keypad8 = new System.Windows.Forms.Button();
            this.keypad7 = new System.Windows.Forms.Button();
            this.keypadEnter = new System.Windows.Forms.Button();
            this.keypadDummy2 = new System.Windows.Forms.Button();
            this.keypadDummy1 = new System.Windows.Forms.Button();
            this.keypadDummy3 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblCentre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(777, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardsToolStripMenuItem1,
            this.aboutToolStripMenuItem1,
            this.helpToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(50, 20);
            this.menuToolStrip.Text = "Menu";
            // 
            // cardsToolStripMenuItem1
            // 
            this.cardsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertCard1ToolStripMenuItem1,
            this.insertCard2ToolStripMenuItem1,
            this.insertCard3ToolStripMenuItem1,
            this.ejectCardToolStripMenuItem});
            this.cardsToolStripMenuItem1.Name = "cardsToolStripMenuItem1";
            this.cardsToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.cardsToolStripMenuItem1.Text = "Cards";
            // 
            // insertCard1ToolStripMenuItem1
            // 
            this.insertCard1ToolStripMenuItem1.Name = "insertCard1ToolStripMenuItem1";
            this.insertCard1ToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.insertCard1ToolStripMenuItem1.Text = "Insert Card 1";
            this.insertCard1ToolStripMenuItem1.Click += new System.EventHandler(this.insertCardToolStripMenuItem_Click);
            // 
            // insertCard2ToolStripMenuItem1
            // 
            this.insertCard2ToolStripMenuItem1.Name = "insertCard2ToolStripMenuItem1";
            this.insertCard2ToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.insertCard2ToolStripMenuItem1.Text = "Insert Card 2";
            this.insertCard2ToolStripMenuItem1.Click += new System.EventHandler(this.insertCardToolStripMenuItem_Click);
            // 
            // insertCard3ToolStripMenuItem1
            // 
            this.insertCard3ToolStripMenuItem1.Name = "insertCard3ToolStripMenuItem1";
            this.insertCard3ToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.insertCard3ToolStripMenuItem1.Text = "Insert Card 3";
            this.insertCard3ToolStripMenuItem1.Click += new System.EventHandler(this.insertCardToolStripMenuItem_Click);
            // 
            // ejectCardToolStripMenuItem
            // 
            this.ejectCardToolStripMenuItem.Name = "ejectCardToolStripMenuItem";
            this.ejectCardToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ejectCardToolStripMenuItem.Text = "Eject Card";
            this.ejectCardToolStripMenuItem.Click += new System.EventHandler(this.ejectToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // selectorTopLeft
            // 
            this.selectorTopLeft.Location = new System.Drawing.Point(9, 131);
            this.selectorTopLeft.Margin = new System.Windows.Forms.Padding(2);
            this.selectorTopLeft.Name = "selectorTopLeft";
            this.selectorTopLeft.Size = new System.Drawing.Size(50, 30);
            this.selectorTopLeft.TabIndex = 6;
            this.selectorTopLeft.Text = ">";
            this.selectorTopLeft.UseVisualStyleBackColor = true;
            this.selectorTopLeft.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorBottomLeft
            // 
            this.selectorBottomLeft.Location = new System.Drawing.Point(9, 251);
            this.selectorBottomLeft.Margin = new System.Windows.Forms.Padding(2);
            this.selectorBottomLeft.Name = "selectorBottomLeft";
            this.selectorBottomLeft.Size = new System.Drawing.Size(50, 30);
            this.selectorBottomLeft.TabIndex = 7;
            this.selectorBottomLeft.Text = ">";
            this.selectorBottomLeft.UseVisualStyleBackColor = true;
            this.selectorBottomLeft.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorMiddleLeft
            // 
            this.selectorMiddleLeft.Location = new System.Drawing.Point(9, 191);
            this.selectorMiddleLeft.Margin = new System.Windows.Forms.Padding(2);
            this.selectorMiddleLeft.Name = "selectorMiddleLeft";
            this.selectorMiddleLeft.Size = new System.Drawing.Size(50, 30);
            this.selectorMiddleLeft.TabIndex = 8;
            this.selectorMiddleLeft.Text = ">";
            this.selectorMiddleLeft.UseVisualStyleBackColor = true;
            this.selectorMiddleLeft.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorBottomRight
            // 
            this.selectorBottomRight.Location = new System.Drawing.Point(718, 251);
            this.selectorBottomRight.Margin = new System.Windows.Forms.Padding(2);
            this.selectorBottomRight.Name = "selectorBottomRight";
            this.selectorBottomRight.Size = new System.Drawing.Size(50, 30);
            this.selectorBottomRight.TabIndex = 9;
            this.selectorBottomRight.Text = "<";
            this.selectorBottomRight.UseVisualStyleBackColor = true;
            this.selectorBottomRight.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorMiddleRight
            // 
            this.selectorMiddleRight.Location = new System.Drawing.Point(718, 191);
            this.selectorMiddleRight.Margin = new System.Windows.Forms.Padding(2);
            this.selectorMiddleRight.Name = "selectorMiddleRight";
            this.selectorMiddleRight.Size = new System.Drawing.Size(50, 30);
            this.selectorMiddleRight.TabIndex = 10;
            this.selectorMiddleRight.Text = "<";
            this.selectorMiddleRight.UseVisualStyleBackColor = true;
            this.selectorMiddleRight.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorTopRight
            // 
            this.selectorTopRight.Location = new System.Drawing.Point(718, 131);
            this.selectorTopRight.Margin = new System.Windows.Forms.Padding(2);
            this.selectorTopRight.Name = "selectorTopRight";
            this.selectorTopRight.Size = new System.Drawing.Size(50, 30);
            this.selectorTopRight.TabIndex = 11;
            this.selectorTopRight.Text = "<";
            this.selectorTopRight.UseVisualStyleBackColor = true;
            this.selectorTopRight.Click += new System.EventHandler(this.selector_Click);
            // 
            // keypad1
            // 
            this.keypad1.Location = new System.Drawing.Point(259, 400);
            this.keypad1.Margin = new System.Windows.Forms.Padding(2);
            this.keypad1.Name = "keypad1";
            this.keypad1.Size = new System.Drawing.Size(57, 42);
            this.keypad1.TabIndex = 12;
            this.keypad1.Text = "1";
            this.keypad1.UseVisualStyleBackColor = true;
            this.keypad1.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad2
            // 
            this.keypad2.Location = new System.Drawing.Point(328, 400);
            this.keypad2.Margin = new System.Windows.Forms.Padding(2);
            this.keypad2.Name = "keypad2";
            this.keypad2.Size = new System.Drawing.Size(57, 42);
            this.keypad2.TabIndex = 13;
            this.keypad2.Text = "2";
            this.keypad2.UseVisualStyleBackColor = true;
            this.keypad2.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad3
            // 
            this.keypad3.Location = new System.Drawing.Point(394, 400);
            this.keypad3.Margin = new System.Windows.Forms.Padding(2);
            this.keypad3.Name = "keypad3";
            this.keypad3.Size = new System.Drawing.Size(57, 42);
            this.keypad3.TabIndex = 14;
            this.keypad3.Text = "3";
            this.keypad3.UseVisualStyleBackColor = true;
            this.keypad3.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypadCancel
            // 
            this.keypadCancel.BackColor = System.Drawing.Color.Red;
            this.keypadCancel.Location = new System.Drawing.Point(463, 400);
            this.keypadCancel.Margin = new System.Windows.Forms.Padding(2);
            this.keypadCancel.Name = "keypadCancel";
            this.keypadCancel.Size = new System.Drawing.Size(57, 42);
            this.keypadCancel.TabIndex = 15;
            this.keypadCancel.Text = "CANCEL";
            this.keypadCancel.UseVisualStyleBackColor = false;
            this.keypadCancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // keypad4
            // 
            this.keypad4.Location = new System.Drawing.Point(259, 453);
            this.keypad4.Margin = new System.Windows.Forms.Padding(2);
            this.keypad4.Name = "keypad4";
            this.keypad4.Size = new System.Drawing.Size(57, 42);
            this.keypad4.TabIndex = 16;
            this.keypad4.Text = "4";
            this.keypad4.UseVisualStyleBackColor = true;
            this.keypad4.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypadClear
            // 
            this.keypadClear.BackColor = System.Drawing.Color.Yellow;
            this.keypadClear.Location = new System.Drawing.Point(463, 453);
            this.keypadClear.Margin = new System.Windows.Forms.Padding(2);
            this.keypadClear.Name = "keypadClear";
            this.keypadClear.Size = new System.Drawing.Size(57, 42);
            this.keypadClear.TabIndex = 17;
            this.keypadClear.Text = "CLEAR";
            this.keypadClear.UseVisualStyleBackColor = false;
            this.keypadClear.Click += new System.EventHandler(this.clear_Click);
            // 
            // keypad6
            // 
            this.keypad6.Location = new System.Drawing.Point(394, 453);
            this.keypad6.Margin = new System.Windows.Forms.Padding(2);
            this.keypad6.Name = "keypad6";
            this.keypad6.Size = new System.Drawing.Size(57, 42);
            this.keypad6.TabIndex = 18;
            this.keypad6.Text = "6";
            this.keypad6.UseVisualStyleBackColor = true;
            this.keypad6.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad5
            // 
            this.keypad5.Location = new System.Drawing.Point(328, 453);
            this.keypad5.Margin = new System.Windows.Forms.Padding(2);
            this.keypad5.Name = "keypad5";
            this.keypad5.Size = new System.Drawing.Size(57, 42);
            this.keypad5.TabIndex = 19;
            this.keypad5.Text = "5";
            this.keypad5.UseVisualStyleBackColor = true;
            this.keypad5.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad0
            // 
            this.keypad0.Location = new System.Drawing.Point(328, 568);
            this.keypad0.Margin = new System.Windows.Forms.Padding(2);
            this.keypad0.Name = "keypad0";
            this.keypad0.Size = new System.Drawing.Size(57, 42);
            this.keypad0.TabIndex = 20;
            this.keypad0.Text = "0";
            this.keypad0.UseVisualStyleBackColor = true;
            this.keypad0.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad9
            // 
            this.keypad9.Location = new System.Drawing.Point(394, 511);
            this.keypad9.Margin = new System.Windows.Forms.Padding(2);
            this.keypad9.Name = "keypad9";
            this.keypad9.Size = new System.Drawing.Size(57, 42);
            this.keypad9.TabIndex = 21;
            this.keypad9.Text = "9";
            this.keypad9.UseVisualStyleBackColor = true;
            this.keypad9.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad8
            // 
            this.keypad8.Location = new System.Drawing.Point(328, 511);
            this.keypad8.Margin = new System.Windows.Forms.Padding(2);
            this.keypad8.Name = "keypad8";
            this.keypad8.Size = new System.Drawing.Size(57, 42);
            this.keypad8.TabIndex = 22;
            this.keypad8.Text = "8";
            this.keypad8.UseVisualStyleBackColor = true;
            this.keypad8.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad7
            // 
            this.keypad7.Location = new System.Drawing.Point(259, 511);
            this.keypad7.Margin = new System.Windows.Forms.Padding(2);
            this.keypad7.Name = "keypad7";
            this.keypad7.Size = new System.Drawing.Size(57, 42);
            this.keypad7.TabIndex = 23;
            this.keypad7.Text = "7";
            this.keypad7.UseVisualStyleBackColor = true;
            this.keypad7.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypadEnter
            // 
            this.keypadEnter.BackColor = System.Drawing.Color.Lime;
            this.keypadEnter.Location = new System.Drawing.Point(463, 511);
            this.keypadEnter.Margin = new System.Windows.Forms.Padding(2);
            this.keypadEnter.Name = "keypadEnter";
            this.keypadEnter.Size = new System.Drawing.Size(57, 42);
            this.keypadEnter.TabIndex = 24;
            this.keypadEnter.Text = "ENTER";
            this.keypadEnter.UseVisualStyleBackColor = false;
            this.keypadEnter.Click += new System.EventHandler(this.enter_Click);
            // 
            // keypadDummy2
            // 
            this.keypadDummy2.Location = new System.Drawing.Point(394, 568);
            this.keypadDummy2.Margin = new System.Windows.Forms.Padding(2);
            this.keypadDummy2.Name = "keypadDummy2";
            this.keypadDummy2.Size = new System.Drawing.Size(57, 42);
            this.keypadDummy2.TabIndex = 25;
            this.keypadDummy2.UseVisualStyleBackColor = true;
            // 
            // keypadDummy1
            // 
            this.keypadDummy1.Location = new System.Drawing.Point(259, 568);
            this.keypadDummy1.Margin = new System.Windows.Forms.Padding(2);
            this.keypadDummy1.Name = "keypadDummy1";
            this.keypadDummy1.Size = new System.Drawing.Size(57, 42);
            this.keypadDummy1.TabIndex = 26;
            this.keypadDummy1.UseVisualStyleBackColor = true;
            // 
            // keypadDummy3
            // 
            this.keypadDummy3.Location = new System.Drawing.Point(463, 568);
            this.keypadDummy3.Margin = new System.Windows.Forms.Padding(2);
            this.keypadDummy3.Name = "keypadDummy3";
            this.keypadDummy3.Size = new System.Drawing.Size(57, 42);
            this.keypadDummy3.TabIndex = 27;
            this.keypadDummy3.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Location = new System.Drawing.Point(69, 26);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 360);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // lblCentre
            // 
            this.lblCentre.BackColor = System.Drawing.Color.Transparent;
            this.lblCentre.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentre.Location = new System.Drawing.Point(0, 189);
            this.lblCentre.Margin = new System.Windows.Forms.Padding(0);
            this.lblCentre.Name = "lblCentre";
            this.lblCentre.Size = new System.Drawing.Size(640, 34);
            this.lblCentre.TabIndex = 28;
            this.lblCentre.Text = "centre";
            this.lblCentre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCentre.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(0, 102);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(642, 28);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Visible = false;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 622);
            this.Controls.Add(this.keypadDummy3);
            this.Controls.Add(this.keypadDummy1);
            this.Controls.Add(this.keypadDummy2);
            this.Controls.Add(this.keypadEnter);
            this.Controls.Add(this.keypad7);
            this.Controls.Add(this.keypad8);
            this.Controls.Add(this.keypad9);
            this.Controls.Add(this.keypad0);
            this.Controls.Add(this.keypad5);
            this.Controls.Add(this.keypad6);
            this.Controls.Add(this.keypadClear);
            this.Controls.Add(this.keypad4);
            this.Controls.Add(this.keypadCancel);
            this.Controls.Add(this.keypad3);
            this.Controls.Add(this.keypad2);
            this.Controls.Add(this.keypad1);
            this.Controls.Add(this.selectorTopRight);
            this.Controls.Add(this.selectorMiddleRight);
            this.Controls.Add(this.selectorBottomRight);
            this.Controls.Add(this.selectorMiddleLeft);
            this.Controls.Add(this.selectorBottomLeft);
            this.Controls.Add(this.selectorTopLeft);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCentre);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(793, 661);
            this.MinimumSize = new System.Drawing.Size(793, 661);
            this.Name = "ATM";
            this.Text = "ATM";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStrip;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button selectorTopLeft;
        private System.Windows.Forms.Button selectorBottomLeft;
        private System.Windows.Forms.Button selectorMiddleLeft;
        private System.Windows.Forms.Button selectorBottomRight;
        private System.Windows.Forms.Button selectorMiddleRight;
        private System.Windows.Forms.Button selectorTopRight;
        private System.Windows.Forms.Button keypad1;
        private System.Windows.Forms.Button keypad2;
        private System.Windows.Forms.Button keypad3;
        private System.Windows.Forms.Button keypadCancel;
        private System.Windows.Forms.Button keypad4;
        private System.Windows.Forms.Button keypadClear;
        private System.Windows.Forms.Button keypad6;
        private System.Windows.Forms.Button keypad5;
        private System.Windows.Forms.Button keypad0;
        private System.Windows.Forms.Button keypad9;
        private System.Windows.Forms.Button keypad8;
        private System.Windows.Forms.Button keypad7;
        private System.Windows.Forms.Button keypadEnter;
        private System.Windows.Forms.Button keypadDummy2;
        private System.Windows.Forms.Button keypadDummy1;
        private System.Windows.Forms.Button keypadDummy3;
        private System.Windows.Forms.ToolStripMenuItem cardsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertCard1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertCard2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertCard3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejectCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblCentre;
        private System.Windows.Forms.Label lblTitle;
    }
}