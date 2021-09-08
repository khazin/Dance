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
    public partial class Menu : Form
    {
        private String role;
        private String username;

        public Menu(String role, String username)
        {
            InitializeComponent();
            this.role = role;
            if (role == "admin")
            {
                Enroll.Visible = false;
            }
            if (role == "pupil")
            {
                this.username = username;
                viewUser.Visible = false;
            }
        }

        private void viewUser_Click(object sender, EventArgs e)
        {
            var viewUser = new ViewUser();
            viewUser.Show();
        }

        private void viewClass_Click(object sender, EventArgs e)
        {
            var viewClass = new ViewClass(role);
            viewClass.Show();
        }

        private void Enroll_Click(object sender, EventArgs e)
        {
            var enrollment = new Enrollment(username);
            enrollment.Show();
        }

        private void viewEnroll_Click(object sender, EventArgs e)
        {
            var viewEnrollment = new ViewEnroll(role);
            viewEnrollment.Show();
        }
    }
}
