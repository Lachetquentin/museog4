using MuseoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminCreateMasterpiece : Form
    {
        private readonly Action _refreshMasterpieces;
        public FrmAdminCreateMasterpiece(Action refreshMasterpieces)
        {
            InitializeComponent();
            _refreshMasterpieces = refreshMasterpieces;
            AcceptButton = btnAdd;
            CancelButton = btnQuit;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtCreationYear.Text) || Utils.Checker(txtDesc.Text) || Utils.Checker(txtName.Text)
                || Utils.Checker(txtNcda.Text) || Utils.Checker(txtURL.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            if (txtCreationYear.Text.Length > 4)
            {
                MessageBox.Show("Année trop longue ! Un maximum de 4 chiffres est autorisé !");
                return;
            }

            int creationYear;

            if (int.TryParse(txtCreationYear.Text, out int value))
            {
                creationYear = value;
            }
            else
            {
                FrmMain.MessageShow("CreationFailed");
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
                FrmMain.MessageShow("CreationFailed");
                return;
            }

            if(txtURL.Text.Length > 999)
            {
                MessageBox.Show("URL trop longue ! Un maximum de 999 caractères est autorisé !");
                return;
            }

            if (DataLayer.MasterpieceData.AddMasterpiece((Artist)cbAuthor.SelectedItem, (Exhibition)cbExhibition.SelectedItem, (MpState)cbState.SelectedItem, (MpStatus)cbStatus.SelectedItem, (Location)cbLocation.SelectedItem, (Owner)cbOwner.SelectedItem, txtName.Text, creationYear, txtDesc.Text, txtMemo.Text, txtURL.Text, ncda))
            {
                MessageBox.Show("L'oeuvre à bien été crée !");
                _refreshMasterpieces();
                Close();
            }
            else
            {
                FrmMain.MessageShow("CreationFailed");
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

        private void FrmAdminCreateMasterpiece_Load(object sender, EventArgs e)
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

            txtName.Text = "";
            txtDesc.Text = "";
            txtCreationYear.Text = "";
            txtMemo.Text = "";
            txtURL.Text = "";
            txtNcda.Text = "";
        }
    }
}
