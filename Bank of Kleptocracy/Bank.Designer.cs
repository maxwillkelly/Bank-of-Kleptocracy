namespace Bank_of_Kleptocracy
{
    partial class Bank
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
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.testBtn6 = new System.Windows.Forms.Button();
            this.testBtn5 = new System.Windows.Forms.Button();
            this.testBtn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(14, 36);
            this.logBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(1032, 724);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            this.logBox.WordWrap = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(14, 11);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(37, 20);
            this.lblLog.TabIndex = 1;
            this.lblLog.Text = "Log";
            // 
            // testBtn6
            // 
            this.testBtn6.Location = new System.Drawing.Point(364, 769);
            this.testBtn6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testBtn6.Name = "testBtn6";
            this.testBtn6.Size = new System.Drawing.Size(169, 58);
            this.testBtn6.TabIndex = 6;
            this.testBtn6.Text = "Test Button 6";
            this.testBtn6.UseVisualStyleBackColor = true;
            // 
            // testBtn5
            // 
            this.testBtn5.Location = new System.Drawing.Point(189, 769);
            this.testBtn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testBtn5.Name = "testBtn5";
            this.testBtn5.Size = new System.Drawing.Size(169, 58);
            this.testBtn5.TabIndex = 5;
            this.testBtn5.Text = "Test Button 5";
            this.testBtn5.UseVisualStyleBackColor = true;
            // 
            // testBtn4
            // 
            this.testBtn4.Location = new System.Drawing.Point(14, 769);
            this.testBtn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testBtn4.Name = "testBtn4";
            this.testBtn4.Size = new System.Drawing.Size(169, 58);
            this.testBtn4.TabIndex = 4;
            this.testBtn4.Text = "Test Button 4";
            this.testBtn4.UseVisualStyleBackColor = true;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 841);
            this.Controls.Add(this.testBtn6);
            this.Controls.Add(this.testBtn5);
            this.Controls.Add(this.testBtn4);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.logBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Bank";
            this.Text = "Kleptocratic Mission Control ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button testBtn6;
        private System.Windows.Forms.Button testBtn5;
        private System.Windows.Forms.Button testBtn4;
    }
}

