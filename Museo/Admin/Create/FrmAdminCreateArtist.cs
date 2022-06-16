using System;
using System.Globalization;
using System.Windows.Forms;
using MuseoLibrary;

namespace Museo
{
    public partial class FrmAdminCreateArtist : Form
    {
        private readonly Action _refreshArtists;
        public FrmAdminCreateArtist(Action refreshArtists)
        {
            InitializeComponent();
            _refreshArtists = refreshArtists;
        }

        private void FrmAdminCreateArtist_Load(object sender, EventArgs e)
        {
            SetupForm();
            AcceptButton = btnAdd;
            CancelButton = btnQuit;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utils.Checker(txtDesc.Text) || Utils.Checker(txtName.Text)
                || Utils.Checker(txtIsni.Text) || Utils.Checker(txtURL.Text) || Utils.Checker(txtDob.Text))
            {
                FrmMain.MessageShow("NullOrWhiteSpace");
                return;
            }

            DateTime dob = new DateTime();
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

            if(txtIsni.Text.Length > 9)
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

            if (DataLayer.ArtistData.AddArtist(txtName.Text, dob.Date, txtDesc.Text, txtURL.Text, isni))
            {
                MessageBox.Show("L'artiste à bien été mis crée !");
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
            txtDob.Text = "";
            txtName.Text = "";
            txtDesc.Text = "";
            txtIsni.Text = "";
            txtURL.Text = "";
        }
    }
}
