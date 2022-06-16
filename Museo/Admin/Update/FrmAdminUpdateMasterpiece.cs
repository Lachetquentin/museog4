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
            AcceptButton = btnUpdate;
            CancelButton = btnQuit;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtCreationYear.Text) || Utils.Checker(txtDesc.Text) || Utils.Checker(txtName.Text) 
                || Utils.Checker(txtNcda.Text) || Utils.Checker(txtURL.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            if (txtCreationYear.Text.Length > 4)
            {
                MessageBox.Show("Année trop long ! Un maximum de 4 chiffres est autorisé !");
                return;
            }

            int creationYear;

            if (int.TryParse(txtCreationYear.Text, out int value))
            {
                creationYear = value;
            }
            else
            {
                FrmMain.MessageShow("UpdateFailed");
                return;
            }

            if (txtNcda.Text.Length > 9)
            {
                MessageBox.Show("NCDA trop long ! Un maximum de 9 chiffres est autorisé !");
                return;
            }

            int ncda;

            if (int.TryParse(txtNcda.Text, out int result))
            {
                ncda = result;
            }
            else
            {
                FrmMain.MessageShow("UpdateFailed");
                return;
            }

            if (DataLayer.MasterpieceData.UpdateMasterpiece(mpId, (Artist)cbAuthor.SelectedItem, (Exhibition)cbExhibition.SelectedItem, (MpState)cbState.SelectedItem, (MpStatus)cbStatus.SelectedItem, (Location)cbLocation.SelectedItem, (Owner)cbOwner.SelectedItem, txtName.Text, creationYear, txtDesc.Text, txtMemo.Text, txtURL.Text, ncda))
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
            mp = DataLayer.MasterpieceData.GetMasterpieceById(mpId);
            List<Artist> listOfArtists = DataLayer.ArtistData.GetAllArtists();
            List<Exhibition> exhibition = DataLayer.ExhibitionData.GetAllExhibitions();
            List<Location> location = DataLayer.LocationData.GetAllLocations();
            List<MpState> state = DataLayer.MpStateData.GetAllStates();
            List<MpStatus> status = DataLayer.MpStatusData.GetAllStatus();
            List<Owner> owner = DataLayer.OwnerData.GetAllOwners();

            Artist artist = DataLayer.ArtistData.GetArtistById(mp.ArtistId);
            Exhibition exh = DataLayer.ExhibitionData.GetExhibitionById(mp.ExhibitionId);
            Location loc = DataLayer.LocationData.GetLocationById(mp.LocationId);
            MpState mpState = DataLayer.MpStateData.GetStateById(mp.StateId);
            MpStatus mpStatus = DataLayer.MpStatusData.GetStatusById(mp.StatusId);
            Owner own = DataLayer.OwnerData.GetOwnerById(mp.OwnerId);

            cbAuthor.DataSource = listOfArtists;
            cbAuthor.DisplayMember = "Name";
            cbAuthor.SelectedIndex = cbAuthor.FindString(artist.Name);

            cbExhibition.DataSource = exhibition;
            cbExhibition.DisplayMember = "Name";
            cbExhibition.SelectedIndex = cbExhibition.FindString(exh.Name);

            cbLocation.DataSource = location;
            cbLocation.DisplayMember = "Name";
            cbLocation.SelectedIndex = cbLocation.FindString(loc.Name);

            cbState.DataSource = state;
            cbState.DisplayMember = "Name";
            cbState.SelectedIndex = cbState.FindString(mpState.Name);

            cbStatus.DataSource = status;
            cbStatus.DisplayMember = "Name";
            cbStatus.SelectedIndex = cbStatus.FindString(mpStatus.Name);

            cbOwner.DataSource = owner;
            cbOwner.DisplayMember = "Name";
            cbOwner.SelectedIndex = cbOwner.FindString(own.Name);

            txtName.Text = mp.Name;
            txtDesc.Text = mp.Desc;
            txtCreationYear.Text = mp.CreateYear.ToString();
            txtMemo.Text = mp.Memo;
            txtURL.Text = mp.URL;
            txtNcda.Text = mp.Ncda.ToString();
        }
    }
}
