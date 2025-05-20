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
    public partial class FRM_Login : Form
    {
        User user = new User();
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string role = cb_role.SelectedText;

            Boolean loggedin = user.login(username, password, role);

            if(loggedin)
            {
                MessageBox.Show("Welcome User");
                FRM_Dashboard dashboard = new FRM_Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }
    }
}
