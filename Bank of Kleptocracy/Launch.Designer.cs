namespace Bank_of_Kleptocracy
{
    partial class Launch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launch));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectorNumAtms = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnIncorrectBalance = new System.Windows.Forms.RadioButton();
            this.radioBtnCorrectBalance = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSimType = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectorNumAtms)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBoxSimType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(375, 558);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(202, 62);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of ATMs";
            // 
            // selectorNumAtms
            // 
            this.selectorNumAtms.Location = new System.Drawing.Point(479, 460);
            this.selectorNumAtms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectorNumAtms.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.selectorNumAtms.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectorNumAtms.Name = "selectorNumAtms";
            this.selectorNumAtms.Size = new System.Drawing.Size(135, 26);
            this.selectorNumAtms.TabIndex = 2;
            this.selectorNumAtms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectorNumAtms.ValueChanged += new System.EventHandler(this.selectorNumAtms_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(636, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose the number of ATMs you wish to simulate";
            // 
            // radioBtnIncorrectBalance
            // 
            this.radioBtnIncorrectBalance.AutoSize = true;
            this.radioBtnIncorrectBalance.Checked = true;
            this.radioBtnIncorrectBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnIncorrectBalance.Location = new System.Drawing.Point(79, 25);
            this.radioBtnIncorrectBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnIncorrectBalance.Name = "radioBtnIncorrectBalance";
            this.radioBtnIncorrectBalance.Size = new System.Drawing.Size(342, 29);
            this.radioBtnIncorrectBalance.TabIndex = 5;
            this.radioBtnIncorrectBalance.TabStop = true;
            this.radioBtnIncorrectBalance.Text = "Transactions with incorrect balance";
            this.radioBtnIncorrectBalance.UseVisualStyleBackColor = true;
            this.radioBtnIncorrectBalance.CheckedChanged += new System.EventHandler(this.radioBtnIncorrectBalance_CheckedChanged);
            // 
            // radioBtnCorrectBalance
            // 
            this.radioBtnCorrectBalance.AutoSize = true;
            this.radioBtnCorrectBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCorrectBalance.Location = new System.Drawing.Point(79, 60);
            this.radioBtnCorrectBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnCorrectBalance.Name = "radioBtnCorrectBalance";
            this.radioBtnCorrectBalance.Size = new System.Drawing.Size(327, 29);
            this.radioBtnCorrectBalance.TabIndex = 6;
            this.radioBtnCorrectBalance.TabStop = true;
            this.radioBtnCorrectBalance.Text = "Transactions with correct balance";
            this.radioBtnCorrectBalance.UseVisualStyleBackColor = true;
            this.radioBtnCorrectBalance.CheckedChanged += new System.EventHandler(this.radioBtnCorrectBalance_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "What simulation would you like to see?";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(933, 33);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(73, 29);
            this.menuToolStrip.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(717, 55);
            this.label4.TabIndex = 9;
            this.label4.Text = "Welcome to our ATM Simulator";
            // 
            // groupBoxSimType
            // 
            this.groupBoxSimType.Controls.Add(this.radioBtnIncorrectBalance);
            this.groupBoxSimType.Controls.Add(this.radioBtnCorrectBalance);
            this.groupBoxSimType.Location = new System.Drawing.Point(238, 234);
            this.groupBoxSimType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSimType.Name = "groupBoxSimType";
            this.groupBoxSimType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSimType.Size = new System.Drawing.Size(472, 102);
            this.groupBoxSimType.TabIndex = 10;
            this.groupBoxSimType.TabStop = false;
            this.groupBoxSimType.Text = "Simulation Type";
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 690);
            this.Controls.Add(this.groupBoxSimType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectorNumAtms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Launch";
            this.Text = "Launch";
            ((System.ComponentModel.ISupportInitialize)(this.selectorNumAtms)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxSimType.ResumeLayout(false);
            this.groupBoxSimType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown selectorNumAtms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtnIncorrectBalance;
        private System.Windows.Forms.RadioButton radioBtnCorrectBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSimType;
    }
}