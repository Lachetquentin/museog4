
namespace Museo
{
    partial class FrmAdminViewMasterpieceInfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminViewMasterpieceInfos));
            this.btnQuit = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStateResult = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.pnlMemo = new System.Windows.Forms.Panel();
            this.tblMemo = new System.Windows.Forms.TableLayoutPanel();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.tblStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatusResult = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.grpDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMemo.SuspendLayout();
            this.tblMemo.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.tblStatus.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Crimson;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(641, 714);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(101, 40);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.panel1);
            this.grpDetails.Controls.Add(this.pnlMemo);
            this.grpDetails.Controls.Add(this.pnlStatus);
            this.grpDetails.Controls.Add(this.btnQuit);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetails.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDetails.Location = new System.Drawing.Point(0, 46);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(754, 760);
            this.grpDetails.TabIndex = 9;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Détails";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(11, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 61);
            this.panel1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblStateResult, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblState, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblStateResult
            // 
            this.lblStateResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStateResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStateResult.Location = new System.Drawing.Point(3, 30);
            this.lblStateResult.Name = "lblStateResult";
            this.lblStateResult.Size = new System.Drawing.Size(725, 31);
            this.lblStateResult.TabIndex = 3;
            this.lblStateResult.Text = "Lorem Ipsum";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblState.Location = new System.Drawing.Point(3, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(725, 30);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "État de l\'oeuvre :";
            // 
            // pnlMemo
            // 
            this.pnlMemo.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlMemo.Controls.Add(this.tblMemo);
            this.pnlMemo.Location = new System.Drawing.Point(11, 170);
            this.pnlMemo.Name = "pnlMemo";
            this.pnlMemo.Size = new System.Drawing.Size(728, 538);
            this.pnlMemo.TabIndex = 11;
            // 
            // tblMemo
            // 
            this.tblMemo.ColumnCount = 1;
            this.tblMemo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMemo.Controls.Add(this.lblMemo, 0, 0);
            this.tblMemo.Controls.Add(this.txtMemo, 0, 1);
            this.tblMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMemo.Location = new System.Drawing.Point(0, 0);
            this.tblMemo.Name = "tblMemo";
            this.tblMemo.RowCount = 2;
            this.tblMemo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.862745F));
            this.tblMemo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.13725F));
            this.tblMemo.Size = new System.Drawing.Size(728, 538);
            this.tblMemo.TabIndex = 0;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMemo.Location = new System.Drawing.Point(3, 0);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(75, 25);
            this.lblMemo.TabIndex = 1;
            this.lblMemo.Text = "Mémo :";
            // 
            // txtMemo
            // 
            this.txtMemo.BackColor = System.Drawing.Color.SkyBlue;
            this.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMemo.Location = new System.Drawing.Point(3, 39);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ReadOnly = true;
            this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemo.Size = new System.Drawing.Size(722, 496);
            this.txtMemo.TabIndex = 2;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlStatus.Controls.Add(this.tblStatus);
            this.pnlStatus.Location = new System.Drawing.Point(11, 103);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(725, 61);
            this.pnlStatus.TabIndex = 10;
            // 
            // tblStatus
            // 
            this.tblStatus.ColumnCount = 1;
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStatus.Controls.Add(this.lblStatusResult, 0, 1);
            this.tblStatus.Controls.Add(this.lblStatus, 0, 0);
            this.tblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatus.Location = new System.Drawing.Point(0, 0);
            this.tblStatus.Name = "tblStatus";
            this.tblStatus.RowCount = 2;
            this.tblStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatus.Size = new System.Drawing.Size(725, 61);
            this.tblStatus.TabIndex = 0;
            // 
            // lblStatusResult
            // 
            this.lblStatusResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusResult.Location = new System.Drawing.Point(3, 30);
            this.lblStatusResult.Name = "lblStatusResult";
            this.lblStatusResult.Size = new System.Drawing.Size(719, 31);
            this.lblStatusResult.TabIndex = 3;
            this.lblStatusResult.Text = "Lorem Ipsum";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(719, 30);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Statut de l\'oeuvre :";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlTop.Controls.Add(this.lblAdmin);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(754, 46);
            this.pnlTop.TabIndex = 8;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.Location = new System.Drawing.Point(303, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(160, 29);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administration";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAdminViewMasterpieceInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 806);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminViewMasterpieceInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voir les détails d\'une oeuvre";
            this.Load += new System.EventHandler(this.FrmAdminViewMasterpieceInfos_Load);
            this.grpDetails.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlMemo.ResumeLayout(false);
            this.tblMemo.ResumeLayout(false);
            this.tblMemo.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.tblStatus.ResumeLayout(false);
            this.tblStatus.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel pnlMemo;
        private System.Windows.Forms.TableLayoutPanel tblMemo;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.TableLayoutPanel tblStatus;
        private System.Windows.Forms.Label lblStatusResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStateResult;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtMemo;
    }
}