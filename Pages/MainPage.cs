using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PixelArtToCommitHistory.Helpers;

namespace PixelArtToCommitHistory.Pages
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            var yearList = new List<string>();
            for (int i = 2024; i >= 2001; i--)
            {
                yearList.Add(i.ToString());
            }
            cbYear.Items.AddRange(yearList.ToArray());

            cbYear.SelectedIndex = 0;

            CommitHelper.CommitProgressBar = pbCommit;
        }

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            if (cbYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a year!");
                return;
            }
            btnCommit.Enabled = false;

            if (txtFolderPath.Text == "")
            {
                MessageBox.Show("Please enter a folder path!");
                btnCommit.Enabled = true;
                return;
            }
            else
            {
                if (!Directory.Exists(txtFolderPath.Text))
                {
                    MessageBox.Show("Folder path does not exist!");
                    btnCommit.Enabled = true;
                    return;
                }
            }

            if (txtImagePath.Text == "")
            {
                MessageBox.Show("Please enter a image path!");
                btnCommit.Enabled = true;
                return;
            }
            else
            {
                if (!File.Exists(txtImagePath.Text))
                {
                    MessageBox.Show("Image path does not exist!");
                    btnCommit.Enabled = true;
                    return;
                }
            }

            try
            {
                await CommitHelper.StartCommit(
                    txtImagePath.Text,
                    txtFolderPath.Text,
                    int.Parse((string)cbYear.SelectedItem)
                );
                MessageBox.Show("Commits are redy for push!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnCommit.Enabled = true;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            btnPush.Enabled = false;

            if (txtFolderPath.Text == "")
            {
                MessageBox.Show("Please enter a folder path!");
                btnPush.Enabled = true;
                return;
            }
            else
            {
                if (!System.IO.Directory.Exists(txtFolderPath.Text))
                {
                    MessageBox.Show("Folder path does not exist!");
                    btnPush.Enabled = true;
                    return;
                }
            }

            CMDHelper.runCMD("git push", txtFolderPath.Text);
            pbCommit.Value = 0;
            MessageBox.Show("Done!");

            btnPush.Enabled = true;
        }

        private void btnGitFolderSelect_Click(object sender, EventArgs e)
        {
            var dialogRes = FolderDialog.ShowDialog();
            if (dialogRes == DialogResult.OK)
            {
                if (FileDialog.CheckPathExists)
                {
                    var resPath = FolderDialog.SelectedPath;
                    if (Directory.Exists(Path.Combine(resPath, ".git")))
                    {
                        txtFolderPath.Text = resPath;
                    }
                    else
                    {
                        MessageBox.Show(".git was not found in selected path.");
                    }
                }
                else
                {
                    MessageBox.Show("Folder Not Found!");
                }
            }
        }

        private void BtnImagePick_Click(object sender, EventArgs e)
        {
            var dialogRes = FileDialog.ShowDialog();
            if (dialogRes == DialogResult.OK)
            {
                if (FileDialog.CheckFileExists)
                {
                    if (
                        FileDialog.FileName.EndsWith(".png")
                        || FileDialog.FileName.EndsWith(".jpg")
                        || FileDialog.FileName.EndsWith(".jpeg")
                    )
                    {
                        Bitmap image = new Bitmap(FileDialog.FileName);
                        if (image.Width == 53 && image.Height == 7)
                        {
                            txtImagePath.Text = FileDialog.FileName;
                        }
                        else
                        {
                            MessageBox.Show("Image size must be 51x7!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a image file!");
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found!");
                }
            }
        }

        #region Mouse move codes
        private Point _mouseLoc;

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
        #endregion
    }
}
