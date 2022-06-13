using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminUpdateState : Form
    {
        private int stateId;
        private MpState status = new MpState();
        private readonly Action _refreshStates;
        public FrmAdminUpdateState(int selectedStateId, Action refreshStates)
        {
            InitializeComponent();
            stateId = selectedStateId;
            _refreshStates = refreshStates;
        }

        private void FrmAdminUpdateState_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DataLayer.MpStateData.UpdateState(stateId, txtName.Text))
            {
                MessageBox.Show("Le status à bien été mise à jour !");
                _refreshStates();
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
            status = DataLayer.MpStateData.GetStateById(stateId);
            txtName.Text = status.Name;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
