
namespace Museo
{
    partial class FrmAdminStates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminStates));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvStates = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvStates);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1128, 392);
            this.pnlMain.TabIndex = 17;
            // 
            // dgvStates
            // 
            this.dgvStates.AccessibleName = "";
            this.dgvStates.AllowUserToAddRows = false;
            this.dgvStates.AllowUserToDeleteRows = false;
            this.dgvStates.AllowUserToResizeColumns = false;
            this.dgvStates.AllowUserToResizeRows = false;
            this.dgvStates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStates.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStates.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStates.Location = new System.Drawing.Point(0, 51);
            this.dgvStates.MultiSelect = false;
            this.dgvStates.Name = "dgvStates";
            this.dgvStates.ReadOnly = true;
            this.dgvStates.RowHeadersVisible = false;
            this.dgvStates.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStates.RowTemplate.Height = 25;
            this.dgvStates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStates.Size = new System.Drawing.Size(1128, 341);
            this.dgvStates.TabIndex = 7;
            this.dgvStates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStates_CellDoubleClick);
            this.dgvStates.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStates_CellMouseDown);
            this.dgvStates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvStates_MouseClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
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
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 457);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1128, 64);
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
            this.btnAdd.Size = new System.Drawing.Size(124, 64);
            this.btnAdd.TabIndex = 8;
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
            // FrmAdminStates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 521);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminStates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voir les états des oeuvres";
            this.Load += new System.EventHandler(this.FrmAdminStates_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStates)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.mnuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        internal System.Windows.Forms.DataGridView dgvStates;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelete;
    }
}