using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblHome.Text = "Bienvenue au Muséo Lyon \n Il y a toujours une bonne raison de venir au Muséo. \n Les oeuvres que nous exposons vous étonnent, vous invitent à rêver, à imaginer. \n Profitez de votre visite !";
        }
    }
}
