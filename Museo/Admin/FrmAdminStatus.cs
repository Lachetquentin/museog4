using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminStatus : Form
    {
        private int selectedStatusId;
        public FrmAdminStatus()
        {
            InitializeComponent();
        }
        private void FrmAdminStatus_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Liste des status";
            RefreshStatus();
            GridSetup();
        }

        private void GridSetup()
        {
            dgvStatus.EnableHeadersVisualStyles = false;
            dgvStatus.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvStatus.ColumnHeadersDefaultCellStyle.BackColor;
            dgvStatus.Columns["StatusId"].Visible = false;
            dgvStatus.Columns["Name"].HeaderText = "Nom";
        }

        private void RefreshStatus()
        {
            dgvStatus.DataSource = DataLayer.MpStatusData.GetAllStatus();
        }

        private void UpdateStatus()
        {
            if (selectedStatusId == 0) { return; }

            if (!DataLayer.MpStatusData.CheckIfStatusExists(selectedStatusId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshStatus();
                return;
            }

            FrmAdminUpdateStatus frm = new FrmAdminUpdateStatus(selectedStatusId, RefreshStatus);
            frm.ShowDialog();
        }

        private void UpdateStatus(int statusId)
        {
            if (statusId == 0) { return; }

            if (!DataLayer.MpStatusData.CheckIfStatusExists(selectedStatusId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshStatus();
                return;
            }

            FrmAdminUpdateStatus frm = new FrmAdminUpdateStatus(statusId, RefreshStatus);
            frm.ShowDialog();
        }

        private void dgvStatus_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvStatus.CurrentCell = dgvStatus.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvStatus.Rows[e.RowIndex].Selected = true;
                    dgvStatus.Focus();

                    selectedStatusId = Convert.ToInt32(dgvStatus.Rows[e.RowIndex].Cells[0].Value);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void dgvStatus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedStatusId = Convert.ToInt32(dgvStatus.Rows[e.RowIndex].Cells[0].Value);
                UpdateStatus(selectedStatusId);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvStatus_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo ht;
                ht = dgvStatus.HitTest(e.X, e.Y);
                if (ht.Type == DataGridViewHitTestType.Cell) { mnuOptions.Show(Cursor.Position.X, Cursor.Position.Y); }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdminCreateStatus frm = new FrmAdminCreateStatus(RefreshStatus);
            frm.ShowDialog();
        }

        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            if (selectedStatusId == 0) { return; }

            if (!DataLayer.MpStatusData.CheckIfStatusExists(selectedStatusId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshStatus();
                return;
            }

            var Result = MessageBox.Show("Voulez-vous vraiment supprimer ce status ?", "Supprimer Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                if (DataLayer.MpStatusData.DeleteStatus(selectedStatusId))
                {
                    RefreshStatus();
                    MessageBox.Show("Status supprimé !");
                }
                else
                {
                    FrmMain.MessageShow("ForeignKeys");
                    return;
                }
            }
            else if (Result == DialogResult.No)
            {
                return;
            }
        }
    }
}

