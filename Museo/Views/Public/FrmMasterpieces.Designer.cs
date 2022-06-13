
namespace Museo
{
    partial class FrmMasterpieces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterpieces));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblNbOfMasterpieces = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvMasterpieces = new System.Windows.Forms.DataGridView();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterpieces)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlBottom.Controls.Add(this.lblNbOfMasterpieces);
            this.pnlBottom.Controls.Add(this.picLogo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 517);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(991, 83);
            this.pnlBottom.TabIndex = 0;
            // 
            // lblNbOfMasterpieces
            // 
            this.lblNbOfMasterpieces.AutoSize = true;
            this.lblNbOfMasterpieces.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNbOfMasterpieces.Location = new System.Drawing.Point(12, 11);
            this.lblNbOfMasterpieces.Name = "lblNbOfMasterpieces";
            this.lblNbOfMasterpieces.Size = new System.Drawing.Size(75, 30);
            this.lblNbOfMasterpieces.TabIndex = 3;
            this.lblNbOfMasterpieces.Text = "Count";
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
            // dgvMasterpieces
            // 
            this.dgvMasterpieces.AccessibleName = "";
            this.dgvMasterpieces.AllowUserToAddRows = false;
            this.dgvMasterpieces.AllowUserToDeleteRows = false;
            this.dgvMasterpieces.AllowUserToResizeColumns = false;
            this.dgvMasterpieces.AllowUserToResizeRows = false;
            this.dgvMasterpieces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterpieces.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMasterpieces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMasterpieces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMasterpieces.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMasterpieces.Location = new System.Drawing.Point(0, 0);
            this.dgvMasterpieces.MultiSelect = false;
            this.dgvMasterpieces.Name = "dgvMasterpieces";
            this.dgvMasterpieces.ReadOnly = true;
            this.dgvMasterpieces.RowHeadersVisible = false;
            this.dgvMasterpieces.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMasterpieces.RowTemplate.Height = 25;
            this.dgvMasterpieces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMasterpieces.Size = new System.Drawing.Size(991, 517);
            this.dgvMasterpieces.TabIndex = 6;
            this.dgvMasterpieces.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasterpieces_CellDoubleClick);
            this.dgvMasterpieces.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMasterpieces_CellMouseDown);
            this.dgvMasterpieces.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMasterpieces_MouseClick);
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
            // FrmMasterpieces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.dgvMasterpieces);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMasterpieces";
            this.Load += new System.EventHandler(this.FrmMasterpieces_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterpieces)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.PictureBox picLogo;
        internal System.Windows.Forms.DataGridView dgvMasterpieces;
        private System.Windows.Forms.ContextMenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemView;
        private System.Windows.Forms.Label lblNbOfMasterpieces;
    }
}