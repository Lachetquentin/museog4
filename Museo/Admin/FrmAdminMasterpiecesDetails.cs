using System;
using System.Windows.Forms;

namespace Museo
{
    public partial class FrmAdminMasterpiecesDetails : Form
    {
        public FrmAdminMasterpiecesDetails()
        {
            InitializeComponent();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            FrmAdminStates frm = new FrmAdminStates();
            frm.ShowDialog();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            FrmAdminStatus frm = new FrmAdminStatus();
            frm.ShowDialog();
        }
    }
}
