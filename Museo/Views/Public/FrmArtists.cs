using System;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmArtists : Form
    {
        internal int selectedArtistId;
        public FrmArtists()
        {
            InitializeComponent();
        }

        private void FrmExhibitions_Load(object sender, EventArgs e)
        {
            RefreshArtists();
            Start();
        }

        internal void RefreshArtists()
        {
            dgvArtists.DataSource = DataLayer.ArtistData.GetAllArtists();
        }

        private void Start()
        {
            dgvArtists.EnableHeadersVisualStyles = false;
            dgvArtists.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvArtists.ColumnHeadersDefaultCellStyle.BackColor;
            dgvArtists.Columns["ArtistId"].Visible = false;
            dgvArtists.Columns["Isni"].Visible = false;
            dgvArtists.Columns["Url"].Visible = false;
            dgvArtists.Columns["Name"].HeaderText = "Nom";
            dgvArtists.Columns["Desc"].HeaderText = "Description";
            dgvArtists.Columns["Dob"].HeaderText = "Date de naissance";
            lblNbOfArtists.Text = "Nombre d'artistes : " + DataLayer.ArtistData.GetAllArtists().Count.ToString();
        }

        private void mnuItemView_Click(object sender, EventArgs e)
        {
            ViewArtist();
        }

        private void ViewArtist()
        {
            if (selectedArtistId == 0) { return; }
            FrmViewArtist frm = new FrmViewArtist(selectedArtistId, RefreshArtists);
            frm.ShowDialog();
        }

        private void ViewArtist(int artistId)
        {
            if (selectedArtistId == 0) { return; }
            FrmViewArtist frm = new FrmViewArtist(artistId, RefreshArtists);
            frm.ShowDialog();
        }

        private void dgvArtists_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvArtists.CurrentCell = dgvArtists.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvArtists.Rows[e.RowIndex].Selected = true;
                    dgvArtists.Focus();

                    selectedArtistId = Convert.ToInt32(dgvArtists.Rows[e.RowIndex].Cells[0].Value);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void dgvArtists_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedArtistId = Convert.ToInt32(dgvArtists.Rows[e.RowIndex].Cells[0].Value);
                ViewArtist(selectedArtistId);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvArtists_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo ht;
                ht = dgvArtists.HitTest(e.X, e.Y);
                if (ht.Type == DataGridViewHitTestType.Cell) { mnuOptions.Show(Cursor.Position.X, Cursor.Position.Y); }
            }
        }
    }
}
