using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMIS
{
    public partial class FRM_Dashboard : Form
    {
        // GLOBAL Variables/Class
        User user = new User();

        public FRM_Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gb_user.Visible = true;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            gb_user.Visible = false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            Boolean create = user.createUser(username, password);
            if (create) {
                MessageBox.Show("User created succesfully");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FRM_Login login = new FRM_Login();
            this.Hide();
            login.Show();
        }
    }
}
