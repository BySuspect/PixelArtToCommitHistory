using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private async void btnCommit_Click(object sender, EventArgs e)
        {
            btnCommit.Enabled = false;

            if (DateTime.Compare(dtpStart.Value.Date, dtpEnd.Value.Date) >= 0)
            {
                MessageBox.Show("Start date cannot be greater or equal than end date.");
                btnCommit.Enabled = true;
                return;
            }

            if (txtFolderPath.Text == "")
            {
                MessageBox.Show("Please enter a folder path!");
                btnCommit.Enabled = true;
                return;
            }
            else
            {
                if (!System.IO.Directory.Exists(txtFolderPath.Text))
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
                if (!System.IO.File.Exists(txtImagePath.Text))
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
                    dtpStart.Value,
                    dtpEnd.Value
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
            MessageBox.Show("Done!");

            btnPush.Enabled = true;
        }
    }
}
