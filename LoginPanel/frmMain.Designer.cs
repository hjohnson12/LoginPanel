namespace LoginPanel
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ftpLabel = new System.Windows.Forms.Label();
            this.directoryOptionsLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.directoryPicBox = new System.Windows.Forms.PictureBox();
            this.ftpPicBox = new System.Windows.Forms.PictureBox();
            this.editorPicBox = new System.Windows.Forms.PictureBox();
            this.textEditorLabel = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftpPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 5);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 7);
            this.panel1.TabIndex = 14;
            // 
            // ftpLabel
            // 
            this.ftpLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ftpLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ftpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpLabel.ForeColor = System.Drawing.Color.White;
            this.ftpLabel.Location = new System.Drawing.Point(129, 151);
            this.ftpLabel.Name = "ftpLabel";
            this.ftpLabel.Size = new System.Drawing.Size(239, 78);
            this.ftpLabel.TabIndex = 23;
            this.ftpLabel.Text = "&Connect to FTP";
            this.ftpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ftpLabel.Click += new System.EventHandler(this.ftpLabel_Click);
            this.ftpLabel.MouseEnter += new System.EventHandler(this.ftpLabel_MouseEnter);
            this.ftpLabel.MouseLeave += new System.EventHandler(this.ftpLabel_MouseLeave);
            // 
            // directoryOptionsLabel
            // 
            this.directoryOptionsLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.directoryOptionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directoryOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryOptionsLabel.ForeColor = System.Drawing.Color.White;
            this.directoryOptionsLabel.Location = new System.Drawing.Point(262, 63);
            this.directoryOptionsLabel.Name = "directoryOptionsLabel";
            this.directoryOptionsLabel.Size = new System.Drawing.Size(239, 78);
            this.directoryOptionsLabel.TabIndex = 20;
            this.directoryOptionsLabel.Text = "&File Sync";
            this.directoryOptionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.directoryOptionsLabel.Click += new System.EventHandler(this.directoryOptionsLabel_Click);
            this.directoryOptionsLabel.MouseEnter += new System.EventHandler(this.directoryOptionsLabel_MouseEnter);
            this.directoryOptionsLabel.MouseLeave += new System.EventHandler(this.directoryOptionsLabel_MouseLeave);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.welcomeLabel.Location = new System.Drawing.Point(178, 23);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(135, 24);
            this.welcomeLabel.TabIndex = 18;
            this.welcomeLabel.Text = "Welcome User";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // directoryPicBox
            // 
            this.directoryPicBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.directoryPicBox.Image = ((System.Drawing.Image)(resources.GetObject("directoryPicBox.Image")));
            this.directoryPicBox.Location = new System.Drawing.Point(273, 83);
            this.directoryPicBox.Name = "directoryPicBox";
            this.directoryPicBox.Size = new System.Drawing.Size(40, 40);
            this.directoryPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.directoryPicBox.TabIndex = 32;
            this.directoryPicBox.TabStop = false;
            // 
            // ftpPicBox
            // 
            this.ftpPicBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ftpPicBox.Image = ((System.Drawing.Image)(resources.GetObject("ftpPicBox.Image")));
            this.ftpPicBox.Location = new System.Drawing.Point(133, 168);
            this.ftpPicBox.Name = "ftpPicBox";
            this.ftpPicBox.Size = new System.Drawing.Size(51, 44);
            this.ftpPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ftpPicBox.TabIndex = 33;
            this.ftpPicBox.TabStop = false;
            // 
            // editorPicBox
            // 
            this.editorPicBox.BackColor = System.Drawing.Color.White;
            this.editorPicBox.Image = ((System.Drawing.Image)(resources.GetObject("editorPicBox.Image")));
            this.editorPicBox.Location = new System.Drawing.Point(23, 80);
            this.editorPicBox.Name = "editorPicBox";
            this.editorPicBox.Size = new System.Drawing.Size(40, 46);
            this.editorPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editorPicBox.TabIndex = 36;
            this.editorPicBox.TabStop = false;
            // 
            // textEditorLabel
            // 
            this.textEditorLabel.BackColor = System.Drawing.Color.White;
            this.textEditorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEditorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textEditorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditorLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textEditorLabel.Location = new System.Drawing.Point(12, 63);
            this.textEditorLabel.Name = "textEditorLabel";
            this.textEditorLabel.Size = new System.Drawing.Size(239, 78);
            this.textEditorLabel.TabIndex = 35;
            this.textEditorLabel.Text = "&Rich Text Editor";
            this.textEditorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textEditorLabel.Click += new System.EventHandler(this.textEditorLabel_Click);
            this.textEditorLabel.MouseEnter += new System.EventHandler(this.textEditorLabel_MouseEnter);
            this.textEditorLabel.MouseLeave += new System.EventHandler(this.textEditorLabel_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.Location = new System.Drawing.Point(206, 240);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 38);
            this.btnLogout.TabIndex = 37;
            this.btnLogout.Text = "Logo&ut";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 292);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.editorPicBox);
            this.Controls.Add(this.textEditorLabel);
            this.Controls.Add(this.ftpPicBox);
            this.Controls.Add(this.ftpLabel);
            this.Controls.Add(this.directoryPicBox);
            this.Controls.Add(this.directoryOptionsLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftpPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label directoryOptionsLabel;
        private System.Windows.Forms.Label ftpLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.PictureBox directoryPicBox;
        private System.Windows.Forms.PictureBox ftpPicBox;
        private System.Windows.Forms.PictureBox editorPicBox;
        private System.Windows.Forms.Label textEditorLabel;
        private System.Windows.Forms.Button btnLogout;
    }
}