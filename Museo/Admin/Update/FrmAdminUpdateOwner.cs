using System;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminUpdateOwner : Form
    {
        private int ownerId;
        private Owner owner = new Owner();
        private readonly Action _refreshOwners;
        public FrmAdminUpdateOwner(int selectedUserId, Action refreshOwners)
        {
            InitializeComponent();
            ownerId = selectedUserId;
            _refreshOwners = refreshOwners;
            AcceptButton = btnUpdate;
            CancelButton = btnQuit;
        }

        private void FrmAdminUpdateUser_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtName.Text) || Utils.Checker(txtLocation.Text)
                || Utils.Checker(txtEmail.Text) || Utils.Checker(txtPhoneNumber.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            if (!Utils.CheckPhoneNumber(txtPhoneNumber.Text))
            {
                FrmMain.MessageShow("PhoneNumberNotValid");
                return;
            }

            if (DataLayer.OwnerData.UpdateOwner(ownerId,txtLocation.Text, txtName.Text, txtEmail.Text, txtPhoneNumber.Text))
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
            owner = DataLayer.OwnerData.GetOwnerById(ownerId);
            txtEmail.Text = owner.Email;
            txtName.Text = owner.Name;
            txtPhoneNumber.Text = owner.PhoneNumber;
            txtLocation.Text = owner.Location;
        }
    }
}
