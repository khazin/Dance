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
    public partial class Enrollment : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khazin\OneDrive\NCS\Dance\dance.accdb");

        public Enrollment(string username)
        {
            InitializeComponent();
            unameTxt.Text = username;

        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
          
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "insert into [enrollment] ([username],[dance_class],[instructor],[venue],[start_date],[end_date],[fees]) values(@1,@2,@3,@4,@5,@6,@7)";
                command.Parameters.AddWithValue("@1", unameTxt.Text);
                command.Parameters.AddWithValue("@2", dclassCombo.Text);
                command.Parameters.AddWithValue("@3", instructCombo.Text);
                command.Parameters.AddWithValue("@4", venueCombo.Text);
                command.Parameters.AddWithValue("@5", startdateCombo.Text);
                command.Parameters.AddWithValue("@6", enddateCombo.Text);
                command.Parameters.AddWithValue("@7", feesCombo.Text);
                if (unameTxt.Text == "")
                    {
                        MessageBox.Show("Please enter username");
                    }
                    else if (dclassCombo.Text == "")
                    {
                        MessageBox.Show("Please enter dance class");
                    }
                    else if (instructCombo.Text == "")
                    {
                        MessageBox.Show("Please enter instructor");
                    }
                    else if (venueCombo.Text == "")
                    {
                        MessageBox.Show("Please enter venue");
                    }
                    else if (feesCombo.Text == "")
                    {
                        MessageBox.Show("Please enter fees");
                    }
                    else if (startdateCombo.Text == "")
                    {
                        MessageBox.Show("Please enter start date");
                    }
                    else if (enddateCombo.Text == "")
                    {
                        MessageBox.Show("Please enter end date");
                    }

                    else
                    {

                        command.ExecuteNonQuery();
                        MessageBox.Show("Enrolled");
                        con.Close();
                    }
                    con.Close();     

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

        private void dclassCombo_DropDownClosed(object sender, EventArgs e)
        {
            if (dclassCombo.Text == "jazz dance")
            {
                instructCombo.Text = "patrick";
                venueCombo.Text = "room 1";
                feesCombo.Text = "30";
            }
            else if (dclassCombo.Text == "tap dance")
            {
                instructCombo.Text = "bob";
                venueCombo.Text = "room 2";
                feesCombo.Text = "30";
            }
            else if (dclassCombo.Text == "hip-hop dance")
            {
                instructCombo.Text = "sandy";
                venueCombo.Text = "room 3";
                feesCombo.Text = "40";
            }
        }

        private void startdateCombo_DropDownClosed(object sender, EventArgs e)
        {
            if (startdateCombo.Text == "october 2019")
            {
                enddateCombo.Text = "december 2019";
            
            }
            else if (startdateCombo.Text == "november 2019")
            {
                enddateCombo.Text = "jaunary 2020";

            }
            else if (startdateCombo.Text == "december 2019")
            {
                enddateCombo.Text = "february 2020";

            }
        }
    }
}
