using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminCreateStatus : Form
    {
        private readonly Action _refreshStatus;
        public FrmAdminCreateStatus(Action refreshStatus)
        {
            InitializeComponent();
            _refreshStatus = refreshStatus;
            AcceptButton = btnAdd;
            CancelButton = btnQuit;
        }

        private void FrmAdminCreateStatus_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtName.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            if (DataLayer.MpStatusData.AddStatus(txtName.Text))
            {
                MessageBox.Show("Le status à bien été crée !");
                _refreshStatus();
                Close();
            }
            else
            {
                FrmMain.MessageShow("UpdateFailed");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void SetupForm()
        {
            txtName.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
