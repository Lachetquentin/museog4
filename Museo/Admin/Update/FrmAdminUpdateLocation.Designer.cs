
namespace Museo
{
    partial class FrmAdminUpdateLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminUpdateLocation));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.grpUpdate.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Orange;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(7, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(271, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Réinitialiser";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Crimson;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(9, 225);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(271, 40);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 19);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nom :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(9, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(271, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Valider";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 37);
            this.txtName.TabIndex = 1;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnReset);
            this.grpUpdate.Controls.Add(this.btnQuit);
            this.grpUpdate.Controls.Add(this.lblName);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.txtName);
            this.grpUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUpdate.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpUpdate.Location = new System.Drawing.Point(0, 46);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(300, 284);
            this.grpUpdate.TabIndex = 9;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Modification";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.lblAdmin);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(300, 46);
            this.pnlTop.TabIndex = 8;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.Location = new System.Drawing.Point(76, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(160, 29);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administration";
            // 
            // FrmAdminUpdateLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 330);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminUpdateLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'un emplacement";
            this.Load += new System.EventHandler(this.FrmAdminUpdateLocation_Load);
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAdmin;
    }
}