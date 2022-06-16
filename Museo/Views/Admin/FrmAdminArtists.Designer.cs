
namespace Museo
{
    partial class FrmAdminArtists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminArtists));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNbOfArtists = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvArtists = new System.Windows.Forms.DataGridView();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlBottom.Controls.Add(this.btnClear);
            this.pnlBottom.Controls.Add(this.btnSearch);
            this.pnlBottom.Controls.Add(this.txtSearch);
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Controls.Add(this.lblNbOfArtists);
            this.pnlBottom.Controls.Add(this.picLogo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 517);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(991, 83);
            this.pnlBottom.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(714, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(27, 25);
            this.btnClear.TabIndex = 9;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(687, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 25);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(394, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Recherche...";
            this.txtSearch.Size = new System.Drawing.Size(292, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(765, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 83);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.dgvArtists.ShowCellToolTips = false;
            this.dgvArtists.Size = new System.Drawing.Size(991, 600);
            this.dgvArtists.TabIndex = 12;
            this.dgvArtists.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtists_CellDoubleClick);
            this.dgvArtists.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArtists_CellMouseDown);
            this.dgvArtists.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvArtists_MouseClick);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemView,
            this.mnuItemUpdate,
            this.mnuItemDelete});
            this.mnuOptions.Name = "mnuMasterpieces";
            this.mnuOptions.Size = new System.Drawing.Size(130, 70);
            // 
            // mnuItemView
            // 
            this.mnuItemView.Name = "mnuItemView";
            this.mnuItemView.Size = new System.Drawing.Size(129, 22);
            this.mnuItemView.Text = "Voir";
            this.mnuItemView.Click += new System.EventHandler(this.mnuItemView_Click);
            // 
            // mnuItemUpdate
            // 
            this.mnuItemUpdate.Name = "mnuItemUpdate";
            this.mnuItemUpdate.Size = new System.Drawing.Size(129, 22);
            this.mnuItemUpdate.Text = "Modifier";
            this.mnuItemUpdate.Click += new System.EventHandler(this.mnuItemUpdate_Click);
            // 
            // mnuItemDelete
            // 
            this.mnuItemDelete.Name = "mnuItemDelete";
            this.mnuItemDelete.Size = new System.Drawing.Size(129, 22);
            this.mnuItemDelete.Text = "Supprimer";
            this.mnuItemDelete.Click += new System.EventHandler(this.mnuItemDelete_Click);
            // 
            // FrmAdminArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.dgvArtists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminArtists";
            this.Text = "Voir les artistes";
            this.Load += new System.EventHandler(this.FrmAdminArtists_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblNbOfArtists;
        private System.Windows.Forms.PictureBox picLogo;
        internal System.Windows.Forms.DataGridView dgvArtists;
        private System.Windows.Forms.ContextMenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemView;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}