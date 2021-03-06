
namespace Museo
{
    partial class FrmArtists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArtists));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblNbOfArtists = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvArtists = new System.Windows.Forms.DataGridView();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.mnuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlBottom.Controls.Add(this.lblNbOfArtists);
            this.pnlBottom.Controls.Add(this.picLogo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 517);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(991, 83);
            this.pnlBottom.TabIndex = 9;
            // 
            // lblNbOfArtists
            // 
            this.lblNbOfArtists.AutoSize = true;
            this.lblNbOfArtists.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNbOfArtists.Location = new System.Drawing.Point(12, 11);
            this.lblNbOfArtists.Name = "lblNbOfArtists";
            this.lblNbOfArtists.Size = new System.Drawing.Size(75, 30);
            this.lblNbOfArtists.TabIndex = 1;
            this.lblNbOfArtists.Text = "Count";
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(889, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(102, 83);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemView});
            this.mnuOptions.Name = "mnuMasterpieces";
            this.mnuOptions.Size = new System.Drawing.Size(95, 26);
            // 
            // mnuItemView
            // 
            this.mnuItemView.Name = "mnuItemView";
            this.mnuItemView.Size = new System.Drawing.Size(94, 22);
            this.mnuItemView.Text = "Voir";
            this.mnuItemView.Click += new System.EventHandler(this.mnuItemView_Click);
            // 
            // dgvArtists
            // 
            this.dgvArtists.AccessibleName = "";
            this.dgvArtists.AllowUserToAddRows = false;
            this.dgvArtists.AllowUserToDeleteRows = false;
            this.dgvArtists.AllowUserToResizeColumns = false;
            this.dgvArtists.AllowUserToResizeRows = false;
            this.dgvArtists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtists.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArtists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArtists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArtists.Location = new System.Drawing.Point(0, 0);
            this.dgvArtists.MultiSelect = false;
            this.dgvArtists.Name = "dgvArtists";
            this.dgvArtists.ReadOnly = true;
            this.dgvArtists.RowHeadersVisible = false;
            this.dgvArtists.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArtists.RowTemplate.Height = 25;
            this.dgvArtists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtists.Size = new System.Drawing.Size(991, 517);
            this.dgvArtists.TabIndex = 10;
            this.dgvArtists.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtists_CellDoubleClick);
            this.dgvArtists.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArtists_CellMouseDown);
            this.dgvArtists.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvArtists_MouseClick);
            // 
            // FrmArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.dgvArtists);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArtists";
            this.Text = "Voir les artistes";
            this.Load += new System.EventHandler(this.FrmExhibitions_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ContextMenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemView;
        internal System.Windows.Forms.DataGridView dgvArtists;
        private System.Windows.Forms.Label lblNbOfArtists;
    }
}