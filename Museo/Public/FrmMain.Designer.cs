
namespace Museo
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.toolbar = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblExhibition = new System.Windows.Forms.Label();
            this.lblMasterpiece = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.btnMap = new System.Windows.Forms.PictureBox();
            this.btnArtist = new System.Windows.Forms.PictureBox();
            this.btnExhibition = new System.Windows.Forms.PictureBox();
            this.btnMasterpiece = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExhibition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMasterpiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.mnuTrayIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.toolbar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1074, 89);
            this.pnlTop.TabIndex = 0;
            // 
            // toolbar
            // 
            this.toolbar.ColumnCount = 6;
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66319F));
            this.toolbar.Controls.Add(this.lblInfo, 5, 1);
            this.toolbar.Controls.Add(this.lblMap, 4, 1);
            this.toolbar.Controls.Add(this.lblArtist, 3, 1);
            this.toolbar.Controls.Add(this.lblExhibition, 2, 1);
            this.toolbar.Controls.Add(this.lblMasterpiece, 1, 1);
            this.toolbar.Controls.Add(this.lblHome, 0, 1);
            this.toolbar.Controls.Add(this.btnInfo, 5, 0);
            this.toolbar.Controls.Add(this.btnMap, 4, 0);
            this.toolbar.Controls.Add(this.btnArtist, 3, 0);
            this.toolbar.Controls.Add(this.btnExhibition, 2, 0);
            this.toolbar.Controls.Add(this.btnMasterpiece, 1, 0);
            this.toolbar.Controls.Add(this.btnHome, 0, 0);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RowCount = 2;
            this.toolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.toolbar.Size = new System.Drawing.Size(1074, 89);
            this.toolbar.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(898, 69);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(173, 20);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "Informations";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMap.Location = new System.Drawing.Point(719, 69);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(173, 20);
            this.lblMap.TabIndex = 10;
            this.lblMap.Text = "Cartographie du musée";
            this.lblMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArtist.Location = new System.Drawing.Point(540, 69);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(173, 20);
            this.lblArtist.TabIndex = 9;
            this.lblArtist.Text = "Liste des artistes";
            this.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExhibition
            // 
            this.lblExhibition.AutoSize = true;
            this.lblExhibition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExhibition.Location = new System.Drawing.Point(361, 69);
            this.lblExhibition.Name = "lblExhibition";
            this.lblExhibition.Size = new System.Drawing.Size(173, 20);
            this.lblExhibition.TabIndex = 8;
            this.lblExhibition.Text = "Liste des expositions";
            this.lblExhibition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMasterpiece
            // 
            this.lblMasterpiece.AutoSize = true;
            this.lblMasterpiece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMasterpiece.Location = new System.Drawing.Point(182, 69);
            this.lblMasterpiece.Name = "lblMasterpiece";
            this.lblMasterpiece.Size = new System.Drawing.Size(173, 20);
            this.lblMasterpiece.TabIndex = 7;
            this.lblMasterpiece.Text = "Galerie des oeuvres";
            this.lblMasterpiece.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHome.Location = new System.Drawing.Point(3, 69);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(173, 20);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Accueil";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(898, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(173, 63);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfo.TabIndex = 6;
            this.btnInfo.TabStop = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnMap
            // 
            this.btnMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMap.Image = ((System.Drawing.Image)(resources.GetObject("btnMap.Image")));
            this.btnMap.Location = new System.Drawing.Point(719, 3);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(173, 63);
            this.btnMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMap.TabIndex = 5;
            this.btnMap.TabStop = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArtist.Image = ((System.Drawing.Image)(resources.GetObject("btnArtist.Image")));
            this.btnArtist.Location = new System.Drawing.Point(540, 3);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(173, 63);
            this.btnArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnArtist.TabIndex = 4;
            this.btnArtist.TabStop = false;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // btnExhibition
            // 
            this.btnExhibition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExhibition.Image = ((System.Drawing.Image)(resources.GetObject("btnExhibition.Image")));
            this.btnExhibition.Location = new System.Drawing.Point(361, 3);
            this.btnExhibition.Name = "btnExhibition";
            this.btnExhibition.Size = new System.Drawing.Size(173, 63);
            this.btnExhibition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExhibition.TabIndex = 3;
            this.btnExhibition.TabStop = false;
            this.btnExhibition.Click += new System.EventHandler(this.btnExhibition_Click);
            // 
            // btnMasterpiece
            // 
            this.btnMasterpiece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMasterpiece.Image = ((System.Drawing.Image)(resources.GetObject("btnMasterpiece.Image")));
            this.btnMasterpiece.Location = new System.Drawing.Point(182, 3);
            this.btnMasterpiece.Name = "btnMasterpiece";
            this.btnMasterpiece.Size = new System.Drawing.Size(173, 63);
            this.btnMasterpiece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMasterpiece.TabIndex = 2;
            this.btnMasterpiece.TabStop = false;
            this.btnMasterpiece.Click += new System.EventHandler(this.btnMasterpiece_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(173, 63);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 609);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1074, 15);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 89);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1074, 520);
            this.pnlMain.TabIndex = 2;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.mnuTrayIcon;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Museo";
            this.trayIcon.Visible = true;
            // 
            // mnuTrayIcon
            // 
            this.mnuTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuExit});
            this.mnuTrayIcon.Name = "ctxtMenu";
            this.mnuTrayIcon.Size = new System.Drawing.Size(154, 48);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(153, 22);
            this.mnuAdmin.Text = "Administration";
            this.mnuAdmin.Click += new System.EventHandler(this.mnuAdmin_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(153, 22);
            this.mnuExit.Text = "Quitter";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 624);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1090, 663);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museo";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExhibition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMasterpiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.mnuTrayIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.FlowLayoutPanel pnlBottom;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel toolbar;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblExhibition;
        private System.Windows.Forms.Label lblMasterpiece;
        private System.Windows.Forms.PictureBox btnInfo;
        private System.Windows.Forms.PictureBox btnMap;
        private System.Windows.Forms.PictureBox btnArtist;
        private System.Windows.Forms.PictureBox btnExhibition;
        private System.Windows.Forms.PictureBox btnMasterpiece;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip mnuTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}