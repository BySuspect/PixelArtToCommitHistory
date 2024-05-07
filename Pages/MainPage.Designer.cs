namespace PixelArtToCommitHistory.Pages
{
    partial class MainPage
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
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnGitFolderSelect = new System.Windows.Forms.Button();
            this.BtnImagePick = new System.Windows.Forms.Button();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(15, 163);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(92, 23);
            this.btnCommit.TabIndex = 5;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(122, 163);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(92, 23);
            this.btnPush.TabIndex = 6;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(15, 84);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(199, 20);
            this.txtFolderPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Git Folder Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Image Path:";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(15, 123);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(199, 20);
            this.txtImagePath.TabIndex = 3;
            // 
            // btnGitFolderSelect
            // 
            this.btnGitFolderSelect.Location = new System.Drawing.Point(220, 84);
            this.btnGitFolderSelect.Name = "btnGitFolderSelect";
            this.btnGitFolderSelect.Size = new System.Drawing.Size(51, 20);
            this.btnGitFolderSelect.TabIndex = 2;
            this.btnGitFolderSelect.Text = "Pick";
            this.btnGitFolderSelect.UseVisualStyleBackColor = true;
            this.btnGitFolderSelect.Click += new System.EventHandler(this.btnGitFolderSelect_Click);
            // 
            // BtnImagePick
            // 
            this.BtnImagePick.Location = new System.Drawing.Point(220, 123);
            this.BtnImagePick.Name = "BtnImagePick";
            this.BtnImagePick.Size = new System.Drawing.Size(51, 20);
            this.BtnImagePick.TabIndex = 4;
            this.BtnImagePick.Text = "Pick";
            this.BtnImagePick.UseVisualStyleBackColor = true;
            this.BtnImagePick.Click += new System.EventHandler(this.BtnImagePick_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(15, 43);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(199, 21);
            this.cbYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Year";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 202);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.BtnImagePick);
            this.Controls.Add(this.btnGitFolderSelect);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnGitFolderSelect;
        private System.Windows.Forms.Button BtnImagePick;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label1;
    }
}