using System;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmExhibitions : Form
    {
        internal int selectedExhibitionId;
        public FrmExhibitions()
        {
            InitializeComponent();
        }

        private void FrmExhibitions_Load(object sender, EventArgs e)
        {
            RefreshExhibitions();
            Start();
        }

        internal void RefreshExhibitions()
        {
            dgvExhibitions.DataSource = DataLayer.ExhibitionData.GetAllExhibitions();
        }

        private void Start()
        {
            dgvExhibitions.EnableHeadersVisualStyles = false;
            dgvExhibitions.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvExhibitions.ColumnHeadersDefaultCellStyle.BackColor;
            dgvExhibitions.Columns["ExhibitionId"].Visible = false;
            dgvExhibitions.Columns["Name"].HeaderText = "Nom de l'exposition";
            lblNbOfExhibitions.Text = "Nombre d'expositions : " + DataLayer.ExhibitionData.GetAllExhibitions().Count.ToString();
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
    }
}
