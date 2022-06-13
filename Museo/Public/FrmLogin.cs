using MuseoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmLogin : Form
    {
        private User user;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            bool success = Utils.Login(txtUsername.Text, txtPassword.Text);

            if (success)
            {
                user = DataLayer.UserData.GetUserByUsername(txtUsername.Text);
                FrmAdminDashboard dashboard = new FrmAdminDashboard(user);
                dashboard.Show();
                dashboard.Activate();
                Hide();
            }
            else
            {
                FrmMain.MessageShow("LoginFailed");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked == false) txtPassword.UseSystemPasswordChar = true;
            else txtPassword.UseSystemPasswordChar = false;
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            FrmMain.Quit();
        }
    }
}
