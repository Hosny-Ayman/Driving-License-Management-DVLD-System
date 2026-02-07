namespace DVLM.Renew
{
    partial class Replacement_For_Lost_or_Damaged_License_Form
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.lblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNationalNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIssueReplacement = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSearchNationalNo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ctrlApplicationInfoForLicenseReplacement1 = new DVLM.ctrlApplicationInfoForLicenseReplacement();
            this.ctrlLicenseCardWithFilter1 = new DVLM.ctrlLicenseCardWithFilter();
            this.cbAllApplicationsType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbReplacementFor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Black;
            this.lblHeader.Font = new System.Drawing.Font("PoetsenOne", 18.75F);
            this.lblHeader.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblHeader.Location = new System.Drawing.Point(435, 78);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(498, 30);
            this.lblHeader.TabIndex = 102;
            this.lblHeader.Text = "Replacement For Lost or Damaged License";
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.BackColor = System.Drawing.Color.Transparent;
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Enabled = false;
            this.gbReplacementFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReplacementFor.Location = new System.Drawing.Point(1054, 69);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(344, 86);
            this.gbReplacementFor.TabIndex = 104;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLostLicense.Location = new System.Drawing.Point(70, 58);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(133, 28);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamagedLicense.Location = new System.Drawing.Point(70, 25);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(181, 28);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // lblShowLicenseInfo
            // 
            this.lblShowLicenseInfo.AutoSize = true;
            this.lblShowLicenseInfo.Enabled = false;
            this.lblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicenseInfo.Location = new System.Drawing.Point(349, 823);
            this.lblShowLicenseInfo.Name = "lblShowLicenseInfo";
            this.lblShowLicenseInfo.Size = new System.Drawing.Size(187, 25);
            this.lblShowLicenseInfo.TabIndex = 109;
            this.lblShowLicenseInfo.TabStop = true;
            this.lblShowLicenseInfo.Text = "Show License Info";
            this.lblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseInfo_LinkClicked);
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.AutoSize = true;
            this.lblShowLicenseHistory.Enabled = false;
            this.lblShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(74, 823);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(219, 25);
            this.lblShowLicenseHistory.TabIndex = 108;
            this.lblShowLicenseHistory.TabStop = true;
            this.lblShowLicenseHistory.Text = "Show License History";
            this.lblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1353, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(311, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 38);
            this.label3.TabIndex = 112;
            this.label3.Text = "National No:";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalNo.DefaultText = "";
            this.txtNationalNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationalNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationalNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalNo.ForeColor = System.Drawing.Color.Black;
            this.txtNationalNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalNo.IconLeft = global::DVLM.Properties.Resources.id_card2;
            this.txtNationalNo.IconLeftSize = new System.Drawing.Size(45, 45);
            this.txtNationalNo.IconRightSize = new System.Drawing.Size(40, 40);
            this.txtNationalNo.Location = new System.Drawing.Point(489, 16);
            this.txtNationalNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNationalNo.PlaceholderText = "National No";
            this.txtNationalNo.SelectedText = "";
            this.txtNationalNo.Size = new System.Drawing.Size(236, 45);
            this.txtNationalNo.TabIndex = 113;
            this.txtNationalNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.BackColor = System.Drawing.Color.Transparent;
            this.btnIssueReplacement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIssueReplacement.BorderRadius = 15;
            this.btnIssueReplacement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssueReplacement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssueReplacement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssueReplacement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssueReplacement.Enabled = false;
            this.btnIssueReplacement.FillColor = System.Drawing.Color.Transparent;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnIssueReplacement.ForeColor = System.Drawing.Color.Black;
            this.btnIssueReplacement.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnIssueReplacement.Image = global::DVLM.Properties.Resources.RenewLicense;
            this.btnIssueReplacement.ImageSize = new System.Drawing.Size(40, 40);
            this.btnIssueReplacement.Location = new System.Drawing.Point(1086, 823);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.PressedColor = System.Drawing.Color.Lime;
            this.btnIssueReplacement.Size = new System.Drawing.Size(262, 38);
            this.btnIssueReplacement.TabIndex = 107;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Image = global::DVLM.Properties.Resources.close;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(904, 823);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Lime;
            this.guna2Button2.Size = new System.Drawing.Size(108, 38);
            this.guna2Button2.TabIndex = 106;
            this.guna2Button2.Text = "Close";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::DVLM.Properties.Resources.Replacement_License2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(6, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(306, 153);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 103;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnSearchNationalNo
            // 
            this.btnSearchNationalNo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearchNationalNo.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearchNationalNo.Image = global::DVLM.Properties.Resources.search;
            this.btnSearchNationalNo.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearchNationalNo.ImageRotate = 0F;
            this.btnSearchNationalNo.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSearchNationalNo.Location = new System.Drawing.Point(1009, 12);
            this.btnSearchNationalNo.Name = "btnSearchNationalNo";
            this.btnSearchNationalNo.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearchNationalNo.Size = new System.Drawing.Size(56, 51);
            this.btnSearchNationalNo.TabIndex = 114;
            this.btnSearchNationalNo.Click += new System.EventHandler(this.btnSearchNationalNo_Click);
            // 
            // ctrlApplicationInfoForLicenseReplacement1
            // 
            this.ctrlApplicationInfoForLicenseReplacement1.Enabled = false;
            this.ctrlApplicationInfoForLicenseReplacement1.Location = new System.Drawing.Point(79, 631);
            this.ctrlApplicationInfoForLicenseReplacement1.Name = "ctrlApplicationInfoForLicenseReplacement1";
            this.ctrlApplicationInfoForLicenseReplacement1.OldLicense = null;
            this.ctrlApplicationInfoForLicenseReplacement1.PersonID = 0;
            this.ctrlApplicationInfoForLicenseReplacement1.Size = new System.Drawing.Size(1269, 189);
            this.ctrlApplicationInfoForLicenseReplacement1.TabIndex = 105;
            // 
            // ctrlLicenseCardWithFilter1
            // 
            this.ctrlLicenseCardWithFilter1.DriverID = 0;
            this.ctrlLicenseCardWithFilter1.Enabled = false;
            this.ctrlLicenseCardWithFilter1.IsActive = false;
            this.ctrlLicenseCardWithFilter1.IsExpired = false;
            this.ctrlLicenseCardWithFilter1.LicenseID = 0;
            this.ctrlLicenseCardWithFilter1.Location = new System.Drawing.Point(2, 69);
            this.ctrlLicenseCardWithFilter1.Name = "ctrlLicenseCardWithFilter1";
            this.ctrlLicenseCardWithFilter1.PersonID = 0;
            this.ctrlLicenseCardWithFilter1.Size = new System.Drawing.Size(1400, 571);
            this.ctrlLicenseCardWithFilter1.stringSearchFilter = "";
            this.ctrlLicenseCardWithFilter1.TabIndex = 0;
            this.ctrlLicenseCardWithFilter1.LocalLicenseID += new System.Action<int>(this.ctrlLicenseCardWithFilter1_LocalLicenseID);
            // 
            // cbAllApplicationsType
            // 
            this.cbAllApplicationsType.AutoRoundedCorners = true;
            this.cbAllApplicationsType.BackColor = System.Drawing.Color.Transparent;
            this.cbAllApplicationsType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAllApplicationsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllApplicationsType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAllApplicationsType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAllApplicationsType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbAllApplicationsType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAllApplicationsType.ItemHeight = 30;
            this.cbAllApplicationsType.Location = new System.Drawing.Point(732, 21);
            this.cbAllApplicationsType.Name = "cbAllApplicationsType";
            this.cbAllApplicationsType.Size = new System.Drawing.Size(271, 36);
            this.cbAllApplicationsType.TabIndex = 115;
            // 
            // Replacement_For_Lost_or_Damaged_License_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 865);
            this.Controls.Add(this.cbAllApplicationsType);
            this.Controls.Add(this.btnSearchNationalNo);
            this.Controls.Add(this.txtNationalNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblShowLicenseInfo);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.ctrlApplicationInfoForLicenseReplacement1);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.ctrlLicenseCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Replacement_For_Lost_or_Damaged_License_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacement_For_Lost_or_Damaged_License_Form";
            this.Load += new System.EventHandler(this.Replacement_For_Lost_or_Damaged_License_Form_Load);
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLicenseCardWithFilter ctrlLicenseCardWithFilter1;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private ctrlApplicationInfoForLicenseReplacement ctrlApplicationInfoForLicenseReplacement1;
        private System.Windows.Forms.LinkLabel lblShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lblShowLicenseHistory;
        private Guna.UI2.WinForms.Guna2Button btnIssueReplacement;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalNo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearchNationalNo;
        private Guna.UI2.WinForms.Guna2ComboBox cbAllApplicationsType;
    }
}