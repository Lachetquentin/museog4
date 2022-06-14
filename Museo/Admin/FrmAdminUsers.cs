using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminUsers : Form
    {
        private int selectedUserId;
        private User user;
        public FrmAdminUsers(User u)
        {
            InitializeComponent();
            user = u;
        }
        private void FrmAdminUsers_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Liste des administrateurs";
            RefreshUsers();
            GridSetup();
        }

        private void GridSetup()
        {
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvUsers.ColumnHeadersDefaultCellStyle.BackColor;
            dgvUsers.Columns["UserId"].Visible = false;
            dgvUsers.Columns["RoleId"].Visible = false;
            dgvUsers.Columns["Password"].Visible = false;
        }

        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0) { return; }

            if (!DataLayer.UserData.CheckIfUserExists(selectedUserId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshUsers();
                return;
            }

            if(Utils.CheckIfItsMe(user, selectedUserId))
            {
                FrmMain.MessageShow("DeletingYourself");
                return;
            }

            var Result = MessageBox.Show("Voulez-vous vraiment supprimer ce administrateur ?", "Supprimer Administrateur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                DataLayer.UserData.DeleteUser(selectedUserId);
                RefreshUsers();
                MessageBox.Show("Administrateur supprimé !");
            }
            else if (Result == DialogResult.No)
            {
                return;
            }
        }

        private void UpdateUser()
        {
            if (selectedUserId == 0) { return; }

            if (Utils.CheckIfItsMe(user, selectedUserId))
            {
                FrmMain.MessageShow("UpdatingYourself");
                return;
            }

            if (!DataLayer.UserData.CheckIfUserExists(selectedUserId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshUsers();
                return;
            }

            FrmAdminUpdateUser frm = new FrmAdminUpdateUser(selectedUserId, RefreshUsers);
            frm.ShowDialog();
        }

        private void RefreshUsers()
        {
            dgvUsers.DataSource = DataLayer.UserData.GetAllUsers();
        }

        private void UpdateUser(int userId)
        {
            if (userId == 0) { return; }

            if (Utils.CheckIfItsMe(user, selectedUserId))
            {
                FrmMain.MessageShow("UpdatingYourself");
                return;
            }

            if (!DataLayer.UserData.CheckIfUserExists(userId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshUsers();
                return;
            }

            FrmAdminUpdateUser frm = new FrmAdminUpdateUser(userId, RefreshUsers);
            frm.ShowDialog();
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvUsers.CurrentCell = dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvUsers.Rows[e.RowIndex].Selected = true;
                    dgvUsers.Focus();

                    selectedUserId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedUserId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
                UpdateUser(selectedUserId);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvUsers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo ht;
                ht = dgvUsers.HitTest(e.X, e.Y);
                if (ht.Type == DataGridViewHitTestType.Cell) { mnuOptions.Show(Cursor.Position.X, Cursor.Position.Y); }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdminCreateUser frm = new FrmAdminCreateUser(RefreshUsers);
            frm.ShowDialog();
        }
    }
}
