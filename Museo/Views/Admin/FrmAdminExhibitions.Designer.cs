
namespace Museo
{
    partial class FrmAdminExhibitions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminExhibitions));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblNbOfExhibitions = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvExhibitions = new System.Windows.Forms.DataGridView();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExhibitions)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Controls.Add(this.lblNbOfExhibitions);
            this.pnlBottom.Controls.Add(this.picLogo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 517);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(991, 83);
            this.pnlBottom.TabIndex = 9;
            // 
            // lblNbOfExhibitions
            // 
            this.lblNbOfExhibitions.AutoSize = true;
            this.lblNbOfExhibitions.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNbOfExhibitions.Location = new System.Drawing.Point(12, 11);
            this.lblNbOfExhibitions.Name = "lblNbOfExhibitions";
            this.lblNbOfExhibitions.Size = new System.Drawing.Size(75, 30);
            this.lblNbOfExhibitions.TabIndex = 2;
            this.lblNbOfExhibitions.Text = "Count";
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
            // dgvExhibitions
            // 
            this.dgvExhibitions.AccessibleName = "";
            this.dgvExhibitions.AllowUserToAddRows = false;
            this.dgvExhibitions.AllowUserToDeleteRows = false;
            this.dgvExhibitions.AllowUserToResizeColumns = false;
            this.dgvExhibitions.AllowUserToResizeRows = false;
            this.dgvExhibitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExhibitions.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExhibitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExhibitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExhibitions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExhibitions.Location = new System.Drawing.Point(0, 0);
            this.dgvExhibitions.MultiSelect = false;
            this.dgvExhibitions.Name = "dgvExhibitions";
            this.dgvExhibitions.ReadOnly = true;
            this.dgvExhibitions.RowHeadersVisible = false;
            this.dgvExhibitions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvExhibitions.RowTemplate.Height = 25;
            this.dgvExhibitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExhibitions.Size = new System.Drawing.Size(991, 600);
            this.dgvExhibitions.TabIndex = 10;
            this.dgvExhibitions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExhibitions_CellDoubleClick);
            this.dgvExhibitions.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExhibitions_CellMouseDown);
            this.dgvExhibitions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvExhibitions_MouseClick);
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
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmAdminExhibitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.dgvExhibitions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminExhibitions";
            this.Text = "Voir les expositions";
            this.Load += new System.EventHandler(this.FrmAdminExhibitions_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExhibitions)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblNbOfExhibitions;
        private System.Windows.Forms.PictureBox picLogo;
        internal System.Windows.Forms.DataGridView dgvExhibitions;
        private System.Windows.Forms.ContextMenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemView;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}