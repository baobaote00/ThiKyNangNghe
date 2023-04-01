
using System.Collections.Generic;
using System.Windows.Forms;
using ThiKyNangNghe.Models;

namespace ThiKyNangNghe.View
{
    partial class EmergencyMaintenanceRequestDetails
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
            this.lblDepartmentValue = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblAssetNameValue = new System.Windows.Forms.Label();
            this.lblAssetName = new System.Windows.Forms.Label();
            this.lblAssetSNValue = new System.Windows.Forms.Label();
            this.lblAssetSN = new System.Windows.Forms.Label();
            this.lblSelectedAsset = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAssetEMReport = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCompletedOn = new System.Windows.Forms.Label();
            this.lblTechnicianNote = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCompletedDate = new System.Windows.Forms.DateTimePicker();
            this.txtTechnicianNote = new System.Windows.Forms.TextBox();
            this.lblReplacementParts = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbPartName = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.dgvPart = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartmentValue
            // 
            this.lblDepartmentValue.AutoSize = true;
            this.lblDepartmentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentValue.Location = new System.Drawing.Point(727, 68);
            this.lblDepartmentValue.Name = "lblDepartmentValue";
            this.lblDepartmentValue.Size = new System.Drawing.Size(28, 13);
            this.lblDepartmentValue.TabIndex = 13;
            this.lblDepartmentValue.Text = "abc";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(656, 68);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 12;
            this.lblDepartment.Text = "Department:";
            // 
            // lblAssetNameValue
            // 
            this.lblAssetNameValue.AutoSize = true;
            this.lblAssetNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetNameValue.Location = new System.Drawing.Point(350, 68);
            this.lblAssetNameValue.Name = "lblAssetNameValue";
            this.lblAssetNameValue.Size = new System.Drawing.Size(28, 13);
            this.lblAssetNameValue.TabIndex = 11;
            this.lblAssetNameValue.Text = "abc";
            // 
            // lblAssetName
            // 
            this.lblAssetName.AutoSize = true;
            this.lblAssetName.Location = new System.Drawing.Point(265, 68);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(67, 13);
            this.lblAssetName.TabIndex = 10;
            this.lblAssetName.Text = "Asset Name:";
            // 
            // lblAssetSNValue
            // 
            this.lblAssetSNValue.AutoSize = true;
            this.lblAssetSNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetSNValue.Location = new System.Drawing.Point(116, 68);
            this.lblAssetSNValue.Name = "lblAssetSNValue";
            this.lblAssetSNValue.Size = new System.Drawing.Size(28, 13);
            this.lblAssetSNValue.TabIndex = 9;
            this.lblAssetSNValue.Text = "abc";
            // 
            // lblAssetSN
            // 
            this.lblAssetSN.AutoSize = true;
            this.lblAssetSN.Location = new System.Drawing.Point(42, 68);
            this.lblAssetSN.Name = "lblAssetSN";
            this.lblAssetSN.Size = new System.Drawing.Size(54, 13);
            this.lblAssetSN.TabIndex = 8;
            this.lblAssetSN.Text = "Asset SN:";
            // 
            // lblSelectedAsset
            // 
            this.lblSelectedAsset.AutoSize = true;
            this.lblSelectedAsset.Location = new System.Drawing.Point(42, 25);
            this.lblSelectedAsset.Name = "lblSelectedAsset";
            this.lblSelectedAsset.Size = new System.Drawing.Size(78, 13);
            this.lblSelectedAsset.TabIndex = 7;
            this.lblSelectedAsset.Text = "Selected Asset";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(527, 541);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Location = new System.Drawing.Point(368, 541);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 35);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAssetEMReport
            // 
            this.lblAssetEMReport.AutoSize = true;
            this.lblAssetEMReport.Location = new System.Drawing.Point(42, 137);
            this.lblAssetEMReport.Name = "lblAssetEMReport";
            this.lblAssetEMReport.Size = new System.Drawing.Size(87, 13);
            this.lblAssetEMReport.TabIndex = 18;
            this.lblAssetEMReport.Text = "Asset EM Report";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(42, 183);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 19;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblCompletedOn
            // 
            this.lblCompletedOn.AutoSize = true;
            this.lblCompletedOn.Location = new System.Drawing.Point(398, 183);
            this.lblCompletedOn.Name = "lblCompletedOn";
            this.lblCompletedOn.Size = new System.Drawing.Size(77, 13);
            this.lblCompletedOn.TabIndex = 20;
            this.lblCompletedOn.Text = "Completed On:";
            // 
            // lblTechnicianNote
            // 
            this.lblTechnicianNote.AutoSize = true;
            this.lblTechnicianNote.Location = new System.Drawing.Point(42, 228);
            this.lblTechnicianNote.Name = "lblTechnicianNote";
            this.lblTechnicianNote.Size = new System.Drawing.Size(84, 13);
            this.lblTechnicianNote.TabIndex = 21;
            this.lblTechnicianNote.Text = "Technician note";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(119, 177);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 23;
            this.dtpStartDate.Value = dtpStartDate.MinDate;
            // 
            // dtpCompletedDate
            // 
            this.dtpCompletedDate.Location = new System.Drawing.Point(492, 177);
            this.dtpCompletedDate.Name = "dtpCompletedDate";
            this.dtpCompletedDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCompletedDate.TabIndex = 24;
            this.dtpCompletedDate.Value = dtpCompletedDate.MinDate;
            // 
            // txtTechnicianNote
            // 
            this.txtTechnicianNote.Location = new System.Drawing.Point(119, 255);
            this.txtTechnicianNote.Multiline = true;
            this.txtTechnicianNote.Name = "txtTechnicianNote";
            this.txtTechnicianNote.Size = new System.Drawing.Size(636, 38);
            this.txtTechnicianNote.TabIndex = 25;
            // 
            // lblReplacementParts
            // 
            this.lblReplacementParts.AutoSize = true;
            this.lblReplacementParts.Location = new System.Drawing.Point(42, 313);
            this.lblReplacementParts.Name = "lblReplacementParts";
            this.lblReplacementParts.Size = new System.Drawing.Size(97, 13);
            this.lblReplacementParts.TabIndex = 26;
            this.lblReplacementParts.Text = "Replacement Parts";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(42, 360);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(60, 13);
            this.lblPartName.TabIndex = 27;
            this.lblPartName.Text = "Part Name:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(286, 360);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 28;
            this.lblAmount.Text = "Amount:";
            // 
            // cmbPartName
            // 
            this.cmbPartName.FormattingEnabled = true;
            this.cmbPartName.Location = new System.Drawing.Point(119, 352);
            this.cmbPartName.Name = "cmbPartName";
            this.cmbPartName.Size = new System.Drawing.Size(121, 21);
            this.cmbPartName.TabIndex = 29;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(368, 353);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 30;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(617, 351);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddToList.TabIndex = 31;
            this.btnAddToList.Text = "Add to list";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // dgvPart
            // 
            this.dgvPart.AllowUserToAddRows = false;
            this.dgvPart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPart.Location = new System.Drawing.Point(45, 409);
            this.dgvPart.Name = "dgvPart";
            this.dgvPart.ReadOnly = true;
            this.dgvPart.RowHeadersVisible = false;
            this.dgvPart.Size = new System.Drawing.Size(932, 107);
            this.dgvPart.TabIndex = 32;
            this.dgvPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPart_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.HeaderText = "Action";
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ReadOnly = true;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseColumnTextForButtonValue = true;
            // 
            // EmergencyMaintenanceRequestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 587);
            this.Controls.Add(this.dgvPart);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cmbPartName);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblReplacementParts);
            this.Controls.Add(this.txtTechnicianNote);
            this.Controls.Add(this.dtpCompletedDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblTechnicianNote);
            this.Controls.Add(this.lblCompletedOn);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblAssetEMReport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDepartmentValue);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblAssetNameValue);
            this.Controls.Add(this.lblAssetName);
            this.Controls.Add(this.lblAssetSNValue);
            this.Controls.Add(this.lblAssetSN);
            this.Controls.Add(this.lblSelectedAsset);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmergencyMaintenanceRequestDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmergencyMaintenanceRequestDetails";
            this.Load += new System.EventHandler(this.EmergencyMaintenanceRequestDetails_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentValue;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblAssetNameValue;
        private System.Windows.Forms.Label lblAssetName;
        private System.Windows.Forms.Label lblAssetSNValue;
        private System.Windows.Forms.Label lblAssetSN;
        private System.Windows.Forms.Label lblSelectedAsset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAssetEMReport;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCompletedOn;
        private System.Windows.Forms.Label lblTechnicianNote;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpCompletedDate;
        private System.Windows.Forms.TextBox txtTechnicianNote;
        private System.Windows.Forms.Label lblReplacementParts;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbPartName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.DataGridView dgvPart;
        private List<Part> dataPartDGV = new List<Part>();
        private List<Part> dataPartCMB = new List<Part>();
        private DataGridViewButtonColumn btnRemove;
    }
}