using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dance
{
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private String role;
        private String username;

        public Login(String role)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khazin\OneDrive\NCS\Dance\dance.accdb";
            this.role = role;
            if (role == "admin") {
                registerLink.Visible = false;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from [user] where [username] ='" + usrnameTxt.Text + "' and [password]='" + pwdTxt.Text + "' and [role] = '" + role + "' ";
                OleDbDataReader reader = command.ExecuteReader();
                username = usrnameTxt.Text;

                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Login Succesful");
                    var menu = new Menu(role,username);
                    menu.Show();
                    
                    connection.Close();
                    connection.Dispose();

                }
                else
                {
                    if (usrnameTxt.Text == "" && pwdTxt.Text == "")
                    {
                        MessageBox.Show("Please enter username & password");
                    }
                    else if(usrnameTxt.Text == "")
                    {
                        MessageBox.Show("Please enter username");
                    }
                    else if (pwdTxt.Text == "")
                    {
                        MessageBox.Show("Please enter password");
                    }
                    
                    else
                    {
                        MessageBox.Show("Invalid username and password");
                        MessageBox.Show("Please register to sign in");
                    }
                   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var register = new Register();
            register.Show();
        }

  
    }
}
