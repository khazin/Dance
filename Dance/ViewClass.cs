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
    public partial class ViewClass : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khazin\OneDrive\NCS\Dance\dance.accdb");

        public ViewClass(String role)
        {
            InitializeComponent();
            if (role == "pupil")
            {
                updatebtn.Visible = false;
                deleteBtn.Visible = false;
            }
        }

        private void ViewClass_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                cidTxt.Text = selectedRow.Cells[0].Value.ToString();
                dclassTxt.Text = selectedRow.Cells[1].Value.ToString();
                feesTxt.Text = selectedRow.Cells[2].Value.ToString();
                sessionsTxt.Text = selectedRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }


        private void viewBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            deleteBtn.Enabled = true;
            updatebtn.Enabled = true;
            dataGridView1.Enabled = true;

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [class] order by ID asc";
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
            cmd.CommandText = "update [class] set [fees] = '" + feesTxt.Text + "',[no_of_sessions] = '" + sessionsTxt.Text + "' where [dance_class] = '" + dclassTxt.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record updated succesfully");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [class] where [dance_class] = '" + dclassTxt.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record deleted succesfully");
        }

       
    }
}
