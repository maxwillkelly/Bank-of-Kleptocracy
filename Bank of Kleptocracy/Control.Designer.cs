namespace Bank_of_Kleptocracy
{
    partial class Control
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.testBtn6 = new System.Windows.Forms.Button();
            this.testBtn5 = new System.Windows.Forms.Button();
            this.testBtn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(918, 580);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 9);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(32, 17);
            this.lblLog.TabIndex = 1;
            this.lblLog.Text = "Log";
            // 
            // testBtn6
            // 
            this.testBtn6.Location = new System.Drawing.Point(324, 615);
            this.testBtn6.Name = "testBtn6";
            this.testBtn6.Size = new System.Drawing.Size(150, 46);
            this.testBtn6.TabIndex = 6;
            this.testBtn6.Text = "Test Button 6";
            this.testBtn6.UseVisualStyleBackColor = true;
            // 
            // testBtn5
            // 
            this.testBtn5.Location = new System.Drawing.Point(168, 615);
            this.testBtn5.Name = "testBtn5";
            this.testBtn5.Size = new System.Drawing.Size(150, 46);
            this.testBtn5.TabIndex = 5;
            this.testBtn5.Text = "Test Button 5";
            this.testBtn5.UseVisualStyleBackColor = true;
            // 
            // testBtn4
            // 
            this.testBtn4.Location = new System.Drawing.Point(12, 615);
            this.testBtn4.Name = "testBtn4";
            this.testBtn4.Size = new System.Drawing.Size(150, 46);
            this.testBtn4.TabIndex = 4;
            this.testBtn4.Text = "Test Button 4";
            this.testBtn4.UseVisualStyleBackColor = true;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 673);
            this.Controls.Add(this.testBtn6);
            this.Controls.Add(this.testBtn5);
            this.Controls.Add(this.testBtn4);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Control";
            this.Text = "Kleptocratic Mission Control ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button testBtn6;
        private System.Windows.Forms.Button testBtn5;
        private System.Windows.Forms.Button testBtn4;
    }
}

