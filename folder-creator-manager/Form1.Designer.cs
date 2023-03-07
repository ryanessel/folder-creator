namespace folder_creator_manager
{
    partial class FrmFolderCreator3000
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
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseFldrPath = new System.Windows.Forms.Button();
            this.txtCurrentDirBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOpenCurrentDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFolder.Location = new System.Drawing.Point(12, 274);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(151, 40);
            this.btnCreateFolder.TabIndex = 0;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder Name ";
            // 
            // txtFolderName
            // 
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.Location = new System.Drawing.Point(12, 242);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(151, 26);
            this.txtFolderName.TabIndex = 2;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btnChooseFldrPath
            // 
            this.btnChooseFldrPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFldrPath.Location = new System.Drawing.Point(12, 24);
            this.btnChooseFldrPath.Name = "btnChooseFldrPath";
            this.btnChooseFldrPath.Size = new System.Drawing.Size(196, 40);
            this.btnChooseFldrPath.TabIndex = 0;
            this.btnChooseFldrPath.Text = "Choose Folder Path";
            this.btnChooseFldrPath.UseVisualStyleBackColor = true;
            this.btnChooseFldrPath.Click += new System.EventHandler(this.btnChooseFldrPath_Click);
            // 
            // txtCurrentDirBox
            // 
            this.txtCurrentDirBox.Enabled = false;
            this.txtCurrentDirBox.Location = new System.Drawing.Point(215, 24);
            this.txtCurrentDirBox.Multiline = true;
            this.txtCurrentDirBox.Name = "txtCurrentDirBox";
            this.txtCurrentDirBox.Size = new System.Drawing.Size(316, 40);
            this.txtCurrentDirBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "POs to SIEMENS",
            "POs to PLIDCO"});
            this.comboBox1.Location = new System.Drawing.Point(16, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // btnOpenCurrentDirectory
            // 
            this.btnOpenCurrentDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCurrentDirectory.Location = new System.Drawing.Point(215, 70);
            this.btnOpenCurrentDirectory.Name = "btnOpenCurrentDirectory";
            this.btnOpenCurrentDirectory.Size = new System.Drawing.Size(316, 40);
            this.btnOpenCurrentDirectory.TabIndex = 0;
            this.btnOpenCurrentDirectory.Text = "Open Current Directory";
            this.btnOpenCurrentDirectory.UseVisualStyleBackColor = true;
            this.btnOpenCurrentDirectory.Click += new System.EventHandler(this.btnOpenCurrentDirectory_Click);
            // 
            // FrmFolderCreator3000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtCurrentDirBox);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseFldrPath);
            this.Controls.Add(this.btnOpenCurrentDirectory);
            this.Controls.Add(this.btnCreateFolder);
            this.Name = "FrmFolderCreator3000";
            this.Text = "Folder Creator 3000";
            this.Load += new System.EventHandler(this.FrmFolderCreator3000_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnChooseFldrPath;
        private System.Windows.Forms.TextBox txtCurrentDirBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOpenCurrentDirectory;
    }
}

