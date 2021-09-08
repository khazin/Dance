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
    public partial class ViewUser : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khazin\OneDrive\NCS\Dance\dance.accdb");

        public ViewUser()
        {
            InitializeComponent();
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                usridTxt.Text = selectedRow.Cells[0].Value.ToString();
                unameTxt.Text = selectedRow.Cells[1].Value.ToString();
                pwdTxt.Text = selectedRow.Cells[5].Value.ToString();
                fnameTxt.Text = selectedRow.Cells[2].Value.ToString();
                lnameTxt.Text = selectedRow.Cells[3].Value.ToString();
                emailTxt.Text = selectedRow.Cells[4].Value.ToString();
                roleTxt.Text = selectedRow.Cells[6].Value.ToString();
                statusTxt.Text = selectedRow.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }


        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            usridTxt.Enabled = false;
            unameTxt.Enabled = false;
            pwdTxt.Enabled = false;
            updatebtn.Enabled = true;
            statusTxt.Enabled = true;

            roleTxt.Text = "";
            statusTxt.Text = "";

            insertBtn.Enabled = false;
            deleteBtn.Enabled = true;
            roleTxt.Enabled = true;
            dataGridView1.Enabled = true;


            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [user] order by [ID] asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

       

        private void updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [user] set [firstname] = '" + fnameTxt.Text + "',[lastname] = '" + lnameTxt.Text + "',[email] = '" + emailTxt.Text + "',[password] = '" + pwdTxt.Text + "',[role] = '" + roleTxt.Text + "',[status] = '" + statusTxt.Text + "' where [username] = '" + unameTxt.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record updated succesfully");
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [user]([username], [firstname], [lastname], [email], [password], [role], [status] ) values('" + unameTxt.Text + "','" + fnameTxt.Text + "','" + lnameTxt.Text + "','" + emailTxt.Text + "','" + pwdTxt.Text + "','" + roleTxt.Text + "','" + statusTxt.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record inserted");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [user] where [username] = '" + unameTxt.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record deleted succesfully");
        }

        private void ViewUser_Click(object sender, EventArgs e)
        {
            insertBtn.Enabled = true;
            deleteBtn.Enabled = false;
            updatebtn.Enabled = false;

            statusTxt.Enabled = false;
            roleTxt.Enabled = false;
            unameTxt.Enabled = true;
            pwdTxt.Enabled = true;

            usridTxt.Text = "";
            fnameTxt.Text = "";
            lnameTxt.Text = "";
            emailTxt.Text = "";
            unameTxt.Text = "";
            pwdTxt.Text = "";

            roleTxt.Text = "instructor";
            statusTxt.Text = "active";

            dataGridView1.DataSource = null;

        }

    }
}
