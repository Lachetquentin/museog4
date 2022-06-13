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
    public partial class FrmAdminMap : Form
    {
        public FrmAdminMap()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAdminLocations frm = new FrmAdminLocations();
            frm.ShowDialog();
        }

        private void btnFloorZero_Click(object sender, EventArgs e)
        {
            picMap.Image = Properties.Resources.plan_museo_1;
        }

        private void btnFirstFloor_Click(object sender, EventArgs e)
        {
            picMap.Image = Properties.Resources.plan_museo_2;
        }

        private void btnSecondFloor_Click(object sender, EventArgs e)
        {
            picMap.Image = Properties.Resources.plan_museo_3;
        }
    }
}
