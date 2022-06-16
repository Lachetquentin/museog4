using System;
using System.Globalization;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminUpdateArtist : Form
    {
        private int artistId;
        private Artist artist = new Artist();
        private readonly Action _refreshArtists;
        public FrmAdminUpdateArtist(int selectedArtistId, Action refreshArtists)
        {
            InitializeComponent();
            artistId = selectedArtistId;
            _refreshArtists = refreshArtists;
            AcceptButton = btnUpdate;
            CancelButton = btnQuit;
        }

        private void FrmAdminUpdateArtist_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtDesc.Text) || Utils.Checker(txtName.Text)
                || Utils.Checker(txtIsni.Text) || Utils.Checker(txtURL.Text) || Utils.Checker(txtDob.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            DateTime dob;
            try
            {
                CultureInfo ci = CultureInfo.InvariantCulture;
                dob = DateTime.ParseExact(txtDob.Text, "dd/MM/yyyy", ci);
            }
            catch (Exception)
            {
                FrmMain.MessageShow("InvalidDate");
                return;
            }

            if (txtIsni.Text.Length > 9)
            {
                MessageBox.Show("ISNI trop long ! Un maximum de 9 chiffres est autorisé !");
                return;
            }

            int isni;

            if (int.TryParse(txtIsni.Text, out int result))
            {
                isni = result;
            }
            else
            {
                FrmMain.MessageShow("UpdateFailed");
                return;
            }

            if (txtURL.Text.Length > 999)
            {
                MessageBox.Show("URL trop longue ! Un maximum de 999 caractères est autorisé !");
                return;
            }

            if (DataLayer.ArtistData.UpdateArtist(artistId, txtName.Text, dob.Date, txtDesc.Text, txtURL.Text, isni))
            {
                MessageBox.Show("L'artiste à bien été mis à jour !");
                _refreshArtists();
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

        private void SetupForm()
        {
            artist = DataLayer.ArtistData.GetArtistById(artistId);
            txtDob.Text = artist.Dob.ToShortDateString();
            txtName.Text = artist.Name;
            txtDesc.Text = artist.Desc;
            txtIsni.Text = artist.Isni.ToString();
            txtURL.Text = artist.URL;
        }       
    }
}
