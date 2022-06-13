
namespace Museo
{
    partial class FrmAdminMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMap));
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblHome = new System.Windows.Forms.Label();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFloorZero = new System.Windows.Forms.Button();
            this.btnSecondFloor = new System.Windows.Forms.Button();
            this.btnFirstFloor = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.lblHome, 0, 0);
            this.pnlMain.Controls.Add(this.picMap, 0, 1);
            this.pnlMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 3;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90109F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.9116F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.18731F));
            this.pnlMain.Size = new System.Drawing.Size(991, 600);
            this.pnlMain.TabIndex = 9;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHome.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHome.Location = new System.Drawing.Point(3, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(985, 65);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Plan du Muséo";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMap
            // 
            this.picMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMap.Image = ((System.Drawing.Image)(resources.GetObject("picMap.Image")));
            this.picMap.Location = new System.Drawing.Point(3, 68);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(985, 437);
            this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMap.TabIndex = 2;
            this.picMap.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnFloorZero, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSecondFloor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFirstFloor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 511);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 86);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnFloorZero
            // 
            this.btnFloorZero.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFloorZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFloorZero.FlatAppearance.BorderSize = 0;
            this.btnFloorZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloorZero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFloorZero.Location = new System.Drawing.Point(3, 3);
            this.btnFloorZero.Name = "btnFloorZero";
            this.btnFloorZero.Size = new System.Drawing.Size(322, 37);
            this.btnFloorZero.TabIndex = 5;
            this.btnFloorZero.Text = "RDC";
            this.btnFloorZero.UseVisualStyleBackColor = false;
            this.btnFloorZero.Click += new System.EventHandler(this.btnFloorZero_Click);
            // 
            // btnSecondFloor
            // 
            this.btnSecondFloor.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSecondFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecondFloor.FlatAppearance.BorderSize = 0;
            this.btnSecondFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFloor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSecondFloor.Location = new System.Drawing.Point(659, 3);
            this.btnSecondFloor.Name = "btnSecondFloor";
            this.btnSecondFloor.Size = new System.Drawing.Size(323, 37);
            this.btnSecondFloor.TabIndex = 7;
            this.btnSecondFloor.Text = "2ème étage";
            this.btnSecondFloor.UseVisualStyleBackColor = false;
            this.btnSecondFloor.Click += new System.EventHandler(this.btnSecondFloor_Click);
            // 
            // btnFirstFloor
            // 
            this.btnFirstFloor.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFirstFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirstFloor.FlatAppearance.BorderSize = 0;
            this.btnFirstFloor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstFloor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirstFloor.Location = new System.Drawing.Point(331, 3);
            this.btnFirstFloor.Name = "btnFirstFloor";
            this.btnFirstFloor.Size = new System.Drawing.Size(322, 37);
            this.btnFirstFloor.TabIndex = 6;
            this.btnFirstFloor.Text = "1er étage";
            this.btnFirstFloor.UseVisualStyleBackColor = false;
            this.btnFirstFloor.Click += new System.EventHandler(this.btnFirstFloor_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(331, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(322, 37);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Modifier le nom des salles";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FrmAdminMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 600);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminMap";
            this.Text = "Voir la cartographie";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFloorZero;
        private System.Windows.Forms.Button btnSecondFloor;
        private System.Windows.Forms.Button btnFirstFloor;
        private System.Windows.Forms.Button btnEdit;
    }
}