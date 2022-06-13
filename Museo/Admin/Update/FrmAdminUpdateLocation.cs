using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminUpdateLocation : Form
    {
        private int locationId;
        private Location location = new Location();
        private readonly Action _refreshLocations;
        public FrmAdminUpdateLocation(int selectedExhibitionId, Action refreshLocations)
        {
            InitializeComponent();
            locationId = selectedExhibitionId;
            _refreshLocations = refreshLocations;
        }

        private void FrmAdminUpdateLocation_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DataLayer.LocationData.UpdateLocation(locationId, txtName.Text))
            {
                MessageBox.Show("L'emplacement à bien été mise à jour !");
                _refreshLocations();
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
            location = DataLayer.LocationData.GetLocationById(locationId);
            txtName.Text = location.Name;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
