namespace PixelArtToCommitHistory.Pages
{
    partial class ProgressPage
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
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pbar
            // 
            this.pbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbar.Location = new System.Drawing.Point(0, 0);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(431, 10);
            this.pbar.TabIndex = 0;
            // 
            // ProgressPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 10);
            this.Controls.Add(this.pbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProgressPage";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar pbar;
    }
}