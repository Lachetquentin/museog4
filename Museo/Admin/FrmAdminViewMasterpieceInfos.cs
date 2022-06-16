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
    public partial class FrmAdminViewMasterpieceInfos : Form
    {
        private Masterpiece masterpiece;
        public FrmAdminViewMasterpieceInfos(Masterpiece mp)
        {
            InitializeComponent();
            masterpiece = mp;
        }

        private void FrmAdminViewMasterpieceInfos_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void SetupForm()
        {
            MpState state = DataLayer.MpStateData.GetStateById(masterpiece.StateId);
            MpStatus status = DataLayer.MpStatusData.GetStatusById(masterpiece.StatusId);

            lblStateResult.Text = state.Name;
            lblStatusResult.Text = status.Name;
            txtMemo.Text = masterpiece.Memo;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
