﻿namespace LoginPanel
{
    partial class frmFileSync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileSync));
            this.btnStartSync = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblSrc = new System.Windows.Forms.Label();
            this.dialogChooseSrcFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBoxSrc = new System.Windows.Forms.ListBox();
            this.sourceFolderPictureBox = new System.Windows.Forms.PictureBox();
            this.btnStopSync = new System.Windows.Forms.Button();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.lblSyncStarted = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.destinationFolderPictureBox = new System.Windows.Forms.PictureBox();
            this.lstBoxDestination = new System.Windows.Forms.ListBox();
            this.dialogChooseDestFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnMoveDirectory = new System.Windows.Forms.Button();
            this.btnDeleteDirectory = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFolderPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationFolderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartSync
            // 
            this.btnStartSync.Location = new System.Drawing.Point(314, 217);
            this.btnStartSync.Name = "btnStartSync";
            this.btnStartSync.Size = new System.Drawing.Size(92, 35);
            this.btnStartSync.TabIndex = 0;
            this.btnStartSync.Text = "Start Sync";
            this.btnStartSync.UseVisualStyleBackColor = true;
            this.btnStartSync.Click += new System.EventHandler(this.btnStartSync_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // lblSrc
            // 
            this.lblSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSrc.Location = new System.Drawing.Point(134, 31);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(446, 29);
            this.lblSrc.TabIndex = 1;
            this.lblSrc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose a folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Folder Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Folder Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Choose a folder:";
            // 
            // lblDest
            // 
            this.lblDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDest.Location = new System.Drawing.Point(127, 31);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(446, 29);
            this.lblDest.TabIndex = 5;
            this.lblDest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxSrc);
            this.groupBox1.Controls.Add(this.sourceFolderPictureBox);
            this.groupBox1.Controls.Add(this.lblSrc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 198);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Directory";
            // 
            // lstBoxSrc
            // 
            this.lstBoxSrc.FormattingEnabled = true;
            this.lstBoxSrc.HorizontalScrollbar = true;
            this.lstBoxSrc.Location = new System.Drawing.Point(13, 66);
            this.lstBoxSrc.Name = "lstBoxSrc";
            this.lstBoxSrc.Size = new System.Drawing.Size(567, 121);
            this.lstBoxSrc.TabIndex = 10;
            // 
            // sourceFolderPictureBox
            // 
            this.sourceFolderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("sourceFolderPictureBox.Image")));
            this.sourceFolderPictureBox.Location = new System.Drawing.Point(94, 26);
            this.sourceFolderPictureBox.Name = "sourceFolderPictureBox";
            this.sourceFolderPictureBox.Size = new System.Drawing.Size(34, 34);
            this.sourceFolderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourceFolderPictureBox.TabIndex = 5;
            this.sourceFolderPictureBox.TabStop = false;
            this.sourceFolderPictureBox.Click += new System.EventHandler(this.sourceFolderPictureBox_Click);
            // 
            // btnStopSync
            // 
            this.btnStopSync.Location = new System.Drawing.Point(412, 217);
            this.btnStopSync.Name = "btnStopSync";
            this.btnStopSync.Size = new System.Drawing.Size(92, 35);
            this.btnStopSync.TabIndex = 11;
            this.btnStopSync.Text = "Stop Sync";
            this.btnStopSync.UseVisualStyleBackColor = true;
            this.btnStopSync.Click += new System.EventHandler(this.btnStopSync_Click);
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElapsedTime.Location = new System.Drawing.Point(520, 220);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(193, 29);
            this.lblElapsedTime.TabIndex = 1;
            this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSyncStarted
            // 
            this.lblSyncStarted.AutoSize = true;
            this.lblSyncStarted.Location = new System.Drawing.Point(719, 228);
            this.lblSyncStarted.Name = "lblSyncStarted";
            this.lblSyncStarted.Size = new System.Drawing.Size(74, 13);
            this.lblSyncStarted.TabIndex = 0;
            this.lblSyncStarted.Text = "Sync Stopped";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.destinationFolderPictureBox);
            this.groupBox2.Controls.Add(this.lstBoxDestination);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDest);
            this.groupBox2.Location = new System.Drawing.Point(632, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 198);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination Directory";
            // 
            // destinationFolderPictureBox
            // 
            this.destinationFolderPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("destinationFolderPictureBox.Image")));
            this.destinationFolderPictureBox.Location = new System.Drawing.Point(88, 26);
            this.destinationFolderPictureBox.Name = "destinationFolderPictureBox";
            this.destinationFolderPictureBox.Size = new System.Drawing.Size(34, 34);
            this.destinationFolderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.destinationFolderPictureBox.TabIndex = 9;
            this.destinationFolderPictureBox.TabStop = false;
            this.destinationFolderPictureBox.Click += new System.EventHandler(this.destinationFolderPictureBox_Click);
            // 
            // lstBoxDestination
            // 
            this.lstBoxDestination.FormattingEnabled = true;
            this.lstBoxDestination.HorizontalScrollbar = true;
            this.lstBoxDestination.Location = new System.Drawing.Point(6, 66);
            this.lstBoxDestination.Name = "lstBoxDestination";
            this.lstBoxDestination.Size = new System.Drawing.Size(567, 121);
            this.lstBoxDestination.TabIndex = 5;
            // 
            // btnMoveDirectory
            // 
            this.btnMoveDirectory.Location = new System.Drawing.Point(804, 218);
            this.btnMoveDirectory.Name = "btnMoveDirectory";
            this.btnMoveDirectory.Size = new System.Drawing.Size(89, 35);
            this.btnMoveDirectory.TabIndex = 11;
            this.btnMoveDirectory.Text = "Move Source Directory";
            this.btnMoveDirectory.UseVisualStyleBackColor = true;
            this.btnMoveDirectory.Click += new System.EventHandler(this.btnMoveDirectory_Click);
            // 
            // btnDeleteDirectory
            // 
            this.btnDeleteDirectory.Location = new System.Drawing.Point(899, 218);
            this.btnDeleteDirectory.Name = "btnDeleteDirectory";
            this.btnDeleteDirectory.Size = new System.Drawing.Size(92, 35);
            this.btnDeleteDirectory.TabIndex = 12;
            this.btnDeleteDirectory.Text = "Delete Source Directory";
            this.btnDeleteDirectory.UseVisualStyleBackColor = true;
            this.btnDeleteDirectory.Click += new System.EventHandler(this.btnDeleteDirectory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "TO";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 5);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 7);
            this.panel1.TabIndex = 14;
            // 
            // frmFileSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 265);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStopSync);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.btnStartSync);
            this.Controls.Add(this.btnDeleteDirectory);
            this.Controls.Add(this.lblSyncStarted);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMoveDirectory);
            this.Name = "frmFileSync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Sync";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFolderPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationFolderPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSync;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.FolderBrowserDialog dialogChooseSrcFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog dialogChooseDestFolder;
        private System.Windows.Forms.Button btnMoveDirectory;
        private System.Windows.Forms.Button btnDeleteDirectory;
        private System.Windows.Forms.ListBox lstBoxDestination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSyncStarted;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.PictureBox sourceFolderPictureBox;
        private System.Windows.Forms.PictureBox destinationFolderPictureBox;
        private System.Windows.Forms.ListBox lstBoxSrc;
        private System.Windows.Forms.Button btnStopSync;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

