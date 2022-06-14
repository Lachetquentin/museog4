using System;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminCreateUser : Form
    {
        private readonly Action _refreshUsers;
        public FrmAdminCreateUser(Action refreshUsers)
        {
            InitializeComponent();
            _refreshUsers = refreshUsers;
            AcceptButton = btnAdd;
            CancelButton = btnQuit;
        }

        private void FrmAdminCreateUser_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtName.Text) || Utils.Checker(txtPwd.Text) || Utils.Checker(txtEmail.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            if(Utils.CheckUsername(txtName.Text))
            {
                FrmMain.MessageShow("AlreadyExisting");
                return;
            }

            if (DataLayer.UserData.AddUser(txtName.Text, txtEmail.Text, txtPwd.Text))
            {
                MessageBox.Show("L'administrateur à bien été crée !");
                _refreshUsers();
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
            txtPwd.Text = "";
        }
    }
}
