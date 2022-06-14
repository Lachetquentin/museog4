using System;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminMasterpieces : Form
    {
        internal int selectedMasterpieceId;
        public FrmAdminMasterpieces()
        {
            InitializeComponent();
        }

        private void FrmAdminMasterpieces_Load(object sender, EventArgs e)
        {
            RefreshMasterpieces();
            Start();
        }

        internal void RefreshMasterpieces()
        {
            dgvMasterpieces.DataSource = DataLayer.MasterpieceData.GetAllMasterpieces();
        }

        private void Start()
        {
            dgvMasterpieces.EnableHeadersVisualStyles = false;
            dgvMasterpieces.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvMasterpieces.ColumnHeadersDefaultCellStyle.BackColor;
            dgvMasterpieces.Columns["LocationId"].Visible = false;
            dgvMasterpieces.Columns["ExhibitionId"].Visible = false;
            dgvMasterpieces.Columns["MasterpieceId"].Visible = false;
            dgvMasterpieces.Columns["ArtistId"].Visible = false;
            dgvMasterpieces.Columns["StateId"].Visible = false;
            dgvMasterpieces.Columns["StatusId"].Visible = false;
            dgvMasterpieces.Columns["OwnerId"].Visible = false;
            dgvMasterpieces.Columns["Memo"].Visible = false;
            dgvMasterpieces.Columns["Ncda"].Visible = false;
            dgvMasterpieces.Columns["Url"].Visible = false;
            dgvMasterpieces.Columns["Name"].HeaderText = "Nom de l'oeuvre";
            dgvMasterpieces.Columns["CreateYear"].HeaderText = "Date de création";
            dgvMasterpieces.Columns["Desc"].HeaderText = "Description";
            lblNbOfMasterpieces.Text = "Nombre d'oeuvres : " + DataLayer.MasterpieceData.GetAllMasterpieces().Count.ToString();
        }

        private void mnuItemView_Click(object sender, EventArgs e)
        {
            ViewMasterpiece();
        }
        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMasterpieceId == 0) { return; }

            if (!DataLayer.MasterpieceData.CheckIfMasterpieceExists(selectedMasterpieceId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshMasterpieces();
                return;
            }

            FrmAdminUpdateMasterpiece frm = new FrmAdminUpdateMasterpiece(selectedMasterpieceId, RefreshMasterpieces);
            frm.ShowDialog();
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            if (selectedMasterpieceId == 0) { return; }

            if (!DataLayer.MasterpieceData.CheckIfMasterpieceExists(selectedMasterpieceId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshMasterpieces();
                return;
            }

            var Result = MessageBox.Show("Voulez-vous vraiment supprimer cette oeuvre ?", "Supprimer Oeuvre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                DataLayer.MasterpieceData.DeleteMasterpiece(selectedMasterpieceId);
                RefreshMasterpieces();
                MessageBox.Show("Oeuvre supprimé !");
            }
            else if (Result == DialogResult.No)
            {
                return;
            }
        }

        private void ViewMasterpiece()
        {
            if (selectedMasterpieceId == 0) { return; }
            FrmViewMasterpiece frm = new FrmViewMasterpiece(selectedMasterpieceId);
            frm.ShowDialog();
        }

        private void ViewMasterpiece(int mpId)
        {
            if (selectedMasterpieceId == 0) { return; }
            FrmViewMasterpiece frm = new FrmViewMasterpiece(mpId);
            frm.ShowDialog();
        }

        private void dgvMasterpieces_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvMasterpieces.CurrentCell = dgvMasterpieces.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvMasterpieces.Rows[e.RowIndex].Selected = true;
                    dgvMasterpieces.Focus();

                    selectedMasterpieceId = Convert.ToInt32(dgvMasterpieces.Rows[e.RowIndex].Cells[0].Value);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void dgvMasterpieces_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedMasterpieceId = Convert.ToInt32(dgvMasterpieces.Rows[e.RowIndex].Cells[0].Value);
                ViewMasterpiece(selectedMasterpieceId);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvMasterpieces_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo ht;
                ht = dgvMasterpieces.HitTest(e.X, e.Y);
                if (ht.Type == DataGridViewHitTestType.Cell) { mnuOptions.Show(Cursor.Position.X, Cursor.Position.Y); }
            }
        }

        private void btnMpDetails_click(object sender, EventArgs e)
        {
            FrmAdminMasterpiecesDetails frm = new FrmAdminMasterpiecesDetails();
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdminCreateMasterpiece frm = new FrmAdminCreateMasterpiece(RefreshMasterpieces);
            frm.ShowDialog();
        }
    }
}
