namespace async_programming
{
    partial class Form1
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
            this.lblBook1 = new System.Windows.Forms.Label();
            this.txtBook1 = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.lblBook2 = new System.Windows.Forms.Label();
            this.txtBook2 = new System.Windows.Forms.TextBox();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstResults1 = new System.Windows.Forms.ListBox();
            this.lstResults2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblBook1
            // 
            this.lblBook1.AutoSize = true;
            this.lblBook1.Location = new System.Drawing.Point(16, 22);
            this.lblBook1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBook1.Name = "lblBook1";
            this.lblBook1.Size = new System.Drawing.Size(49, 16);
            this.lblBook1.TabIndex = 0;
            this.lblBook1.Text = "Book 1";
            // 
            // txtBook1
            // 
            this.txtBook1.Location = new System.Drawing.Point(81, 18);
            this.txtBook1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBook1.Name = "txtBook1";
            this.txtBook1.ReadOnly = true;
            this.txtBook1.Size = new System.Drawing.Size(265, 22);
            this.txtBook1.TabIndex = 1;
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(356, 16);
            this.btnBrowse1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(93, 28);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "Browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // lblBook2
            // 
            this.lblBook2.AutoSize = true;
            this.lblBook2.Location = new System.Drawing.Point(493, 22);
            this.lblBook2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBook2.Name = "lblBook2";
            this.lblBook2.Size = new System.Drawing.Size(49, 16);
            this.lblBook2.TabIndex = 3;
            this.lblBook2.Text = "Book 2";
            // 
            // txtBook2
            // 
            this.txtBook2.Location = new System.Drawing.Point(559, 18);
            this.txtBook2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBook2.Name = "txtBook2";
            this.txtBook2.ReadOnly = true;
            this.txtBook2.Size = new System.Drawing.Size(265, 22);
            this.txtBook2.TabIndex = 4;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(833, 16);
            this.btnBrowse2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(93, 28);
            this.btnBrowse2.TabIndex = 5;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(293, 55);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(413, 55);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstResults1
            // 
            this.lstResults1.FormattingEnabled = true;
            this.lstResults1.ItemHeight = 16;
            this.lstResults1.Location = new System.Drawing.Point(16, 98);
            this.lstResults1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstResults1.Name = "lstResults1";
            this.lstResults1.Size = new System.Drawing.Size(452, 404);
            this.lstResults1.TabIndex = 8;
            // 
            // lstResults2
            // 
            this.lstResults2.FormattingEnabled = true;
            this.lstResults2.ItemHeight = 16;
            this.lstResults2.Location = new System.Drawing.Point(483, 98);
            this.lstResults2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstResults2.Name = "lstResults2";
            this.lstResults2.Size = new System.Drawing.Size(452, 404);
            this.lstResults2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 522);
            this.Controls.Add(this.lstResults2);
            this.Controls.Add(this.lstResults1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.txtBook2);
            this.Controls.Add(this.lblBook2);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.txtBook1);
            this.Controls.Add(this.lblBook1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Word Count Comparison";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBook1;
        private System.Windows.Forms.TextBox txtBook1;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Label lblBook2;
        private System.Windows.Forms.TextBox txtBook2;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstResults1;
        private System.Windows.Forms.ListBox lstResults2;
    }
}
