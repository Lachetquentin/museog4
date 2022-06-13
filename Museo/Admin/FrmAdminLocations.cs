using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminLocations : Form
    {
        private int selectedLocationId;
        public FrmAdminLocations()
        {
            InitializeComponent();
        }
        private void FrmAdminLocations_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Liste des emplacements";
            RefreshLocations();
            GridSetup();
        }

        private void GridSetup()
        {
            dgvLocations.EnableHeadersVisualStyles = false;
            dgvLocations.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvLocations.ColumnHeadersDefaultCellStyle.BackColor;
            dgvLocations.Columns["Name"].HeaderText = "Nom";
            dgvLocations.Columns["LocationId"].Visible = false;
        }

        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            UpdateLocation();
        }

        private void UpdateLocation()
        {
            if (selectedLocationId == 0) { return; }

            if (!DataLayer.LocationData.CheckIfLocationExists(selectedLocationId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshLocations();
                return;
            }

            FrmAdminUpdateLocation frm = new FrmAdminUpdateLocation(selectedLocationId, RefreshLocations);
            frm.ShowDialog();
        }

        private void RefreshLocations()
        {
            dgvLocations.DataSource = DataLayer.LocationData.GetAllLocations();
        }

        private void UpdateLocation(int locationId)
        {
            if (locationId == 0) { return; }

            if (!DataLayer.LocationData.CheckIfLocationExists(locationId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshLocations();
                return;
            }

            FrmAdminUpdateLocation frm = new FrmAdminUpdateLocation(locationId, RefreshLocations);
            frm.ShowDialog();
        }

        private void dgvLocations_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvLocations.CurrentCell = dgvLocations.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvLocations.Rows[e.RowIndex].Selected = true;
                    dgvLocations.Focus();

                    selectedLocationId = Convert.ToInt32(dgvLocations.Rows[e.RowIndex].Cells[0].Value);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void dgvLocations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedLocationId = Convert.ToInt32(dgvLocations.Rows[e.RowIndex].Cells[0].Value);
                UpdateLocation(selectedLocationId);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvLocations_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo ht;
                ht = dgvLocations.HitTest(e.X, e.Y);
                if (ht.Type == DataGridViewHitTestType.Cell) { mnuOptions.Show(Cursor.Position.X, Cursor.Position.Y); }
            }
        }
    }
}
