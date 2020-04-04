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
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.Black;
            this.logBox.ForeColor = System.Drawing.Color.Lime;
            this.logBox.Location = new System.Drawing.Point(14, 36);
            this.logBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(1032, 792);
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
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 841);
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
    }
}

