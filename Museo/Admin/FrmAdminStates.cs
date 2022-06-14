using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminStates : Form
    {
        private int selectedStateId;
        public FrmAdminStates()
        {
            InitializeComponent();
        }
        private void FrmAdminStates_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Liste des états";
            RefreshStates();
            GridSetup();
        }

        private void GridSetup()
        {
            dgvStates.EnableHeadersVisualStyles = false;
            dgvStates.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvStates.ColumnHeadersDefaultCellStyle.BackColor;
            dgvStates.Columns["StateId"].Visible = false;
            dgvStates.Columns["Name"].HeaderText = "Nom";
        }

        private void RefreshStates()
        {
            dgvStates.DataSource = DataLayer.MpStateData.GetAllStates();
        }

        private void UpdateStates()
        {
            if (selectedStateId == 0) { return; }

            if (!DataLayer.MpStateData.CheckIfStateExists(selectedStateId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshStates();
                return;
            }

            FrmAdminUpdateState frm = new FrmAdminUpdateState(selectedStateId, RefreshStates);
            frm.ShowDialog();
        }

        private void UpdateState(int stateId)
        {
            if (stateId == 0) { return; }

            if (!DataLayer.MpStateData.CheckIfStateExists(selectedStateId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshStates();
                return;
            }

            FrmAdminUpdateState frm = new FrmAdminUpdateState(stateId, RefreshStates);
            frm.ShowDialog();
        }

        private void dgvStates_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvStates.CurrentCell = dgvStates.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvStates.Rows[e.RowIndex].Selected = true;
                    dgvStates.Focus();

                    selectedStateId = Convert.ToInt32(dgvStates.Rows[e.RowIndex].Cells[0].Value);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void dgvStates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedStateId = Convert.ToInt32(dgvStates.Rows[e.RowIndex].Cells[0].Value);
                UpdateState(selectedStateId);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvStates_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo ht;
                ht = dgvStates.HitTest(e.X, e.Y);
                if (ht.Type == DataGridViewHitTestType.Cell) { mnuOptions.Show(Cursor.Position.X, Cursor.Position.Y); }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdminCreateState frm = new FrmAdminCreateState(RefreshStates);
            frm.ShowDialog();
        }

        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            UpdateStates();
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            if (selectedStateId == 0) { return; }

            if (!DataLayer.MpStateData.CheckIfStateExists(selectedStateId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshStates();
                return;
            }

            var Result = MessageBox.Show("Voulez-vous vraiment supprimer cet état ?", "Supprimer État", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                if (DataLayer.MpStateData.DeleteState(selectedStateId))
                {
                    RefreshStates();
                    MessageBox.Show("État supprimé !");
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

