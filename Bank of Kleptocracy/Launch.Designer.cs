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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectorNumAtms = new System.Windows.Forms.NumericUpDown();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectorNumAtms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(236, 295);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of ATMs";
            // 
            // selectorNumAtms
            // 
            this.selectorNumAtms.Location = new System.Drawing.Point(331, 212);
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
            this.selectorNumAtms.Size = new System.Drawing.Size(120, 22);
            this.selectorNumAtms.TabIndex = 2;
            this.selectorNumAtms.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectorNumAtms.ValueChanged += new System.EventHandler(this.selectorNumAtms_ValueChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(228, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(188, 46);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose the number of ATMs you wish to simulate";
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 427);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.selectorNumAtms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Launch";
            this.Text = "Launch";
            ((System.ComponentModel.ISupportInitialize)(this.selectorNumAtms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown selectorNumAtms;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label3;
    }
}