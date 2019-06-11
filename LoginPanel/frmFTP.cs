/*
 * Programmer: Hunter Johnson
 * Name: FTP Login
 * Date: 11/1/16 
 */
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
using System.Net;

namespace LoginPanel
{
    public partial class frmFTP : Form
    {
        // global variables
        string filename;
        string filepath;

        public frmFTP()
        {
            InitializeComponent();
            lblConnectStatus.Text = "Not currently logged into FTP Server.";
            lstBoxFtpStatus.Items.Add("Not currently logged into FTP Server.");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtBoxHostname.Text == "" || txtBoxUsername.Text == "" || txtBoxPword.Text == "")
            {
                MessageBox.Show("Make sure to enter a Hostname, Username, and Password.", "Connecting Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lstBoxRootDirs.Items.Clear();
                lstBoxFtpStatus.Items.Clear();

                // call ftpReadFiles()
                ftpReadFiles();
            }
        }


        private void ftpReadFiles()
        {
            try
            {
                // implement a file transfer protocol client
                FtpWebRequest Request = (FtpWebRequest)WebRequest.Create(txtBoxHostname.Text);
                Request.Method = WebRequestMethods.Ftp.ListDirectory;     // request a list of the directory
                Request.Credentials = new NetworkCredential(txtBoxUsername.Text, txtBoxPword.Text); // initialize instance with specified username/password
                FtpWebResponse Response = (FtpWebResponse)Request.GetResponse();   // encapsulates a FTP server's response to a request
                Stream ResponseStream = Response.GetResponseStream();     // provides a generic review of a sequence of bytes - abstract class
                StreamReader Reader = new StreamReader(ResponseStream);  // reads characters from a byte stream in a particular encoding

                lblConnectStatus.Text = Response.WelcomeMessage; // message when authentication is complete
                lstBoxFtpStatus.Items.Add(Response.WelcomeMessage);
                lstBoxFtpStatus.Items.Add("•" + Response.StatusDescription);
                while (!Reader.EndOfStream)//Read file name   
                {
                    lstBoxRootDirs.Items.Add(Reader.ReadLine().ToString());
                }
                lstBoxFtpStatus.Items.Add("•" + Response.StatusDescription);

                // close the Response, ResponseStream, and Reader
                Response.Close();
                ResponseStream.Close();
                Reader.Close();
            }
            catch (Exception ex)
            {
                lstBoxFtpStatus.Items.Add("•" + ex.Message);
            }
        }

        public void DownloadFile(string ftpURL, string UserName, string Password, string ftpDirectory, string FileName, string LocalDirectory)
        {
            if (!File.Exists(LocalDirectory + "/" + FileName))
            {
                try
                {
                    // implement a file transfer protocol client
                    FtpWebRequest requestFileDownload = (FtpWebRequest)WebRequest.Create(ftpURL + "/" + ftpDirectory + "/" + FileName);
                    requestFileDownload.Credentials = new NetworkCredential(UserName, Password);  // pass the credentials
                    requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile;  // download file method
                    FtpWebResponse responseFileDownload = (FtpWebResponse)requestFileDownload.GetResponse();  // response method to the Download
                    Stream responseStream = responseFileDownload.GetResponseStream();   // contains the response data
                    FileStream writeStream = new FileStream(LocalDirectory + "/" + FileName, FileMode.Create);   // writes the file to the directory
                    int Length = 2048;
                    Byte[] buffer = new Byte[Length];
                    int bytesRead = responseStream.Read(buffer, 0, Length);
                    lstBoxFtpStatus.Items.Add("•" + responseFileDownload.StatusDescription);
                    while (bytesRead > 0)  // while there are bytes read
                    {
                        writeStream.Write(buffer, 0, bytesRead);
                        bytesRead = responseStream.Read(buffer, 0, Length);
                    }
                    lstBoxFtpStatus.Items.Add("•" + responseFileDownload.StatusDescription);
                    responseStream.Close();  // close the response stream
                    writeStream.Close(); // close the write stream
                    requestFileDownload = null;   // set to null, to allow a re-call of the function

                    lblOpsStatus.Text = "Download Completed";
                }
                catch (Exception ex)
                {
                    lstBoxFtpStatus.Items.Add("•" + ex.Message);
                    lblOpsStatus.Text = ex.Message;
                }
            }
        }


        public List<string> ShowFiles(string ftpURL, string UserName, string Password, string ftpDirectory)
        {
            // implement a file transfer protocol client
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpURL + "/" + ftpDirectory);
            request.Credentials = new NetworkCredential(UserName, Password);  // pass the credentials
            request.Method = WebRequestMethods.Ftp.ListDirectory;  // request a list of the directory
            FtpWebResponse Response = (FtpWebResponse)request.GetResponse();  // get the response message to the servers request
            StreamReader streamReader = new StreamReader(request.GetResponse().GetResponseStream());  // returns the response

            List<string> lines = new List<string>();
            string line;
            lstBoxFtpStatus.Items.Add("•" + Response.StatusDescription);
            // add the lines to the list
            while ((line = streamReader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            lstBoxFtpStatus.Items.Add("•" + Response.StatusDescription);
            streamReader.Close(); // close the StreamReader
            return lines;
        }

        public void UploadFileToFtp(string filePath, string username, string password)
        {
            try
            {
                string fileName = Path.GetFileName(filePath);
                var directoryPath = lstBoxRootDirs.Text + "/" + lstBoxDirContents1.Text;
                string path = txtBoxHostname.Text + "/" + directoryPath + "/" + fileName;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(path);
                request.Credentials = new NetworkCredential(username, password); // get the credentials

                request.Method = WebRequestMethods.Ftp.UploadFile;  // get the WebRequestMethod for uploading
                // required for data transfer
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                // to avoid having to manually close the fileStream and requestStream
                using (var fileStream = File.OpenRead(filePath))
                {
                    using (var requestStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(requestStream);  // copy the file to the stream
                        requestStream.Close();  // close the requestStream
                    }
                }

                FtpWebResponse Response = (FtpWebResponse)request.GetResponse();  // get the response request
                lstBoxFtpStatus.Items.Add("•" + Response.StatusDescription);
                Response.Close();  // close the response
                lblOpsStatus.Text = "Upload Complete";
            }
            catch (Exception ex)
            {
                lstBoxFtpStatus.Items.Add("•" + ex.Message);
                lblOpsStatus.Text = ex.Message;
            }
        }

        public void DeleteFile(string ftpURL, string UserName, string Password, string ftpDirectory, string FileName)
        {
            // implement a file transfer protocol client
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(ftpURL + "/" + ftpDirectory + "/" + FileName);
            ftpRequest.Credentials = new NetworkCredential(UserName, Password);  // new instance with specified username/password
            ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;   // use the DeleteFile method
            FtpWebResponse responseFileDelete = (FtpWebResponse)ftpRequest.GetResponse();  // encapsulates a FTP server's response to a request
            lstBoxFtpStatus.Items.Add("•" + responseFileDelete.StatusDescription);
        }

        private void lstBoxDirContents1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxCurrDir.Text = lstBoxDirContents1.SelectedItem.ToString();
            lstBoxDirContents2.Items.Clear();
            txtBoxFilename.Clear();
            lblOpsStatus.Text = "";
            var dir = lstBoxRootDirs.SelectedItem.ToString() + "/" + lstBoxDirContents1.Text;
            // show the files
            List<string> files = ShowFiles(txtBoxHostname.Text, txtBoxUsername.Text, txtBoxPword.Text, dir);
            txtBoxCurrDir.Text = lstBoxDirContents1.Text;
            foreach (string item in files)
            {
                lstBoxDirContents2.Items.Add(item);
            }
        }

        private void lstBoxRootDirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBoxDirContents1.Items.Clear();
            List<string> files = ShowFiles(txtBoxHostname.Text, txtBoxUsername.Text, txtBoxPword.Text, lstBoxRootDirs.Text);
            foreach (string item in files)
            {
                lstBoxDirContents1.Items.Add(item);
            }
        }

        private void lstBoxDirContents2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtBoxFilename.Text = Path.GetFileName(lstBoxDirContents2.SelectedItem.ToString());
                // show the files
                var dir = lstBoxRootDirs.Text + "/" + txtBoxCurrDir.Text + "/" + txtBoxFilename.Text;
                List<string> files = ShowFiles(txtBoxHostname.Text, txtBoxUsername.Text, txtBoxPword.Text, dir);
                lstBoxDirContents2.Items.Clear();
                foreach (string file in files)
                {
                    lstBoxDirContents2.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                lstBoxFtpStatus.Items.Add(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // to disable re-sizing of the form
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            // show tooltip
            toolTipHostname.SetToolTip(txtBoxHostname, "Ex: ftp://111.111.111.111");
            toolTipDownload.SetToolTip(picBoxDownload, "Download File.\nHave destination path selected and file selected.");
            toolTipUpload.SetToolTip(picBoxUpload, "Upload File.\nHave upload file path selected and directory selected.");
            toolTipDelete.SetToolTip(picBoxDelete, "Delete File.\nHave file to delete selected.");
        }

        private void picBoxOpenFileToUpload_Click(object sender, EventArgs e)
        {
            dialogOpenFileToUpload.ShowDialog();  // show the dialog

            if (dialogOpenFileToUpload.ShowDialog() == DialogResult.OK)
            {
                // get the filepath
                filepath = dialogOpenFileToUpload.FileName;
                // get the filename
                filename = Path.GetFileName(filepath);
                lblUploadFilename.Text = filename;
            }
        }

        private void picBoxOpenDestFolder_Click(object sender, EventArgs e)
        {
            string destinationPath;
            // if the user made a selection
            if (dialogOpenDestFolder.ShowDialog() == DialogResult.OK)
            {
                // set the selected path to the destination paths
                destinationPath = dialogOpenDestFolder.SelectedPath;
                lblDistPath.Text = destinationPath;
            }
        }

        private void picBoxUpload_Click(object sender, EventArgs e)
        {
            lblOpsStatus.Text = "";

            //UploadFileToFtp(filepath, txtBoxUsername.Text, txtBoxPword.Text);
            UploadFileToFtp(filepath, txtBoxUsername.Text, txtBoxPword.Text);
        }

        private void picBoxDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lblOpsStatus.Text = "";
                var dirPath = lstBoxRootDirs.Text + "/" + lstBoxDirContents1.Text;
                DeleteFile(txtBoxHostname.Text, txtBoxUsername.Text, txtBoxPword.Text, dirPath, txtBoxFilename.Text);
                lblOpsStatus.Text = "Delete Successful";
            }
            catch (Exception ex)
            {
                lblOpsStatus.Text = ex.Message;
            }
        }

        private void picBoxDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDistPath.Text == "No Path Selected")
                {
                    MessageBox.Show("Please enter a destination path.", "Choose Destinaion Path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtBoxFilename.Text == "")
                {
                    MessageBox.Show("Please enter a file name to download/delete.", "Choose File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtBoxCurrDir.Text == "")
                {
                    MessageBox.Show("Please choose a directory.", "Choose Directory", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblOpsStatus.Text = "";
                    var dirPath = lstBoxRootDirs.Text + "/" + lstBoxDirContents1.Text; // Directory path
                    DownloadFile(txtBoxHostname.Text, txtBoxUsername.Text, txtBoxPword.Text, dirPath, txtBoxFilename.Text, lblDistPath.Text);
                    lblOpsStatus.Text = "Download Successful";
                }
            }
            catch (Exception ex)
            {
                lblOpsStatus.Text = ex.Message;
            }
        }
    }
}