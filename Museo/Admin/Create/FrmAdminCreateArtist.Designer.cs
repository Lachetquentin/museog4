
namespace Museo
{
    partial class FrmAdminCreateArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminCreateArtist));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtIsni = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblNcda = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.grpAdd.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(286, 123);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(271, 37);
            this.txtURL.TabIndex = 4;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblURL.Location = new System.Drawing.Point(286, 101);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(43, 19);
            this.lblURL.TabIndex = 36;
            this.lblURL.Text = "URL :";
            // 
            // txtIsni
            // 
            this.txtIsni.Location = new System.Drawing.Point(286, 55);
            this.txtIsni.Name = "txtIsni";
            this.txtIsni.Size = new System.Drawing.Size(271, 37);
            this.txtIsni.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Orange;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(284, 258);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(271, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Réinitialiser";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.Location = new System.Drawing.Point(9, 164);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(91, 19);
            this.lblDesc.TabIndex = 23;
            this.lblDesc.Text = "Description :";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(8, 186);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(272, 203);
            this.txtDesc.TabIndex = 5;
            this.txtDesc.UseSystemPasswordChar = true;
            // 
            // lblNcda
            // 
            this.lblNcda.AutoSize = true;
            this.lblNcda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNcda.Location = new System.Drawing.Point(286, 33);
            this.lblNcda.Name = "lblNcda";
            this.lblNcda.Size = new System.Drawing.Size(42, 19);
            this.lblNcda.TabIndex = 21;
            this.lblNcda.Text = "ISNI :";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Crimson;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(286, 315);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(271, 40);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDob.Location = new System.Drawing.Point(5, 101);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(137, 19);
            this.lblDob.TabIndex = 7;
            this.lblDob.Text = "Date de naissance :";
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(286, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(271, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Valider";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 37);
            this.txtName.TabIndex = 0;
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.txtDob);
            this.grpAdd.Controls.Add(this.txtURL);
            this.grpAdd.Controls.Add(this.lblURL);
            this.grpAdd.Controls.Add(this.txtIsni);
            this.grpAdd.Controls.Add(this.btnReset);
            this.grpAdd.Controls.Add(this.lblDesc);
            this.grpAdd.Controls.Add(this.txtDesc);
            this.grpAdd.Controls.Add(this.lblNcda);
            this.grpAdd.Controls.Add(this.btnQuit);
            this.grpAdd.Controls.Add(this.lblDob);
            this.grpAdd.Controls.Add(this.lblName);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtName);
            this.grpAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpAdd.Location = new System.Drawing.Point(0, 46);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(572, 406);
            this.grpAdd.TabIndex = 7;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Ajout";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(9, 123);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(271, 37);
            this.txtDob.TabIndex = 3;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.lblAdmin);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(572, 46);
            this.pnlTop.TabIndex = 6;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.Location = new System.Drawing.Point(212, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(160, 29);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administration";
            // 
            // FrmAdminCreateArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 452);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminCreateArtist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créer un artiste";
            this.Load += new System.EventHandler(this.FrmAdminCreateArtist_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtIsni;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblNcda;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAdmin;
    }
}