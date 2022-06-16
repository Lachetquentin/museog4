using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminArtists : Form
    {
        internal int selectedArtistId;
        public FrmAdminArtists()
        {
            InitializeComponent();
        }

        private void FrmAdminArtists_Load(object sender, EventArgs e)
        {
            RefreshArtists();
            Start();
            AcceptButton = btnSearch;
        }

        internal void RefreshArtists()
        {
            dgvArtists.DataSource = DataLayer.ArtistData.GetAllArtists();
            lblNbOfArtists.Text = "Nombre d'artistes : " + DataLayer.ArtistData.GetAllArtists().Count.ToString();
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
            txtSearch.AutoSize = false;
            txtSearch.Height = 25;
        }

        private void mnuItemView_Click(object sender, EventArgs e)
        {
            ViewArtist();
        }
        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            if (selectedArtistId == 0) { return; }

            if (!DataLayer.ArtistData.CheckIfArtistExists(selectedArtistId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshArtists();
                return;
            }

            FrmAdminUpdateArtist frm = new FrmAdminUpdateArtist(selectedArtistId, RefreshArtists);
            frm.ShowDialog();
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            if (selectedArtistId == 0) { return; }

            if (!DataLayer.ArtistData.CheckIfArtistExists(selectedArtistId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshArtists();
                return;
            }

            var Result = MessageBox.Show("Voulez-vous vraiment supprimer cette artiste ?", "Supprimer Artiste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                if (DataLayer.ArtistData.DeleteArtist(selectedArtistId))
                {
                    RefreshArtists();
                    MessageBox.Show("Artiste supprimé !");
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

        private void ViewArtist()
        {
            if (selectedArtistId == 0) { return; }
            FrmViewArtist frm = new FrmViewArtist(selectedArtistId, RefreshArtists);
            frm.ShowDialog();
        }

        private void ViewArtist(int artistId)
        {
            if (selectedArtistId == 0) { return; }

            if (!DataLayer.ArtistData.CheckIfArtistExists(artistId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshArtists();
                return;
            }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdminCreateArtist frm = new FrmAdminCreateArtist(RefreshArtists);
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtSearch.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            List<Artist> ListOfArtists = DataLayer.ArtistData.SearchArtists(txtSearch.Text);
            lblNbOfArtists.Text = "Nombre d'artistes : " + ListOfArtists.Count.ToString();
            dgvArtists.DataSource = ListOfArtists;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            RefreshArtists();
        }
    }
}
