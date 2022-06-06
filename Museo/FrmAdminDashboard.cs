using System;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminDashboard : Form
    {
        private User user;
        public FrmAdminDashboard(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenue " + user.Username;
        }

        private void FrmAdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Quit();
        }
    }
}
