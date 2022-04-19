
namespace ContactsApp.View
{
    partial class AboutForm
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
            this.NameAppLabel = new System.Windows.Forms.Label();
            this.VersionAppLabel = new System.Windows.Forms.Label();
            this.AuthorAppLabel = new System.Windows.Forms.Label();
            this.AuthorEmailLabel = new System.Windows.Forms.Label();
            this.AuthorEmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NameGitLabel = new System.Windows.Forms.Label();
            this.GitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SignatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameAppLabel
            // 
            this.NameAppLabel.AutoSize = true;
            this.NameAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAppLabel.Location = new System.Drawing.Point(10, 11);
            this.NameAppLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameAppLabel.Name = "NameAppLabel";
            this.NameAppLabel.Size = new System.Drawing.Size(128, 24);
            this.NameAppLabel.TabIndex = 0;
            this.NameAppLabel.Text = "ContactsApp";
            // 
            // VersionAppLabel
            // 
            this.VersionAppLabel.AutoSize = true;
            this.VersionAppLabel.Location = new System.Drawing.Point(14, 37);
            this.VersionAppLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionAppLabel.Name = "VersionAppLabel";
            this.VersionAppLabel.Size = new System.Drawing.Size(43, 13);
            this.VersionAppLabel.TabIndex = 1;
            this.VersionAppLabel.Text = "v. 1.0.0";
            // 
            // AuthorAppLabel
            // 
            this.AuthorAppLabel.AutoSize = true;
            this.AuthorAppLabel.Location = new System.Drawing.Point(11, 75);
            this.AuthorAppLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorAppLabel.Name = "AuthorAppLabel";
            this.AuthorAppLabel.Size = new System.Drawing.Size(130, 13);
            this.AuthorAppLabel.TabIndex = 2;
            this.AuthorAppLabel.Text = "Author: Vladimir Ostrovsky";
            // 
            // AuthorEmailLabel
            // 
            this.AuthorEmailLabel.AutoSize = true;
            this.AuthorEmailLabel.Location = new System.Drawing.Point(11, 102);
            this.AuthorEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorEmailLabel.Name = "AuthorEmailLabel";
            this.AuthorEmailLabel.Size = new System.Drawing.Size(100, 13);
            this.AuthorEmailLabel.TabIndex = 3;
            this.AuthorEmailLabel.Text = "e-mail for feedback:";
            // 
            // AuthorEmailLinkLabel
            // 
            this.AuthorEmailLinkLabel.AutoSize = true;
            this.AuthorEmailLinkLabel.Location = new System.Drawing.Point(116, 102);
            this.AuthorEmailLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorEmailLinkLabel.Name = "AuthorEmailLinkLabel";
            this.AuthorEmailLinkLabel.Size = new System.Drawing.Size(152, 13);
            this.AuthorEmailLinkLabel.TabIndex = 4;
            this.AuthorEmailLinkLabel.TabStop = true;
            this.AuthorEmailLinkLabel.Text = "vovuchaostrovsky@gmail.com";
            // 
            // NameGitLabel
            // 
            this.NameGitLabel.AutoSize = true;
            this.NameGitLabel.Location = new System.Drawing.Point(11, 127);
            this.NameGitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameGitLabel.Name = "NameGitLabel";
            this.NameGitLabel.Size = new System.Drawing.Size(41, 13);
            this.NameGitLabel.TabIndex = 5;
            this.NameGitLabel.Text = "Github:";
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.AutoSize = true;
            this.GitLinkLabel.Location = new System.Drawing.Point(56, 127);
            this.GitLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(128, 13);
            this.GitLinkLabel.TabIndex = 6;
            this.GitLinkLabel.TabStop = true;
            this.GitLinkLabel.Text = "VladimirOstr/ContactsApp";
            // 
            // SignatureLabel
            // 
            this.SignatureLabel.AutoSize = true;
            this.SignatureLabel.Location = new System.Drawing.Point(11, 206);
            this.SignatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignatureLabel.Name = "SignatureLabel";
            this.SignatureLabel.Size = new System.Drawing.Size(131, 13);
            this.SignatureLabel.TabIndex = 7;
            this.SignatureLabel.Text = "2022 Vladimir Ostrovsky ®";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 236);
            this.Controls.Add(this.SignatureLabel);
            this.Controls.Add(this.GitLinkLabel);
            this.Controls.Add(this.NameGitLabel);
            this.Controls.Add(this.AuthorEmailLinkLabel);
            this.Controls.Add(this.AuthorEmailLabel);
            this.Controls.Add(this.AuthorAppLabel);
            this.Controls.Add(this.VersionAppLabel);
            this.Controls.Add(this.NameAppLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameAppLabel;
        private System.Windows.Forms.Label VersionAppLabel;
        private System.Windows.Forms.Label AuthorAppLabel;
        private System.Windows.Forms.Label AuthorEmailLabel;
        private System.Windows.Forms.LinkLabel AuthorEmailLinkLabel;
        private System.Windows.Forms.Label NameGitLabel;
        private System.Windows.Forms.LinkLabel GitLinkLabel;
        private System.Windows.Forms.Label SignatureLabel;
    }
}