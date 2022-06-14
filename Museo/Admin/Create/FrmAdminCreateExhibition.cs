using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminCreateExhibition : Form
    {
        private readonly Action _refreshExhibitions;
        public FrmAdminCreateExhibition(Action refreshExhibitions)
        {
            InitializeComponent();
            _refreshExhibitions = refreshExhibitions;
            AcceptButton = btnAdd;
            CancelButton = btnQuit;
        }

        private void FrmAdminCreateExhibition_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtName.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            if (DataLayer.ExhibitionData.AddExhibition(txtName.Text))
            {
                MessageBox.Show("L'exposition à bien été crée !");
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
            txtName.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
