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
    public partial class Home : Form
    {
        private String role;
        public Home()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            role = "admin";
            var login = new Login(role);
            login.Show();
        }

        private void btnPupil_Click(object sender, EventArgs e)
        {
            role = "pupil";
            var login = new Login(role);
            login.Show();
        }
    }
}
