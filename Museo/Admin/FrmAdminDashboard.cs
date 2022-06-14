using System;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminDashboard : Form
    {
        private User user;
        private Form activeForm = null;
        public FrmAdminDashboard(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {
            openChildForm(new FrmAdminHome());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdminHome());
        }

        private void btnMasterpiece_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdminMasterpieces());
        }

        private void btnExhibition_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdminExhibitions());
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdminArtists());
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdminMap());
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdminUserType(user));
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FrmAdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Quit();
        }
    }
}
