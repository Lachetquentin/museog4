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
    public partial class FrmMain : Form
    {
        private Boolean menuAdminIsOn = false;
        private Form activeForm = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            openChildForm(new FrmHome());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmHome());
        }

        private void btnMasterpiece_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMasterpieces());
        }

        private void btnExhibition_Click(object sender, EventArgs e)
        {
           openChildForm(new FrmExhibitions());
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmArtists());
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMap());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmInfo());
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            if (menuAdminIsOn)
            {
                return;
            }
            menuAdminIsOn = true;
            FrmLogin login = new FrmLogin();
            login.Show();
            login.Activate();
            Hide();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        internal static void MessageShow(string msgCode)
        {
            string msg = "";

            switch (msgCode)
            {
                case "NullOrWhiteSpace":
                    msg = "Veuillez saisir des données correctes s'il vous plaît ! \n(Vide et Espace interdit)";
                    break;
                case "LoginFailed":
                    msg = "Connexion échouée, vérifiez vos informations de connexion !";
                    break;
                case "PhoneNumberNotValid":
                    msg = "Numéro de téléphone non valide ! Veuillez vérifier s'il vous plaît.";
                    break;
                case "AlreadyExisting":
                    msg = "Ce que vous voulez ajouter existe déjà dans le système !";
                    break;
                case "NonExisting":
                    msg = "Ce que vous avez selectionné n'existe pas dans le système !";
                    break;
                case "DeletingYourself":
                    msg = "Vous ne pouvez pas vous supprimez vous-même !";
                    break;
                default:
                    msg = "Error : " + msgCode;
                    break;
            }

            MessageBox.Show(msg, "Museo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void Quit()
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
