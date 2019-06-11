namespace LoginPanel
{
    partial class frmFTP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFTP));
            this.lstBoxRootDirs = new System.Windows.Forms.ListBox();
            this.lstBoxFtpStatus = new System.Windows.Forms.ListBox();
            this.lstBoxDirContents1 = new System.Windows.Forms.ListBox();
            this.txtBoxFilename = new System.Windows.Forms.TextBox();
            this.txtBoxCurrDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBoxDirContents2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPword = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxHostname = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.lblConnectStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUploadFilename = new System.Windows.Forms.Label();
            this.lblDistPath = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOpsStatus = new System.Windows.Forms.Label();
            this.toolTipHostname = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dialogOpenDestFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.dialogOpenFileToUpload = new System.Windows.Forms.OpenFileDialog();
            this.toolTipDownload = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUpload = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxUpload = new System.Windows.Forms.PictureBox();
            this.picBoxDelete = new System.Windows.Forms.PictureBox();
            this.picBoxDownload = new System.Windows.Forms.PictureBox();
            this.openFilePictureBox = new System.Windows.Forms.PictureBox();
            this.openFolderPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBoxRootDirs
            // 
            this.lstBoxRootDirs.FormattingEnabled = true;
            this.lstBoxRootDirs.HorizontalScrollbar = true;
            this.lstBoxRootDirs.Location = new System.Drawing.Point(12, 143);
            this.lstBoxRootDirs.Name = "lstBoxRootDirs";
            this.lstBoxRootDirs.Size = new System.Drawing.Size(420, 173);
            this.lstBoxRootDirs.TabIndex = 3;
            this.lstBoxRootDirs.SelectedIndexChanged += new System.EventHandler(this.lstBoxRootDirs_SelectedIndexChanged);
            // 
            // lstBoxFtpStatus
            // 
            this.lstBoxFtpStatus.FormattingEnabled = true;
            this.lstBoxFtpStatus.HorizontalScrollbar = true;
            this.lstBoxFtpStatus.Location = new System.Drawing.Point(12, 322);
            this.lstBoxFtpStatus.Name = "lstBoxFtpStatus";
            this.lstBoxFtpStatus.Size = new System.Drawing.Size(894, 95);
            this.lstBoxFtpStatus.TabIndex = 10;
            // 
            // lstBoxDirContents1
            // 
            this.lstBoxDirContents1.FormattingEnabled = true;
            this.lstBoxDirContents1.Location = new System.Drawing.Point(460, 143);
            this.lstBoxDirContents1.Name = "lstBoxDirContents1";
            this.lstBoxDirContents1.Size = new System.Drawing.Size(446, 173);
            this.lstBoxDirContents1.TabIndex = 12;
            this.lstBoxDirContents1.SelectedIndexChanged += new System.EventHandler(this.lstBoxDirContents1_SelectedIndexChanged);
            // 
            // txtBoxFilename
            // 
            this.txtBoxFilename.Location = new System.Drawing.Point(153, 38);
            this.txtBoxFilename.Name = "txtBoxFilename";
            this.txtBoxFilename.Size = new System.Drawing.Size(147, 20);
            this.txtBoxFilename.TabIndex = 13;
            // 
            // txtBoxCurrDir
            // 
            this.txtBoxCurrDir.Location = new System.Drawing.Point(6, 38);
            this.txtBoxCurrDir.Name = "txtBoxCurrDir";
            this.txtBoxCurrDir.Size = new System.Drawing.Size(141, 20);
            this.txtBoxCurrDir.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Selected Directory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "File to Download/Delete:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Destination Path:";
            // 
            // lstBoxDirContents2
            // 
            this.lstBoxDirContents2.FormattingEnabled = true;
            this.lstBoxDirContents2.HorizontalScrollbar = true;
            this.lstBoxDirContents2.Location = new System.Drawing.Point(934, 149);
            this.lstBoxDirContents2.Name = "lstBoxDirContents2";
            this.lstBoxDirContents2.Size = new System.Drawing.Size(282, 264);
            this.lstBoxDirContents2.TabIndex = 19;
            this.lstBoxDirContents2.SelectedIndexChanged += new System.EventHandler(this.lstBoxDirContents2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxPword);
            this.groupBox1.Controls.Add(this.txtBoxUsername);
            this.groupBox1.Controls.Add(this.txtBoxHostname);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.lblConnectStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 125);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to FTP Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hostname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username:";
            // 
            // txtBoxPword
            // 
            this.txtBoxPword.Location = new System.Drawing.Point(283, 42);
            this.txtBoxPword.Name = "txtBoxPword";
            this.txtBoxPword.Size = new System.Drawing.Size(127, 20);
            this.txtBoxPword.TabIndex = 14;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(147, 42);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(127, 20);
            this.txtBoxUsername.TabIndex = 13;
            // 
            // txtBoxHostname
            // 
            this.txtBoxHostname.Location = new System.Drawing.Point(10, 42);
            this.txtBoxHostname.Name = "txtBoxHostname";
            this.txtBoxHostname.Size = new System.Drawing.Size(127, 20);
            this.txtBoxHostname.TabIndex = 12;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(332, 75);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(78, 35);
            this.connectButton.TabIndex = 11;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnectStatus.Location = new System.Drawing.Point(10, 75);
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(316, 35);
            this.lblConnectStatus.TabIndex = 10;
            this.lblConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBoxUpload);
            this.groupBox2.Controls.Add(this.picBoxDelete);
            this.groupBox2.Controls.Add(this.picBoxDownload);
            this.groupBox2.Controls.Add(this.openFilePictureBox);
            this.groupBox2.Controls.Add(this.lblUploadFilename);
            this.groupBox2.Controls.Add(this.lblDistPath);
            this.groupBox2.Controls.Add(this.openFolderPictureBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblOpsStatus);
            this.groupBox2.Controls.Add(this.txtBoxFilename);
            this.groupBox2.Controls.Add(this.txtBoxCurrDir);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(460, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 125);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download/Upload/Delete File";
            // 
            // lblUploadFilename
            // 
            this.lblUploadFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUploadFilename.Location = new System.Drawing.Point(356, 76);
            this.lblUploadFilename.Name = "lblUploadFilename";
            this.lblUploadFilename.Size = new System.Drawing.Size(271, 27);
            this.lblUploadFilename.TabIndex = 25;
            this.lblUploadFilename.Text = "No File Selected";
            this.lblUploadFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistPath
            // 
            this.lblDistPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistPath.Location = new System.Drawing.Point(356, 27);
            this.lblDistPath.Name = "lblDistPath";
            this.lblDistPath.Size = new System.Drawing.Size(271, 27);
            this.lblDistPath.TabIndex = 24;
            this.lblDistPath.Text = "No Path Selected";
            this.lblDistPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "File to Upload:";
            // 
            // lblOpsStatus
            // 
            this.lblOpsStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpsStatus.Location = new System.Drawing.Point(152, 72);
            this.lblOpsStatus.Name = "lblOpsStatus";
            this.lblOpsStatus.Size = new System.Drawing.Size(161, 50);
            this.lblOpsStatus.TabIndex = 22;
            this.lblOpsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 5);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 7);
            this.panel1.TabIndex = 26;
            // 
            // dialogOpenFileToUpload
            // 
            this.dialogOpenFileToUpload.FileName = "dialogOpenFileToUpload";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(907, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(433, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxUpload
            // 
            this.picBoxUpload.BackColor = System.Drawing.Color.Transparent;
            this.picBoxUpload.Image = global::LoginPanel.Properties.Resources.upload;
            this.picBoxUpload.Location = new System.Drawing.Point(59, 72);
            this.picBoxUpload.Name = "picBoxUpload";
            this.picBoxUpload.Size = new System.Drawing.Size(37, 38);
            this.picBoxUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUpload.TabIndex = 29;
            this.picBoxUpload.TabStop = false;
            this.picBoxUpload.Click += new System.EventHandler(this.picBoxUpload_Click);
            // 
            // picBoxDelete
            // 
            this.picBoxDelete.Image = global::LoginPanel.Properties.Resources.icons8_delete_32;
            this.picBoxDelete.Location = new System.Drawing.Point(109, 72);
            this.picBoxDelete.Name = "picBoxDelete";
            this.picBoxDelete.Size = new System.Drawing.Size(37, 38);
            this.picBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDelete.TabIndex = 28;
            this.picBoxDelete.TabStop = false;
            this.picBoxDelete.Click += new System.EventHandler(this.picBoxDelete_Click);
            // 
            // picBoxDownload
            // 
            this.picBoxDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxDownload.Image = global::LoginPanel.Properties.Resources.icons8_download_from_the_cloud_32;
            this.picBoxDownload.Location = new System.Drawing.Point(9, 72);
            this.picBoxDownload.Name = "picBoxDownload";
            this.picBoxDownload.Size = new System.Drawing.Size(37, 38);
            this.picBoxDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDownload.TabIndex = 27;
            this.picBoxDownload.TabStop = false;
            this.picBoxDownload.Click += new System.EventHandler(this.picBoxDownload_Click);
            // 
            // openFilePictureBox
            // 
            this.openFilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("openFilePictureBox.Image")));
            this.openFilePictureBox.Location = new System.Drawing.Point(319, 72);
            this.openFilePictureBox.Name = "openFilePictureBox";
            this.openFilePictureBox.Size = new System.Drawing.Size(34, 34);
            this.openFilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openFilePictureBox.TabIndex = 26;
            this.openFilePictureBox.TabStop = false;
            this.openFilePictureBox.Click += new System.EventHandler(this.picBoxOpenFileToUpload_Click);
            // 
            // openFolderPictureBox
            // 
            this.openFolderPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openFolderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("openFolderPictureBox.Image")));
            this.openFolderPictureBox.Location = new System.Drawing.Point(319, 22);
            this.openFolderPictureBox.Name = "openFolderPictureBox";
            this.openFolderPictureBox.Size = new System.Drawing.Size(34, 34);
            this.openFolderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openFolderPictureBox.TabIndex = 23;
            this.openFolderPictureBox.TabStop = false;
            this.openFolderPictureBox.Click += new System.EventHandler(this.picBoxOpenDestFolder_Click);
            // 
            // frmFTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1228, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstBoxDirContents2);
            this.Controls.Add(this.lstBoxDirContents1);
            this.Controls.Add(this.lstBoxFtpStatus);
            this.Controls.Add(this.lstBoxRootDirs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFolderPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstBoxRootDirs;
        private System.Windows.Forms.ListBox lstBoxFtpStatus;
        private System.Windows.Forms.ListBox lstBoxDirContents1;
        private System.Windows.Forms.TextBox txtBoxFilename;
        private System.Windows.Forms.TextBox txtBoxCurrDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstBoxDirContents2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPword;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxHostname;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label lblConnectStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOpsStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTipHostname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog dialogOpenDestFolder;
        private System.Windows.Forms.Label lblDistPath;
        private System.Windows.Forms.PictureBox openFolderPictureBox;
        private System.Windows.Forms.OpenFileDialog dialogOpenFileToUpload;
        private System.Windows.Forms.PictureBox openFilePictureBox;
        private System.Windows.Forms.Label lblUploadFilename;
        private System.Windows.Forms.PictureBox picBoxDownload;
        private System.Windows.Forms.PictureBox picBoxDelete;
        private System.Windows.Forms.PictureBox picBoxUpload;
        private System.Windows.Forms.ToolTip toolTipDownload;
        private System.Windows.Forms.ToolTip toolTipUpload;
        private System.Windows.Forms.ToolTip toolTipDelete;
    }
}

