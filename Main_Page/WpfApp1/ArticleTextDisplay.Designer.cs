﻿namespace Egkyklopaideia
{
    partial class ArticleTextDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelText = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(347, 170);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(108, 13);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Εδώ θα μπει κείμενο";
            this.labelText.Click += new System.EventHandler(this.labelText_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(817, 406);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://users.it.teithe.gr/~it154474/American_English.html", System.UriKind.Absolute);
            // 
            // ArticleTextDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.labelText);
            this.Name = "ArticleTextDisplay";
            this.Size = new System.Drawing.Size(817, 406);
            this.Load += new System.EventHandler(this.ArticleTextDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.WebBrowser webBrowser1;
        
        public System.Windows.Forms.WebBrowser get() { return webBrowser1; }
    }
}
