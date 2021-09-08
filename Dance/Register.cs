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
    public partial class Register : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Register()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khazin\OneDrive\NCS\Dance\dance.accdb";

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from [user] where [username] ='" + unameTxt.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count > 0)
                {
                    MessageBox.Show("Username exist");
                    connection.Close();

                }
                else
                {
                    reader.Close();
                    if (unameTxt.Text == "")
                    {
                        MessageBox.Show("Please enter username");

                    }
                    else if (pwdTxt.Text == "")
                    {
                        MessageBox.Show("Please enter password");

                    }
                    else if (fnameTxt.Text == "")
                    {
                        MessageBox.Show("Please enter firstname");
                    }
                    else if (lnameTxt.Text == "")
                    {
                        MessageBox.Show("Please enter lastname");
                    }
                    else if (emailTxt.Text == "")
                    {
                        MessageBox.Show("Please enter email");
                    }
                    else
                    {
                        command.CommandText = "insert into [user] ([username],[password],[firstname],[lastname],[email],[role],[status]) values('" + unameTxt.Text + "','" + pwdTxt.Text + "','" + fnameTxt.Text + "','" + lnameTxt.Text + "','" + emailTxt.Text + "','" + roleTxt.Text + "','active')";

                        command.ExecuteNonQuery();
                        MessageBox.Show("Register succesful");
                        connection.Close();
                    }
                    connection.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void fnameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lnameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        
    }
}
