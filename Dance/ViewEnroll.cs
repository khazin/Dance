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
    public partial class ViewEnroll : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Khazin\OneDrive\NCS\Dance\dance.accdb");

        public ViewEnroll(String role)
        {
            InitializeComponent();
            if(role == "pupil")
            {
                updatebtn.Visible = false;
                deleteBtn.Visible = false;
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [enrollment] order by ID asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                usridTxt.Text = selectedRow.Cells[0].Value.ToString();
                unameTxt.Text = selectedRow.Cells[1].Value.ToString();
                dclassTxt.Text = selectedRow.Cells[2].Value.ToString();
                instructTxt.Text = selectedRow.Cells[3].Value.ToString();
                venueTxt.Text = selectedRow.Cells[4].Value.ToString();
                startdateTxt.Text = selectedRow.Cells[5].Value.ToString();
                enddateTxt.Text = selectedRow.Cells[6].Value.ToString();
                feesTxt.Text = selectedRow.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [enrollment] set [username] = @1,[dance_class] = @2,[instructor] = @3,[venue] = @4,[start_date] = @5,[end_date] = @6,[fees] = @7 where [ID] = @8";
            cmd.Parameters.AddWithValue("@1", unameTxt.Text);
            cmd.Parameters.AddWithValue("@2", dclassTxt.Text);
            cmd.Parameters.AddWithValue("@3", instructTxt.Text);
            cmd.Parameters.AddWithValue("@4", venueTxt.Text);
            cmd.Parameters.AddWithValue("@5", startdateTxt.Text);
            cmd.Parameters.AddWithValue("@6", enddateTxt.Text);
            cmd.Parameters.AddWithValue("@7", feesTxt.Text);
            cmd.Parameters.AddWithValue("@8", usridTxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record updated succesfully");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [enrollment] where [ID] = @1";
            cmd.Parameters.AddWithValue("@1", usridTxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record deleted succesfully");
        }
    }
}
