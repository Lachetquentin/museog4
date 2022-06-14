using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminCreateState : Form
    {
        private readonly Action _refreshState;
        public FrmAdminCreateState(Action refreshState)
        {
            InitializeComponent();
            _refreshState = refreshState;
            AcceptButton = btnAdd;
            CancelButton = btnQuit;
        }

        private void FrmAdminCreateState_Load(object sender, EventArgs e)
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

            if (DataLayer.MpStateData.AddState(txtName.Text))
            {
                MessageBox.Show("L'état à bien été crée !");
                _refreshState();
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
