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
            this.testBtn1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.testBtn2 = new System.Windows.Forms.Button();
            this.testBtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testBtn1
            // 
            this.testBtn1.Location = new System.Drawing.Point(12, 615);
            this.testBtn1.Name = "testBtn1";
            this.testBtn1.Size = new System.Drawing.Size(150, 46);
            this.testBtn1.TabIndex = 0;
            this.testBtn1.Text = "Test Button 1";
            this.testBtn1.UseVisualStyleBackColor = true;
            this.testBtn1.Click += new System.EventHandler(this.testBtn1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(264, 73);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(451, 55);
            this.title.TabIndex = 1;
            this.title.Text = "Bank of Kleptocracy";
            // 
            // testBtn2
            // 
            this.testBtn2.Location = new System.Drawing.Point(168, 615);
            this.testBtn2.Name = "testBtn2";
            this.testBtn2.Size = new System.Drawing.Size(150, 46);
            this.testBtn2.TabIndex = 2;
            this.testBtn2.Text = "Test Button 2";
            this.testBtn2.UseVisualStyleBackColor = true;
            this.testBtn2.Click += new System.EventHandler(this.testBtn2_Click);
            // 
            // testBtn3
            // 
            this.testBtn3.Location = new System.Drawing.Point(324, 615);
            this.testBtn3.Name = "testBtn3";
            this.testBtn3.Size = new System.Drawing.Size(150, 46);
            this.testBtn3.TabIndex = 3;
            this.testBtn3.Text = "Test Button 3";
            this.testBtn3.UseVisualStyleBackColor = true;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Bank_of_Kleptocracy.Properties.Resources.sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 673);
            this.Controls.Add(this.testBtn3);
            this.Controls.Add(this.testBtn2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.testBtn1);
            this.Name = "ATM";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.ATM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testBtn1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button testBtn2;
        private System.Windows.Forms.Button testBtn3;
    }
}