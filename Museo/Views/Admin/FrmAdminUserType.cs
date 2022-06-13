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
    public partial class FrmAdminUserType : Form
    {
        private User user;
        public FrmAdminUserType(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmAdminUsers frm = new FrmAdminUsers(user);
            frm.ShowDialog();
        }

        private void btnOwners_Click(object sender, EventArgs e)
        {
            FrmAdminOwners frm = new FrmAdminOwners();
            frm.ShowDialog();
        }
    }
}
