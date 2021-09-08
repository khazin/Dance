using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dance
{
    public partial class EditUser : Form
    {
        DataRow dRow;
        int MaxRows;
        int inc = 0;
            
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDS.Customer' table. You can move, or remove it, as needed.
            this.danceTableAdapter.Fill(this.danceDataSet.user);
            MaxRows = customerDS.Tables[0].Rows.Count;
            customerBindingSource.DataSource = customerDS.Customer;
            NavigateRecords();
        }

        private void NavigateRecords()
        {
            dRow = customerDS.Tables[0].Rows[inc];
            txtCustID.Text = dRow.ItemArray.GetValue(0).ToString();
            txtCustName.Text = dRow.ItemArray.GetValue(1).ToString();
            txtContact.Text = dRow.ItemArray.GetValue(2).ToString();
            txtEmail.Text = dRow.ItemArray.GetValue(3).ToString();
            txtDOB.Text = dRow.ItemArray.GetValue(4).ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (inc != 0)
            {
                inc = 0;
                NavigateRecords();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {
                inc--;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("First Record");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1)
            {
                inc++;
                NavigateRecords();
            }

            else
            {
                MessageBox.Show("No more records");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1)
            {
                inc = MaxRows - 1;
                NavigateRecords();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow row = danceDataSet.Tables[0].Rows[inc];
            row[0] = txtCustID.Text;
            row[1] = txtCustName.Text;
            row[2] = txtContact.Text;
            row[3] = txtEmail.Text;
            row[4] = txtDOB.Text;
            try
            {

                danceDataSetTableAdapters.Update(danceDataSet.userDataTable);
                //  customerTableAdapter.Update(row);
                //  customerTableAdapter.Update(customerDS.Tables[0].Rows[inc]);
                danceDataSet.AcceptChanges();

                // MaxRows = customerDS.Tables[0].Rows.Count;

                // MaxRows = MaxRows + 1;
                // inc = MaxRows - 1;

                MessageBox.Show("Database updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
