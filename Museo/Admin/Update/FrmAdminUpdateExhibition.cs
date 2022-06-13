using MuseoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminUpdateExhibition : Form
    {
        private int exhibitionId;
        private Exhibition exhibition = new Exhibition();
        private readonly Action _refreshExhibitions;
        public FrmAdminUpdateExhibition(int selectedExhibitionId, Action refreshExhibitions)
        {
            InitializeComponent();
            exhibitionId = selectedExhibitionId;
            _refreshExhibitions = refreshExhibitions;
        }

        private void FrmAdminUpdateExhibition_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DataLayer.ExhibitionData.UpdateExhibition(exhibitionId, txtName.Text))
            {
                MessageBox.Show("L'exposition à bien été mise à jour !");
                _refreshExhibitions();
                Close();
            }
            else
            {
                FrmMain.MessageShow("UpdateFailed");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void SetupForm()
        {
            exhibition = DataLayer.ExhibitionData.GetExhibitionById(exhibitionId);
            txtName.Text = exhibition.Name;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
