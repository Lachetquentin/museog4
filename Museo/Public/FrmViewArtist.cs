using MuseoLibrary;
using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmViewArtist : Form
    {
        private int artistId;
        private Artist artist;
        private int maxLength = 873;
        public FrmViewArtist(int selectedArtistId)
        {
            InitializeComponent();
            artistId = selectedArtistId;
            artist = DataLayer.ArtistData.GetArtistById(artistId);
            Text = artist.Name;
        }

        private void FrmViewArtist_Load(object sender, EventArgs e)
        {
            artist = DataLayer.ArtistData.GetArtistById(artistId);

            lblNameDob.Text = artist.Name + " (" + artist.Dob.ToShortDateString() + ")";

            //picImage.ImageLocation = artist.URL;

            string desc = artist.Desc;
            if (desc.Length > maxLength)
            {
                desc = desc.Substring(0, maxLength);
                desc += "...";
            };
            lblDesc.Text = desc;
        }

        private void btnArtistBibliography_Click(object sender, EventArgs e)
        {
            if (!DataLayer.ArtistData.CheckIfArtistExists(artistId))
            {
                FrmMain.MessageShow("NonExisting");
                ((FrmAdminArtists)Owner).RefreshArtists();
                Close(); 
                return;
            }

            FrmViewArtistBibliography frm = new FrmViewArtistBibliography(artistId);
            frm.ShowDialog();
        }
    }
}
