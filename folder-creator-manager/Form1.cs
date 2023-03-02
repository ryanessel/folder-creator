using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace folder_creator_manager
{
    public partial class FrmFolderCreator3000 : Form
    {
        public FrmFolderCreator3000()
        {
            InitializeComponent();
        }

        private void FrmFolderCreator3000_Load(object sender, EventArgs e)
        {
            if (txtCurrentDirBox.Text == "") txtCurrentDirBox.Text = "Please choose path";
        }
        FolderBrowserDialog folderDlg1 = new FolderBrowserDialog();
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        // Setting Current Directory
        private void btnChooseFldrPath_Click(object sender, EventArgs e)
        {
         
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            DialogResult result = folderDlg1.ShowDialog();
            txtCurrentDirBox.Text = folderDlg1.SelectedPath;
            Directory.SetCurrentDirectory($@"{folderDlg1.SelectedPath}");
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            if (txtFolderName.Text == "")
            {
                MessageBox.Show("Please input a PO# for the folder", "Notice!");
                return;
            }

            else if (Directory.Exists($"{txtFolderName.Text}"))
            {
                MessageBox.Show("A folder with that name Already Exists!", "Alert!");
                return;
            }

            else if (!Directory.Exists($"{txtFolderName.Text}"))
            {

                Directory.CreateDirectory($"{txtFolderName.Text}");
                txtFolderName.Text = "";
            }
        }
    }
}
