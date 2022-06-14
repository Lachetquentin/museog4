using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminUpdateStatus : Form
    {
        private int statusId;
        private MpStatus status = new MpStatus();
        private readonly Action _refreshStatus;
        public FrmAdminUpdateStatus(int selectedStatusId, Action refreshStatus)
        {
            InitializeComponent();
            statusId = selectedStatusId;
            _refreshStatus = refreshStatus;
            AcceptButton = btnUpdate;
            CancelButton = btnQuit;
        }

        private void FrmAdminUpdateStatus_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtName.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            if (DataLayer.MpStatusData.UpdateStatus(statusId, txtName.Text))
            {
                MessageBox.Show("Le status à bien été mise à jour !");
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
            status = DataLayer.MpStatusData.GetStatusById(statusId);
            txtName.Text = status.Name;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
