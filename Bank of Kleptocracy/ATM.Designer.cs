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
            this.lblCentre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTopLeft = new System.Windows.Forms.Label();
            this.lblMiddleLeft = new System.Windows.Forms.Label();
            this.lblBottomLeft = new System.Windows.Forms.Label();
            this.lblTopRight = new System.Windows.Forms.Label();
            this.lblMiddleRight = new System.Windows.Forms.Label();
            this.lblBottomRight = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1158, 36);
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
            this.menuToolStrip.Size = new System.Drawing.Size(73, 32);
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
            this.cardsToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.cardsToolStripMenuItem1.Text = "Cards";
            // 
            // insertCard1ToolStripMenuItem1
            // 
            this.insertCard1ToolStripMenuItem1.Name = "insertCard1ToolStripMenuItem1";
            this.insertCard1ToolStripMenuItem1.Size = new System.Drawing.Size(215, 34);
            this.insertCard1ToolStripMenuItem1.Text = "Insert Card 1";
            this.insertCard1ToolStripMenuItem1.Click += new System.EventHandler(this.insertCardToolStripMenuItem_Click);
            // 
            // insertCard2ToolStripMenuItem1
            // 
            this.insertCard2ToolStripMenuItem1.Name = "insertCard2ToolStripMenuItem1";
            this.insertCard2ToolStripMenuItem1.Size = new System.Drawing.Size(215, 34);
            this.insertCard2ToolStripMenuItem1.Text = "Insert Card 2";
            this.insertCard2ToolStripMenuItem1.Click += new System.EventHandler(this.insertCardToolStripMenuItem_Click);
            // 
            // insertCard3ToolStripMenuItem1
            // 
            this.insertCard3ToolStripMenuItem1.Name = "insertCard3ToolStripMenuItem1";
            this.insertCard3ToolStripMenuItem1.Size = new System.Drawing.Size(215, 34);
            this.insertCard3ToolStripMenuItem1.Text = "Insert Card 3";
            this.insertCard3ToolStripMenuItem1.Click += new System.EventHandler(this.insertCardToolStripMenuItem_Click);
            // 
            // ejectCardToolStripMenuItem
            // 
            this.ejectCardToolStripMenuItem.Name = "ejectCardToolStripMenuItem";
            this.ejectCardToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.ejectCardToolStripMenuItem.Text = "Eject Card";
            this.ejectCardToolStripMenuItem.Click += new System.EventHandler(this.ejectToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // selectorTopLeft
            // 
            this.selectorTopLeft.Location = new System.Drawing.Point(14, 201);
            this.selectorTopLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectorTopLeft.Name = "selectorTopLeft";
            this.selectorTopLeft.Size = new System.Drawing.Size(75, 46);
            this.selectorTopLeft.TabIndex = 6;
            this.selectorTopLeft.Text = ">";
            this.selectorTopLeft.UseVisualStyleBackColor = true;
            this.selectorTopLeft.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorBottomLeft
            // 
            this.selectorBottomLeft.Location = new System.Drawing.Point(14, 386);
            this.selectorBottomLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectorBottomLeft.Name = "selectorBottomLeft";
            this.selectorBottomLeft.Size = new System.Drawing.Size(75, 46);
            this.selectorBottomLeft.TabIndex = 7;
            this.selectorBottomLeft.Text = ">";
            this.selectorBottomLeft.UseVisualStyleBackColor = true;
            this.selectorBottomLeft.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorMiddleLeft
            // 
            this.selectorMiddleLeft.Location = new System.Drawing.Point(14, 294);
            this.selectorMiddleLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectorMiddleLeft.Name = "selectorMiddleLeft";
            this.selectorMiddleLeft.Size = new System.Drawing.Size(75, 46);
            this.selectorMiddleLeft.TabIndex = 8;
            this.selectorMiddleLeft.Text = ">";
            this.selectorMiddleLeft.UseVisualStyleBackColor = true;
            this.selectorMiddleLeft.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorBottomRight
            // 
            this.selectorBottomRight.Location = new System.Drawing.Point(1077, 386);
            this.selectorBottomRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectorBottomRight.Name = "selectorBottomRight";
            this.selectorBottomRight.Size = new System.Drawing.Size(75, 46);
            this.selectorBottomRight.TabIndex = 9;
            this.selectorBottomRight.Text = "<";
            this.selectorBottomRight.UseVisualStyleBackColor = true;
            this.selectorBottomRight.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorMiddleRight
            // 
            this.selectorMiddleRight.Location = new System.Drawing.Point(1077, 294);
            this.selectorMiddleRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectorMiddleRight.Name = "selectorMiddleRight";
            this.selectorMiddleRight.Size = new System.Drawing.Size(75, 46);
            this.selectorMiddleRight.TabIndex = 10;
            this.selectorMiddleRight.Text = "<";
            this.selectorMiddleRight.UseVisualStyleBackColor = true;
            this.selectorMiddleRight.Click += new System.EventHandler(this.selector_Click);
            // 
            // selectorTopRight
            // 
            this.selectorTopRight.Location = new System.Drawing.Point(1077, 201);
            this.selectorTopRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectorTopRight.Name = "selectorTopRight";
            this.selectorTopRight.Size = new System.Drawing.Size(75, 46);
            this.selectorTopRight.TabIndex = 11;
            this.selectorTopRight.Text = "<";
            this.selectorTopRight.UseVisualStyleBackColor = true;
            this.selectorTopRight.Click += new System.EventHandler(this.selector_Click);
            // 
            // keypad1
            // 
            this.keypad1.Location = new System.Drawing.Point(389, 612);
            this.keypad1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad1.Name = "keypad1";
            this.keypad1.Size = new System.Drawing.Size(86, 65);
            this.keypad1.TabIndex = 12;
            this.keypad1.Text = "1";
            this.keypad1.UseVisualStyleBackColor = true;
            this.keypad1.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad2
            // 
            this.keypad2.Location = new System.Drawing.Point(493, 612);
            this.keypad2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad2.Name = "keypad2";
            this.keypad2.Size = new System.Drawing.Size(86, 65);
            this.keypad2.TabIndex = 13;
            this.keypad2.Text = "2";
            this.keypad2.UseVisualStyleBackColor = true;
            this.keypad2.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad3
            // 
            this.keypad3.Location = new System.Drawing.Point(592, 612);
            this.keypad3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad3.Name = "keypad3";
            this.keypad3.Size = new System.Drawing.Size(86, 65);
            this.keypad3.TabIndex = 14;
            this.keypad3.Text = "3";
            this.keypad3.UseVisualStyleBackColor = true;
            this.keypad3.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypadCancel
            // 
            this.keypadCancel.BackColor = System.Drawing.Color.Red;
            this.keypadCancel.Location = new System.Drawing.Point(695, 612);
            this.keypadCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypadCancel.Name = "keypadCancel";
            this.keypadCancel.Size = new System.Drawing.Size(86, 65);
            this.keypadCancel.TabIndex = 15;
            this.keypadCancel.Text = "CANCEL";
            this.keypadCancel.UseVisualStyleBackColor = false;
            this.keypadCancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // keypad4
            // 
            this.keypad4.Location = new System.Drawing.Point(389, 695);
            this.keypad4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad4.Name = "keypad4";
            this.keypad4.Size = new System.Drawing.Size(86, 65);
            this.keypad4.TabIndex = 16;
            this.keypad4.Text = "4";
            this.keypad4.UseVisualStyleBackColor = true;
            this.keypad4.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypadClear
            // 
            this.keypadClear.BackColor = System.Drawing.Color.Yellow;
            this.keypadClear.Location = new System.Drawing.Point(695, 695);
            this.keypadClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypadClear.Name = "keypadClear";
            this.keypadClear.Size = new System.Drawing.Size(86, 65);
            this.keypadClear.TabIndex = 17;
            this.keypadClear.Text = "CLEAR";
            this.keypadClear.UseVisualStyleBackColor = false;
            this.keypadClear.Click += new System.EventHandler(this.clear_Click);
            // 
            // keypad6
            // 
            this.keypad6.Location = new System.Drawing.Point(592, 695);
            this.keypad6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad6.Name = "keypad6";
            this.keypad6.Size = new System.Drawing.Size(86, 65);
            this.keypad6.TabIndex = 18;
            this.keypad6.Text = "6";
            this.keypad6.UseVisualStyleBackColor = true;
            this.keypad6.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad5
            // 
            this.keypad5.Location = new System.Drawing.Point(493, 695);
            this.keypad5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad5.Name = "keypad5";
            this.keypad5.Size = new System.Drawing.Size(86, 65);
            this.keypad5.TabIndex = 19;
            this.keypad5.Text = "5";
            this.keypad5.UseVisualStyleBackColor = true;
            this.keypad5.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad0
            // 
            this.keypad0.Location = new System.Drawing.Point(493, 871);
            this.keypad0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad0.Name = "keypad0";
            this.keypad0.Size = new System.Drawing.Size(86, 65);
            this.keypad0.TabIndex = 20;
            this.keypad0.Text = "0";
            this.keypad0.UseVisualStyleBackColor = true;
            this.keypad0.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad9
            // 
            this.keypad9.Location = new System.Drawing.Point(592, 783);
            this.keypad9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad9.Name = "keypad9";
            this.keypad9.Size = new System.Drawing.Size(86, 65);
            this.keypad9.TabIndex = 21;
            this.keypad9.Text = "9";
            this.keypad9.UseVisualStyleBackColor = true;
            this.keypad9.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad8
            // 
            this.keypad8.Location = new System.Drawing.Point(493, 783);
            this.keypad8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad8.Name = "keypad8";
            this.keypad8.Size = new System.Drawing.Size(86, 65);
            this.keypad8.TabIndex = 22;
            this.keypad8.Text = "8";
            this.keypad8.UseVisualStyleBackColor = true;
            this.keypad8.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypad7
            // 
            this.keypad7.Location = new System.Drawing.Point(389, 783);
            this.keypad7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypad7.Name = "keypad7";
            this.keypad7.Size = new System.Drawing.Size(86, 65);
            this.keypad7.TabIndex = 23;
            this.keypad7.Text = "7";
            this.keypad7.UseVisualStyleBackColor = true;
            this.keypad7.Click += new System.EventHandler(this.keypad_Click);
            // 
            // keypadEnter
            // 
            this.keypadEnter.BackColor = System.Drawing.Color.Lime;
            this.keypadEnter.Location = new System.Drawing.Point(695, 783);
            this.keypadEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypadEnter.Name = "keypadEnter";
            this.keypadEnter.Size = new System.Drawing.Size(86, 65);
            this.keypadEnter.TabIndex = 24;
            this.keypadEnter.Text = "ENTER";
            this.keypadEnter.UseVisualStyleBackColor = false;
            this.keypadEnter.Click += new System.EventHandler(this.enter_Click);
            // 
            // keypadDummy2
            // 
            this.keypadDummy2.Location = new System.Drawing.Point(592, 871);
            this.keypadDummy2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypadDummy2.Name = "keypadDummy2";
            this.keypadDummy2.Size = new System.Drawing.Size(86, 65);
            this.keypadDummy2.TabIndex = 25;
            this.keypadDummy2.UseVisualStyleBackColor = true;
            // 
            // keypadDummy1
            // 
            this.keypadDummy1.Location = new System.Drawing.Point(389, 871);
            this.keypadDummy1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypadDummy1.Name = "keypadDummy1";
            this.keypadDummy1.Size = new System.Drawing.Size(86, 65);
            this.keypadDummy1.TabIndex = 26;
            this.keypadDummy1.UseVisualStyleBackColor = true;
            // 
            // keypadDummy3
            // 
            this.keypadDummy3.Location = new System.Drawing.Point(695, 871);
            this.keypadDummy3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.keypadDummy3.Name = "keypadDummy3";
            this.keypadDummy3.Size = new System.Drawing.Size(86, 65);
            this.keypadDummy3.TabIndex = 27;
            this.keypadDummy3.UseVisualStyleBackColor = true;
            // 
            // lblCentre
            // 
            this.lblCentre.BackColor = System.Drawing.Color.Transparent;
            this.lblCentre.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentre.Location = new System.Drawing.Point(0, 291);
            this.lblCentre.Margin = new System.Windows.Forms.Padding(0);
            this.lblCentre.Name = "lblCentre";
            this.lblCentre.Size = new System.Drawing.Size(960, 52);
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
            this.lblTitle.Location = new System.Drawing.Point(0, 158);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(963, 42);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Visible = false;
            // 
            // lblTopLeft
            // 
            this.lblTopLeft.AutoSize = true;
            this.lblTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTopLeft.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopLeft.Location = new System.Drawing.Point(14, 161);
            this.lblTopLeft.Name = "lblTopLeft";
            this.lblTopLeft.Size = new System.Drawing.Size(125, 44);
            this.lblTopLeft.TabIndex = 30;
            this.lblTopLeft.Text = "topLeft";
            this.lblTopLeft.Visible = false;
            // 
            // lblMiddleLeft
            // 
            this.lblMiddleLeft.AutoSize = true;
            this.lblMiddleLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddleLeft.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleLeft.Location = new System.Drawing.Point(14, 254);
            this.lblMiddleLeft.Name = "lblMiddleLeft";
            this.lblMiddleLeft.Size = new System.Drawing.Size(176, 44);
            this.lblMiddleLeft.TabIndex = 31;
            this.lblMiddleLeft.Text = "middleLeft";
            this.lblMiddleLeft.Visible = false;
            // 
            // lblBottomLeft
            // 
            this.lblBottomLeft.AutoSize = true;
            this.lblBottomLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblBottomLeft.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomLeft.Location = new System.Drawing.Point(14, 346);
            this.lblBottomLeft.Name = "lblBottomLeft";
            this.lblBottomLeft.Size = new System.Drawing.Size(184, 44);
            this.lblBottomLeft.TabIndex = 32;
            this.lblBottomLeft.Text = "bottomLeft";
            this.lblBottomLeft.Visible = false;
            // 
            // lblTopRight
            // 
            this.lblTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTopRight.BackColor = System.Drawing.Color.Transparent;
            this.lblTopRight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopRight.Location = new System.Drawing.Point(591, 161);
            this.lblTopRight.Name = "lblTopRight";
            this.lblTopRight.Size = new System.Drawing.Size(360, 46);
            this.lblTopRight.TabIndex = 33;
            this.lblTopRight.Text = "topRight";
            this.lblTopRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTopRight.Visible = false;
            // 
            // lblMiddleRight
            // 
            this.lblMiddleRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMiddleRight.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddleRight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleRight.Location = new System.Drawing.Point(591, 254);
            this.lblMiddleRight.Name = "lblMiddleRight";
            this.lblMiddleRight.Size = new System.Drawing.Size(360, 46);
            this.lblMiddleRight.TabIndex = 34;
            this.lblMiddleRight.Text = "middleRight";
            this.lblMiddleRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMiddleRight.Visible = false;
            // 
            // lblBottomRight
            // 
            this.lblBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBottomRight.BackColor = System.Drawing.Color.Transparent;
            this.lblBottomRight.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomRight.Location = new System.Drawing.Point(591, 346);
            this.lblBottomRight.Name = "lblBottomRight";
            this.lblBottomRight.Size = new System.Drawing.Size(360, 46);
            this.lblBottomRight.TabIndex = 35;
            this.lblBottomRight.Text = "bottomRight";
            this.lblBottomRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblBottomRight.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Location = new System.Drawing.Point(104, 40);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(960, 554);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1158, 934);
            this.Controls.Add(this.lblBottomRight);
            this.Controls.Add(this.lblMiddleRight);
            this.Controls.Add(this.lblTopRight);
            this.Controls.Add(this.lblBottomLeft);
            this.Controls.Add(this.lblMiddleLeft);
            this.Controls.Add(this.lblTopLeft);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1180, 990);
            this.MinimumSize = new System.Drawing.Size(1180, 990);
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
        private System.Windows.Forms.Label lblTopLeft;
        private System.Windows.Forms.Label lblMiddleLeft;
        private System.Windows.Forms.Label lblBottomLeft;
        private System.Windows.Forms.Label lblTopRight;
        private System.Windows.Forms.Label lblMiddleRight;
        private System.Windows.Forms.Label lblBottomRight;
    }
}