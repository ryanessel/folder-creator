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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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

            // purpose is to get the 
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();



            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            // related to this --> idk why folderBrowserDialog1.SelectedPath= currentDirectory;
            DialogResult result = folderDlg1.ShowDialog();

            txtCurrentDirBox.Text = folderDlg1.SelectedPath;
            if(folderDlg1.SelectedPath == "")
            {
                return;
            }

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
                string originalDirectory = Directory.GetCurrentDirectory();
                Directory.CreateDirectory($"{txtFolderName.Text}");
                Directory.SetCurrentDirectory($"{Directory.GetCurrentDirectory()}" +  $"\\{txtFolderName.Text}");
                //MessageBox.Show(Directory.GetCurrentDirectory());
                Process.Start("explorer.exe", ".");
                txtFolderName.Text = "";
                //new---> pupose is to reset to selected dir but not the folder you just made
                if(comboBox1.SelectedIndex == 0) Directory.SetCurrentDirectory(siemensPath);
                if(comboBox1.SelectedIndex == 1) Directory.SetCurrentDirectory(plidcoPath);

                txtCurrentDirBox.Text= Directory.GetCurrentDirectory();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

         string plidcoPath  =  "C:\\Users\\spuct\\Dropbox\\NCA WORK\\Work Files\\PLIDCO\\NCA POs";
        string siemensPath = "C:\\Users\\spuct\\Dropbox\\NCA WORK\\Work Files\\SIEMENS PO + Siemens Documents";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex== 0) 
            {
                Directory.SetCurrentDirectory("C:\\Users\\spuct\\Dropbox\\NCA WORK\\Work Files\\SIEMENS PO + Siemens Documents");
                txtCurrentDirBox.Text = "C:\\Users\\spuct\\Dropbox\\NCA WORK\\Work Files\\SIEMENS PO + Siemens Documents";
            }

            if (comboBox1.SelectedIndex == 1)
            {
                
                Directory.SetCurrentDirectory("C:\\Users\\spuct\\Dropbox\\NCA WORK\\Work Files\\PLIDCO\\NCA POs");
                txtCurrentDirBox.Text = "C:\\Users\\spuct\\Dropbox\\NCA WORK\\Work Files\\PLIDCO\\NCA POs";

            }
        }

        private void btnOpenCurrentDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", ".");
            }
            catch (Exception ex)
            {
                // Handle the exception here.
            }
        }

        private void txtCurrentDirBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
