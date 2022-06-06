using MuseoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmViewMasterpiece : Form
    {
        private int masterpieceId;
        private Masterpiece mp;
        private int maxLength = 600;
        public FrmViewMasterpiece(int selectedMasterpieceId)
        {
            InitializeComponent();
            masterpieceId = selectedMasterpieceId;
            mp = DataLayer.MasterpieceData.GetMasterpieceById(masterpieceId);
            Text = mp.Name;
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            Artist artist = DataLayer.ArtistData.GetArtistById(mp.ArtistId);
            Location location = DataLayer.LocationData.GetLocationById(mp.LocationId);
            Exhibition exhibition = DataLayer.ExhibitionData.GetExhibitionById(mp.ExhibitionId);

            lblTitle.Text = mp.Name + " (" + mp.CreateYear + ")";
            lblYearAuthor.Text =  "par " + artist.Name;
            lblExhibition.Text = exhibition.Name;
            lblLocation.Text = location.Name;

            string desc = mp.Desc;
            if (desc.Length > maxLength) 
            {
                desc.Substring(0, maxLength);
                desc += "...";
            };
            lblDesc.Text = desc;
        }
    }
}
