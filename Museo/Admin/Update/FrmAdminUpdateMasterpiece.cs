using MuseoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminUpdateMasterpiece : Form
    {
        private int mpId;
        private Masterpiece mp = new Masterpiece();
        private readonly Action _refreshMasterpieces;
        public FrmAdminUpdateMasterpiece(int selectedMasterpieceId, Action refreshMasterpieces)
        {
            InitializeComponent();
            mpId = selectedMasterpieceId;
            _refreshMasterpieces = refreshMasterpieces;
            mp = DataLayer.MasterpieceData.GetMasterpieceById(mpId);
            Text = "Modification d'une oeuvre ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DataLayer.MasterpieceData.UpdateMasterpiece(mpId, (Artist)cbAuthor.SelectedItem, (Exhibition)cbExhibition.SelectedItem, (MpState)cbState.SelectedItem, (MpStatus)cbStatus.SelectedItem, (Location)cbLocation.SelectedItem, (Owner)cbOwner.SelectedItem, txtName.Text, Convert.ToInt32(txtCreationYear.Text), txtDesc.Text, txtMemo.Text, txtURL.Text, txtNcda.Text))
            {
                MessageBox.Show("L'oeuvre à bien été mise à jour !");
                _refreshMasterpieces();
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAdminUpdateMasterpiece_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void SetupForm()
        {
            List<Artist> listOfArtists = DataLayer.ArtistData.GetAllArtists();
            List<Exhibition> exhibition = DataLayer.ExhibitionData.GetAllExhibitions();
            List<Location> location = DataLayer.LocationData.GetAllLocations();
            List<MpState> mpState = DataLayer.MpStateData.GetAllStates();
            List<MpStatus> status = DataLayer.MpStatusData.GetAllStatus();
            List<Owner> owner = DataLayer.OwnerData.GetAllOwners();

            cbAuthor.DataSource = listOfArtists;
            cbAuthor.DisplayMember = "Name";

            cbExhibition.DataSource = exhibition;
            cbExhibition.DisplayMember = "Name";

            cbLocation.DataSource = location;
            cbLocation.DisplayMember = "Name";

            cbState.DataSource = mpState;
            cbState.DisplayMember = "Name";

            cbStatus.DataSource = status;
            cbStatus.DisplayMember = "Name";

            cbOwner.DataSource = owner;
            cbOwner.DisplayMember = "Name";

            txtName.Text = mp.Name;
            txtDesc.Text = mp.Desc;
            txtCreationYear.Text = mp.CreateYear.ToString();
            txtMemo.Text = mp.Memo;
            txtURL.Text = mp.URL;
            txtNcda.Text = mp.Ncda;
        }
    }
}
