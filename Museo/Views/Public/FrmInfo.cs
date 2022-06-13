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
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            lblDvcLocation.Text = "Siège social : \n30 rue de Turbigo, 75003 Paris";
            lblTeam.Text = "Équipe Da Vinci Code : \nJOSEPH Prince Emmanuel \nLACHET Quentin \nAKALMOUS Ikrame \nLE STUM Marc";
            lblMuseoLocation.Text = "Tout les chemins mènent au Muséo : \n20 place Terreaux, 69001 Lyon";
        }
    }
}
