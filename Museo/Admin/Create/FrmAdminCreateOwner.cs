using System;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminCreateOwner : Form
    {
        private readonly Action _refreshOwners;
        public FrmAdminCreateOwner(Action refreshOwners)
        {
            InitializeComponent();
            _refreshOwners = refreshOwners;
            AcceptButton = btnAdd;
            CancelButton = btnQuit;
        }

        private void FrmAdminCreateOwner_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtName.Text) || Utils.Checker(txtLocation.Text) 
                || Utils.Checker(txtEmail.Text) || Utils.Checker(txtPhoneNumber.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            if (Utils.CheckUsername(txtName.Text))
            {
                FrmMain.MessageShow("AlreadyExisting");
                return;
            }

            if (!Utils.CheckPhoneNumber(txtPhoneNumber.Text))
            {
                FrmMain.MessageShow("PhoneNumberNotValid");
                return;
            }

            if (DataLayer.OwnerData.AddOwner(txtLocation.Text, txtName.Text, txtEmail.Text, txtPhoneNumber.Text))
            {
                MessageBox.Show("Le propriétaire à bien été mis à jour !");
                _refreshOwners();
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetupForm()
        {
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtLocation.Text = "";
        }
    }
}
