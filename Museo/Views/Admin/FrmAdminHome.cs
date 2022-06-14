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
    public partial class FrmAdminHome : Form
    {
        public FrmAdminHome()
        {
            InitializeComponent();
        }

        private void FrmAdminHome_Load(object sender, EventArgs e)
        {
            lblNbArtists.Text = DataLayer.ArtistData.GetAllArtists().Count.ToString();
            lblNbExhibitions.Text = DataLayer.ExhibitionData.GetAllExhibitions().Count.ToString();
            lblNbMp.Text = DataLayer.MasterpieceData.GetAllMasterpieces().Count.ToString();
            lblNbOwners.Text = DataLayer.OwnerData.GetAllOwners().Count.ToString();
        }
    }
}
