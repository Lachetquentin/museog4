using System;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminUpdateUser : Form
    {
        private int userId;
        private User user = new User();
        private readonly Action _refreshUsers;
        public FrmAdminUpdateUser(int selectedUserId, Action refreshUsers)
        {
            InitializeComponent();
            userId = selectedUserId;
            _refreshUsers = refreshUsers;
            AcceptButton = btnUpdate;
            CancelButton = btnQuit;
        }

        private void FrmAdminUpdateUser_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtName.Text) || Utils.Checker(txtPwd.Text) || Utils.Checker(txtEmail.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            string pw = Utils.EncryptPassword(txtPwd.Text);

            if (DataLayer.UserData.UpdateUser(userId, txtName.Text, txtEmail.Text, pw))
            {
                MessageBox.Show("L'administrateur à bien été mis à jour !");
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
            user = DataLayer.UserData.GetUserById(userId);
            txtEmail.Text = user.Email;
            txtName.Text = user.Username;
            txtPwd.Text = "";
        }
    }
}
