using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPanel
{
    public partial class frmMain : Form
    {
        string name; // user's System name

        public frmMain()
        {
            InitializeComponent();
            name = Environment.UserName;
            welcomeLabel.Text = "Welcome " + name;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            // open frmLogin
            frmLogin fl = new frmLogin(); // create new object of the frmLogin
            fl.Show();
        }

        private void pcInfoLabel_Click(object sender, EventArgs e)
        {
            pcInfoLabel.BackColor = Color.LightSkyBlue;
            infoPicBox.BackColor = Color.LightSkyBlue;

            // open frmResourceInfo
            frmResourceInfo fm = new frmResourceInfo();
            fm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
         
        }

        private void pcInfoLabel_MouseEnter(object sender, EventArgs e)
        {
            
            pcInfoLabel.BackColor = Color.LightBlue;
            infoPicBox.BackColor = Color.LightBlue;
        }

        private void pcInfoLabel_MouseLeave(object sender, EventArgs e)
        {
            pcInfoLabel.BackColor = Color.White;
            infoPicBox.BackColor = Color.White;
        }

        private void directoryOptionsLabel_Click(object sender, EventArgs e)
        {
            directoryOptionsLabel.BackColor = Color.LightSkyBlue;
            directoryPicBox.BackColor = Color.LightSkyBlue;

            // open frmDirectoryOptions
            frmFileSync fm = new frmFileSync();
            fm.ShowDialog();
        }

        private void directoryOptionsLabel_MouseEnter(object sender, EventArgs e)
        {
            directoryOptionsLabel.BackColor = Color.SteelBlue;
            directoryPicBox.BackColor = Color.SteelBlue;
        }

        private void directoryOptionsLabel_MouseLeave(object sender, EventArgs e)
        {
            directoryOptionsLabel.BackColor = Color.CornflowerBlue;
            directoryPicBox.BackColor = Color.CornflowerBlue;
        }

        private void ftpLabel_Click(object sender, EventArgs e)
        {
            ftpLabel.BackColor = Color.LightSkyBlue;
            ftpPicBox.BackColor = Color.LightSkyBlue;

           // open the frmFTP
           frmFTP fmFTP = new frmFTP();
           fmFTP.ShowDialog();
        }

        private void ftpLabel_MouseEnter(object sender, EventArgs e)
        {
            ftpLabel.BackColor = Color.SteelBlue;
            ftpPicBox.BackColor = Color.SteelBlue;
        }

        private void ftpLabel_MouseLeave(object sender, EventArgs e)
        {
            ftpLabel.BackColor = Color.CornflowerBlue;
            ftpPicBox.BackColor = Color.CornflowerBlue;
        }

        private void textEditorLabel_Click(object sender, EventArgs e)
        {
            textEditorLabel.BackColor = Color.LightSkyBlue;
            editorPicBox.BackColor = Color.LightSkyBlue;

            // open frmEditor
            frmEditor fm = new frmEditor();
            fm.ShowDialog();
        }

        private void textEditorLabel_MouseEnter(object sender, EventArgs e)
        {
            textEditorLabel.BackColor = Color.LightBlue;
            editorPicBox.BackColor = Color.LightBlue;
        }

        private void textEditorLabel_MouseLeave(object sender, EventArgs e)
        {
            textEditorLabel.BackColor = Color.White;
            editorPicBox.BackColor = Color.White;
        }

    }
}
