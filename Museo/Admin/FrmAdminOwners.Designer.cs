
namespace Museo
{
    partial class FrmAdminOwners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminOwners));
            this.dgvOwners = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNbOfOwners = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOwners
            // 
            this.dgvOwners.AccessibleName = "";
            this.dgvOwners.AllowUserToAddRows = false;
            this.dgvOwners.AllowUserToDeleteRows = false;
            this.dgvOwners.AllowUserToResizeColumns = false;
            this.dgvOwners.AllowUserToResizeRows = false;
            this.dgvOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOwners.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOwners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOwners.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOwners.Location = new System.Drawing.Point(0, 51);
            this.dgvOwners.MultiSelect = false;
            this.dgvOwners.Name = "dgvOwners";
            this.dgvOwners.ReadOnly = true;
            this.dgvOwners.RowHeadersVisible = false;
            this.dgvOwners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOwners.RowTemplate.Height = 25;
            this.dgvOwners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOwners.Size = new System.Drawing.Size(1128, 357);
            this.dgvOwners.TabIndex = 7;
            this.dgvOwners.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOwners_CellDoubleClick);
            this.dgvOwners.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOwners_CellMouseDown);
            this.dgvOwners.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvOwners_MouseClick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvOwners);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1128, 408);
            this.pnlMain.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Liste des propriétaires";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1128, 65);
            this.pnlTop.TabIndex = 16;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(102, 65);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlBottom.Controls.Add(this.lblNbOfOwners);
            this.pnlBottom.Controls.Add(this.btnClear);
            this.pnlBottom.Controls.Add(this.btnSearch);
            this.pnlBottom.Controls.Add(this.txtSearch);
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 473);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1128, 48);
            this.pnlBottom.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(1004, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 48);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemUpdate,
            this.mnuItemDelete});
            this.mnuOptions.Name = "mnuMasterpieces";
            this.mnuOptions.Size = new System.Drawing.Size(130, 48);
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
            // lblNbOfOwners
            // 
            this.lblNbOfOwners.AutoSize = true;
            this.lblNbOfOwners.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNbOfOwners.Location = new System.Drawing.Point(12, 3);
            this.lblNbOfOwners.Name = "lblNbOfOwners";
            this.lblNbOfOwners.Size = new System.Drawing.Size(75, 30);
            this.lblNbOfOwners.TabIndex = 17;
            this.lblNbOfOwners.Text = "Count";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(713, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(27, 25);
            this.btnClear.TabIndex = 16;
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
            this.btnSearch.Location = new System.Drawing.Point(686, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 25);
            this.btnSearch.TabIndex = 15;
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
            this.txtSearch.TabIndex = 14;
            // 
            // FrmAdminOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 521);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminOwners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des propriétaires";
            this.Load += new System.EventHandler(this.FrmAdminOwners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.mnuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvOwners;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ContextMenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNbOfOwners;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}