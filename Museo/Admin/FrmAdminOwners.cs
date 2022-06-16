using MuseoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminOwners : Form
    {
        private int selectedOwnerId;
        public FrmAdminOwners()
        {
            InitializeComponent();
        }
        private void FrmAdminOwners_Load(object sender, EventArgs e)
        {
            RefreshOwners();
            GridSetup();
            AcceptButton = btnSearch;
        }

        private void GridSetup()
        {
            dgvOwners.EnableHeadersVisualStyles = false;
            dgvOwners.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvOwners.ColumnHeadersDefaultCellStyle.BackColor;
            dgvOwners.Columns["OwnerId"].Visible = false;
            dgvOwners.Columns["Location"].HeaderText = "Emplacement";
            dgvOwners.Columns["Name"].HeaderText = "Nom";
            dgvOwners.Columns["PhoneNumber"].HeaderText = "Numéro de téléphone";
            txtSearch.AutoSize = false;
            txtSearch.Height = 25;
        }

        private void mnuItemUpdate_Click(object sender, EventArgs e)
        {
            UpdateOwner();
        }

        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            if (selectedOwnerId == 0) { return; }

            if (!DataLayer.OwnerData.CheckIfOwnerExists(selectedOwnerId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshOwners();
                return;
            }

            var Result = MessageBox.Show("Voulez-vous vraiment supprimer ce propriétaire ?", "Supprimer Propriétaire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                if (DataLayer.OwnerData.DeleteOwner(selectedOwnerId))
                {
                    RefreshOwners();
                    MessageBox.Show("Propriétaire supprimé !");
                } else
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

        private void UpdateOwner()
        {
            if (selectedOwnerId == 0) { return; }

            if (!DataLayer.OwnerData.CheckIfOwnerExists(selectedOwnerId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshOwners();
                return;
            }

            FrmAdminUpdateOwner frm = new FrmAdminUpdateOwner(selectedOwnerId, RefreshOwners);
            frm.ShowDialog();
        }

        private void RefreshOwners()
        {
            dgvOwners.DataSource = DataLayer.OwnerData.GetAllOwners();
            lblNbOfOwners.Text = "Nombre de propriétaires : " + DataLayer.OwnerData.GetAllOwners().Count.ToString();
        }

        private void UpdateOwner(int ownerId)
        {
            if (ownerId == 0) { return; }

            if (!DataLayer.OwnerData.CheckIfOwnerExists(ownerId))
            {
                FrmMain.MessageShow("NonExisting");
                RefreshOwners();
                return;
            }

            FrmAdminUpdateOwner frm = new FrmAdminUpdateOwner(ownerId, RefreshOwners);
            frm.ShowDialog();
        }

        private void dgvOwners_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgvOwners.CurrentCell = dgvOwners.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dgvOwners.Rows[e.RowIndex].Selected = true;
                    dgvOwners.Focus();

                    selectedOwnerId = Convert.ToInt32(dgvOwners.Rows[e.RowIndex].Cells[0].Value);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void dgvOwners_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedOwnerId = Convert.ToInt32(dgvOwners.Rows[e.RowIndex].Cells[0].Value);
                UpdateOwner(selectedOwnerId);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvOwners_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo ht;
                ht = dgvOwners.HitTest(e.X, e.Y);
                if (ht.Type == DataGridViewHitTestType.Cell) { mnuOptions.Show(Cursor.Position.X, Cursor.Position.Y); }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdminCreateOwner frm = new FrmAdminCreateOwner(RefreshOwners);
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtSearch.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            List<Owner> owners = DataLayer.OwnerData.SearchOwners(txtSearch.Text);
            lblNbOfOwners.Text = "Nombre d'administrateurs : " + owners.Count.ToString();
            dgvOwners.DataSource = owners;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            RefreshOwners();
        }
    }
}
