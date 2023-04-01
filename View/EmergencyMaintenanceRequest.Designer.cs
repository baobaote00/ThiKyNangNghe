
using System.Collections.Generic;
using System.Windows.Forms;
using ThiKyNangNghe.Models;

namespace ThiKyNangNghe.View
{
    partial class EmergencyMaintenanceRequest
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
            this.lblSelectedAsset = new System.Windows.Forms.Label();
            this.lblAssetSN = new System.Windows.Forms.Label();
            this.lblAssetSNValue = new System.Windows.Forms.Label();
            this.lblAssetName = new System.Windows.Forms.Label();
            this.lblAssetNameValue = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDepartmentValue = new System.Windows.Forms.Label();
            this.lblRequestReport = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblDescriptionOfEmergency = new System.Windows.Forms.Label();
            this.lblOtherConsiderations = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtOtherConsiderations = new System.Windows.Forms.TextBox();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectedAsset
            // 
            this.lblSelectedAsset.AutoSize = true;
            this.lblSelectedAsset.Location = new System.Drawing.Point(65, 22);
            this.lblSelectedAsset.Name = "lblSelectedAsset";
            this.lblSelectedAsset.Size = new System.Drawing.Size(78, 13);
            this.lblSelectedAsset.TabIndex = 0;
            this.lblSelectedAsset.Text = "Selected Asset";
            // 
            // lblAssetSN
            // 
            this.lblAssetSN.AutoSize = true;
            this.lblAssetSN.Location = new System.Drawing.Point(68, 73);
            this.lblAssetSN.Name = "lblAssetSN";
            this.lblAssetSN.Size = new System.Drawing.Size(54, 13);
            this.lblAssetSN.TabIndex = 1;
            this.lblAssetSN.Text = "Asset SN:";
            // 
            // lblAssetSNValue
            // 
            this.lblAssetSNValue.AutoSize = true;
            this.lblAssetSNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetSNValue.Location = new System.Drawing.Point(142, 73);
            this.lblAssetSNValue.Name = "lblAssetSNValue";
            this.lblAssetSNValue.Size = new System.Drawing.Size(28, 13);
            this.lblAssetSNValue.TabIndex = 2;
            this.lblAssetSNValue.Text = "abc";
            // 
            // lblAssetName
            // 
            this.lblAssetName.AutoSize = true;
            this.lblAssetName.Location = new System.Drawing.Point(291, 73);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(67, 13);
            this.lblAssetName.TabIndex = 3;
            this.lblAssetName.Text = "Asset Name:";
            // 
            // lblAssetNameValue
            // 
            this.lblAssetNameValue.AutoSize = true;
            this.lblAssetNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetNameValue.Location = new System.Drawing.Point(376, 73);
            this.lblAssetNameValue.Name = "lblAssetNameValue";
            this.lblAssetNameValue.Size = new System.Drawing.Size(28, 13);
            this.lblAssetNameValue.TabIndex = 4;
            this.lblAssetNameValue.Text = "abc";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(682, 73);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department:";
            // 
            // lblDepartmentValue
            // 
            this.lblDepartmentValue.AutoSize = true;
            this.lblDepartmentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentValue.Location = new System.Drawing.Point(753, 73);
            this.lblDepartmentValue.Name = "lblDepartmentValue";
            this.lblDepartmentValue.Size = new System.Drawing.Size(28, 13);
            this.lblDepartmentValue.TabIndex = 6;
            this.lblDepartmentValue.Text = "abc";
            // 
            // lblRequestReport
            // 
            this.lblRequestReport.AutoSize = true;
            this.lblRequestReport.Location = new System.Drawing.Point(68, 150);
            this.lblRequestReport.Name = "lblRequestReport";
            this.lblRequestReport.Size = new System.Drawing.Size(82, 13);
            this.lblRequestReport.TabIndex = 7;
            this.lblRequestReport.Text = "Request Report";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(71, 207);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(41, 13);
            this.lblPriority.TabIndex = 8;
            this.lblPriority.Text = "Priority:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(145, 199);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbPriority.TabIndex = 9;
            // 
            // lblDescriptionOfEmergency
            // 
            this.lblDescriptionOfEmergency.AutoSize = true;
            this.lblDescriptionOfEmergency.Location = new System.Drawing.Point(68, 262);
            this.lblDescriptionOfEmergency.Name = "lblDescriptionOfEmergency";
            this.lblDescriptionOfEmergency.Size = new System.Drawing.Size(131, 13);
            this.lblDescriptionOfEmergency.TabIndex = 10;
            this.lblDescriptionOfEmergency.Text = "Description of Emergency:";
            // 
            // lblOtherConsiderations
            // 
            this.lblOtherConsiderations.AutoSize = true;
            this.lblOtherConsiderations.Location = new System.Drawing.Point(71, 321);
            this.lblOtherConsiderations.Name = "lblOtherConsiderations";
            this.lblOtherConsiderations.Size = new System.Drawing.Size(108, 13);
            this.lblOtherConsiderations.TabIndex = 11;
            this.lblOtherConsiderations.Text = "Other Considerations:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 290);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(614, 20);
            this.txtDescription.TabIndex = 12;
            // 
            // txtOtherConsiderations
            // 
            this.txtOtherConsiderations.Location = new System.Drawing.Point(111, 369);
            this.txtOtherConsiderations.Name = "txtOtherConsiderations";
            this.txtOtherConsiderations.Size = new System.Drawing.Size(614, 20);
            this.txtOtherConsiderations.TabIndex = 13;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.AutoSize = true;
            this.btnSendRequest.Location = new System.Drawing.Point(342, 450);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(125, 35);
            this.btnSendRequest.TabIndex = 14;
            this.btnSendRequest.Text = "SendRequest";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(501, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EmergencyMaintenanceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.AcceptButton = this.btnSendRequest;
            this.ClientSize = new System.Drawing.Size(1022, 518);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.txtOtherConsiderations);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblOtherConsiderations);
            this.Controls.Add(this.lblDescriptionOfEmergency);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblRequestReport);
            this.Controls.Add(this.lblDepartmentValue);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblAssetNameValue);
            this.Controls.Add(this.lblAssetName);
            this.Controls.Add(this.lblAssetSNValue);
            this.Controls.Add(this.lblAssetSN);
            this.Controls.Add(this.lblSelectedAsset);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmergencyMaintenanceRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmeroencyMaintenanceRequest";
            this.Load += new System.EventHandler(this.EmergencyMaintenanceRequest_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSelectedAsset;
        private System.Windows.Forms.Label lblAssetSN;
        private System.Windows.Forms.Label lblAssetSNValue;
        private System.Windows.Forms.Label lblAssetName;
        private System.Windows.Forms.Label lblAssetNameValue;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDepartmentValue;
        private System.Windows.Forms.Label lblRequestReport;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblDescriptionOfEmergency;
        private System.Windows.Forms.Label lblOtherConsiderations;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtOtherConsiderations;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Button btnCancel;
        private BindingSource binding = new BindingSource();
        private List<Priority> priorities;
    }
}