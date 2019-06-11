/* 
 * Programmer: Hunter Johnson
 * Name: Login Panel
 * Class: CIS 153 - Final Project
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
using System.Data.SqlClient;
using System.Threading;

namespace LoginPanel
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Connection String
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MyDatabase.mdf;Integrated Security=True;";

        private void button1_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            // validate input
            // validate that the entries are not empty
            if (txt_UserName.Text == "" && txt_Password.Text == "")
            {
                userNameErrorProvider.SetError(txt_UserName, "Please provide a username.");
                passwordErrorProvider.SetError(txt_Password, "Please provide a password.");
                return;
            }
            else if (txt_UserName.Text == "")
            {
                userNameErrorProvider.SetError(txt_UserName, "Please provide UserName");
                return;
            }
            else if (txt_Password.Text == "")
            {
                // set error provider
                passwordErrorProvider.SetError(txt_Password, "Please provide a password.");

                if (txt_UserName.Text == "")
                {
                    userNameErrorProvider.SetError(txt_UserName, "Please provide UserName");
                }
                else
                {
                    userNameErrorProvider.Dispose(); // dispose of the first error providor
                }
                return;
            }
            else
            {
                userNameErrorProvider.Dispose();
                passwordErrorProvider.Dispose();
            }

            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from tbl_Login where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                con.Open(); // open the connection
                SqlDataAdapter adapt = new SqlDataAdapter(cmd); // create SqlDataAdapter object
                DataSet ds = new DataSet(); // create a new dataset
                adapt.Fill(ds); // fill the adapter with the dataset
                con.Close(); // close the connection
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Your login was successful!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); // Login Successful
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    statusLabel.Text = "Are you a registered user? If not, click the Register button.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AddUser()
        {
           try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Login (UserName, Password) VALUES (@username, @password)", con);

                // validate that the entries are not empty
                if (txt_UserName.Text == "" && txt_Password.Text == "")
                {
                    userNameErrorProvider.SetError(txt_UserName, "Please provide a username.");
                    passwordErrorProvider.SetError(txt_Password, "Please provide a password.");
                }
                else if (txt_UserName.Text == "")
                {
                    userNameErrorProvider.SetError(txt_UserName, "Please provide a username.");
                }
                else if(txt_Password.Text == "")
                {
                    passwordErrorProvider.SetError(txt_Password, "Please provide a password.");
                }
                else
                {
                    userNameErrorProvider.Dispose();
                    passwordErrorProvider.Dispose();
                    // add parameters with commands
                    cmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                    cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                }

                cmd.Connection = con;
                con.Open(); // open the connection
                cmd.ExecuteNonQuery(); // returns the number of rows affected
                con.Close(); // close the connection
                
                MessageBox.Show("Your user was created successfully. You may now log in.", "User Created Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information); // User Created Successful
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AddUser(); // Register User
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // disable sizing of screen
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // ensure the application closes
        }
    }
}

