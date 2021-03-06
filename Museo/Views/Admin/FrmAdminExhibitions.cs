using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminExhibitions : Form
    {
        internal int selectedExhibitionId;
        public FrmAdminExhibitions()
        {
            InitializeComponent();
        }

        private void FrmAdminExhibitions_Load(object sender, EventArgs e)
        {
            RefreshExhibitions();
            Start();
            AcceptButton = btnSearch;
        }

        internal void RefreshExhibitions()
        {
            dgvExhibitions.DataSource = DataLayer.ExhibitionData.GetAllExhibitions();
            lblNbOfExhibitions.Text = "Nombre d'expositions : " + DataLayer.ExhibitionData.GetAllExhibitions().Count.ToString();
        }

        private void Start()
        {
            dgvExhibitions.EnableHeadersVisualStyles = false;
            dgvExhibitions.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvExhibitions.ColumnHeadersDefaultCellStyle.BackColor;
            dgvExhibitions.Columns["ExhibitionId"].Visible = false;
            dgvExhibitions.Columns["Name"].HeaderText = "Nom de l'exposition";
            txtSearch.AutoSize = false;
            txtSearch.Height = 25;
        }

        private void mnuItemView_Click(object sender, EventArgs e)
        {
            ViewExhibition();
        }

        private void ViewExhibition()
        {
            if (selectedExhibitionId == 0) { return; }
            FrmViewExhibition frm = new FrmViewExhibition(selectedExhibitionId);
            frm.ShowDialog();
        }

        private void ViewExhibition(int exhId)
        {
            if (selectedExhibitionId == 0) { return; }
            FrmViewExhibition frm = new FrmViewExhibition(exhId);
            frm.ShowDialog();
        }

        private void dgvExhibitions_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvExhibitions.CurrentCell = dgvExhibitions.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvExhibitions.Rows[e.RowIndex].Selected = true;
                    dgvExhibitions.Focus();

                    selectedExhibitionId = Convert.ToInt32(dgvExhibitions.Rows[e.RowIndex].Cells[0].Value);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void dgvExhibitions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedExhibitionId = Convert.ToInt32(dgvExhibitions.Rows[e.RowIndex].Cells[0].Value);
                ViewExhibition(selectedExhibitionId);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvExhibitions_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo ht;
                ht = dgvExhibitions.HitTest(e.X, e.Y);
                if (ht.Type == DataGridViewHitTestType.Cell) { mnuOptions.Show(Cursor.Position.X, Cursor.Position.Y); }
            }
        }

        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            if (selectedExhibitionId == 0) { return; }

            if (!DataLayer.ExhibitionData.CheckIfExhibitionExists(selectedExhibitionId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshExhibitions();
                return;
            }

            FrmAdminUpdateExhibition frm = new FrmAdminUpdateExhibition(selectedExhibitionId, RefreshExhibitions);
            frm.ShowDialog();
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            if (selectedExhibitionId == 0) { return; }

            if (!DataLayer.ExhibitionData.CheckIfExhibitionExists(selectedExhibitionId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshExhibitions();
                return;
            }

            var Result = MessageBox.Show("Voulez-vous vraiment supprimer cette expositions ?", "Supprimer Expositions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                if (DataLayer.ExhibitionData.DeleteExhibition(selectedExhibitionId))
                {
                    RefreshExhibitions();
                    MessageBox.Show("Exposition supprimé !");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdminCreateExhibition frm = new FrmAdminCreateExhibition(RefreshExhibitions);
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtSearch.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            List<Exhibition> ListOfExhibitions = DataLayer.ExhibitionData.SearchExhibitions(txtSearch.Text);
            lblNbOfExhibitions.Text = "Nombre d'expositions : " + ListOfExhibitions.Count.ToString();
            dgvExhibitions.DataSource = ListOfExhibitions;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            RefreshExhibitions();
        }
    }
}
