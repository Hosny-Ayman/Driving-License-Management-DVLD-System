namespace DVLM.Local_Driving_License_Applications
{
    partial class Local_Driving_License_Applications_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilterLDLA = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelUsers = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblNumberOfLDLA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridvLDLA = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.lblModer = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnAddNewLDLA = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchLDLA = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmsShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsscheduletest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridvLDLA)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(283, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 33);
            this.label6.TabIndex = 52;
            this.label6.Text = "Filter By :";
            // 
            // cbFilterLDLA
            // 
            this.cbFilterLDLA.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterLDLA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterLDLA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterLDLA.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterLDLA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterLDLA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterLDLA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterLDLA.ItemHeight = 30;
            this.cbFilterLDLA.Location = new System.Drawing.Point(407, 65);
            this.cbFilterLDLA.Name = "cbFilterLDLA";
            this.cbFilterLDLA.Size = new System.Drawing.Size(276, 36);
            this.cbFilterLDLA.TabIndex = 49;
            this.cbFilterLDLA.SelectedIndexChanged += new System.EventHandler(this.cbFilterLDLA_SelectedIndexChanged);
            // 
            // panelUsers
            // 
            this.panelUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelUsers.Controls.Add(this.guna2PictureBox3);
            this.panelUsers.Controls.Add(this.lblNumberOfLDLA);
            this.panelUsers.Controls.Add(this.label1);
            this.panelUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelUsers.FillColor2 = System.Drawing.Color.Green;
            this.panelUsers.Location = new System.Drawing.Point(530, 109);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(208, 169);
            this.panelUsers.TabIndex = 47;
            // 
            // lblNumberOfLDLA
            // 
            this.lblNumberOfLDLA.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfLDLA.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfLDLA.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfLDLA.Location = new System.Drawing.Point(3, 136);
            this.lblNumberOfLDLA.Name = "lblNumberOfLDLA";
            this.lblNumberOfLDLA.Size = new System.Drawing.Size(197, 23);
            this.lblNumberOfLDLA.TabIndex = 6;
            this.lblNumberOfLDLA.Text = "0";
            this.lblNumberOfLDLA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Of LDLA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridvLDLA
            // 
            this.gridvLDLA.AllowUserToAddRows = false;
            this.gridvLDLA.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridvLDLA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridvLDLA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridvLDLA.ColumnHeadersHeight = 40;
            this.gridvLDLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridvLDLA.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridvLDLA.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridvLDLA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridvLDLA.Location = new System.Drawing.Point(12, 296);
            this.gridvLDLA.Name = "gridvLDLA";
            this.gridvLDLA.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridvLDLA.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridvLDLA.RowHeadersVisible = false;
            this.gridvLDLA.RowHeadersWidth = 50;
            this.gridvLDLA.RowTemplate.Height = 30;
            this.gridvLDLA.Size = new System.Drawing.Size(1186, 344);
            this.gridvLDLA.TabIndex = 46;
            this.gridvLDLA.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridvLDLA.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridvLDLA.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridvLDLA.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridvLDLA.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridvLDLA.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridvLDLA.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridvLDLA.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridvLDLA.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridvLDLA.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridvLDLA.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridvLDLA.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridvLDLA.ThemeStyle.HeaderStyle.Height = 40;
            this.gridvLDLA.ThemeStyle.ReadOnly = true;
            this.gridvLDLA.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridvLDLA.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridvLDLA.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridvLDLA.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridvLDLA.ThemeStyle.RowsStyle.Height = 30;
            this.gridvLDLA.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridvLDLA.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridvLDLA.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridvLDLA_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsShowApplicationDetails,
            this.toolStripMenuItem1,
            this.cmsEditApplication,
            this.cmsDeleteApplication,
            this.toolStripMenuItem3,
            this.cmsCancelApplication,
            this.toolStripMenuItem4,
            this.cmsscheduletest,
            this.toolStripMenuItem2,
            this.cmsIssueDrivingLicenseFirstTime,
            this.toolStripMenuItem5,
            this.cmsShowLicense,
            this.toolStripMenuItem6,
            this.showPersonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(369, 366);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(365, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(365, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(365, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(365, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(365, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(365, 6);
            // 
            // lblModer
            // 
            this.lblModer.AutoSize = true;
            this.lblModer.BackColor = System.Drawing.Color.Transparent;
            this.lblModer.Font = new System.Drawing.Font("PoetsenOne", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblModer.Location = new System.Drawing.Point(340, 6);
            this.lblModer.Name = "lblModer";
            this.lblModer.Size = new System.Drawing.Size(576, 42);
            this.lblModer.TabIndex = 45;
            this.lblModer.Text = "Local Driving License Applications";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1162, -3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 53;
            // 
            // btnAddNewLDLA
            // 
            this.btnAddNewLDLA.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewLDLA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewLDLA.BorderRadius = 15;
            this.btnAddNewLDLA.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewLDLA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewLDLA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewLDLA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewLDLA.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewLDLA.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewLDLA.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewLDLA.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddNewLDLA.Image = global::DVLM.Properties.Resources.new_employee;
            this.btnAddNewLDLA.ImageSize = new System.Drawing.Size(70, 70);
            this.btnAddNewLDLA.Location = new System.Drawing.Point(12, 6);
            this.btnAddNewLDLA.Name = "btnAddNewLDLA";
            this.btnAddNewLDLA.PressedColor = System.Drawing.Color.Lime;
            this.btnAddNewLDLA.Size = new System.Drawing.Size(117, 87);
            this.btnAddNewLDLA.TabIndex = 50;
            this.btnAddNewLDLA.Click += new System.EventHandler(this.btnAddNewLDLA_Click);
            // 
            // txtSearchLDLA
            // 
            this.txtSearchLDLA.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchLDLA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchLDLA.DefaultText = "";
            this.txtSearchLDLA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchLDLA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchLDLA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchLDLA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchLDLA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchLDLA.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLDLA.ForeColor = System.Drawing.Color.Black;
            this.txtSearchLDLA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchLDLA.IconLeft = global::DVLM.Properties.Resources.driving_license;
            this.txtSearchLDLA.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtSearchLDLA.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtSearchLDLA.Location = new System.Drawing.Point(690, 65);
            this.txtSearchLDLA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchLDLA.Name = "txtSearchLDLA";
            this.txtSearchLDLA.PlaceholderText = "";
            this.txtSearchLDLA.SelectedText = "";
            this.txtSearchLDLA.Size = new System.Drawing.Size(271, 36);
            this.txtSearchLDLA.TabIndex = 48;
            this.txtSearchLDLA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchLDLA.TextChanged += new System.EventHandler(this.txtSearchLDLA_TextChanged);
            this.txtSearchLDLA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchLDLA_KeyPress);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::DVLM.Properties.Resources.driving_license;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(64, 46);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(75, 75);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 8;
            this.guna2PictureBox3.TabStop = false;
            // 
            // cmsShowApplicationDetails
            // 
            this.cmsShowApplicationDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsShowApplicationDetails.Image = global::DVLM.Properties.Resources.ShowDetails;
            this.cmsShowApplicationDetails.Name = "cmsShowApplicationDetails";
            this.cmsShowApplicationDetails.Size = new System.Drawing.Size(368, 38);
            this.cmsShowApplicationDetails.Text = "Show Application Details";
            this.cmsShowApplicationDetails.Click += new System.EventHandler(this.cmsShowApplicationDetails_Click);
            // 
            // cmsEditApplication
            // 
            this.cmsEditApplication.Enabled = false;
            this.cmsEditApplication.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsEditApplication.Image = global::DVLM.Properties.Resources.edit;
            this.cmsEditApplication.Name = "cmsEditApplication";
            this.cmsEditApplication.Size = new System.Drawing.Size(368, 38);
            this.cmsEditApplication.Text = "Edit Application";
            this.cmsEditApplication.Click += new System.EventHandler(this.cmsEditApplication_Click);
            // 
            // cmsDeleteApplication
            // 
            this.cmsDeleteApplication.Enabled = false;
            this.cmsDeleteApplication.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsDeleteApplication.Image = global::DVLM.Properties.Resources.delete77;
            this.cmsDeleteApplication.Name = "cmsDeleteApplication";
            this.cmsDeleteApplication.Size = new System.Drawing.Size(368, 38);
            this.cmsDeleteApplication.Text = "Delete Application";
            this.cmsDeleteApplication.Click += new System.EventHandler(this.cmsDeleteApplication_Click);
            // 
            // cmsCancelApplication
            // 
            this.cmsCancelApplication.Enabled = false;
            this.cmsCancelApplication.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsCancelApplication.Image = global::DVLM.Properties.Resources.cancel_order;
            this.cmsCancelApplication.Name = "cmsCancelApplication";
            this.cmsCancelApplication.Size = new System.Drawing.Size(368, 38);
            this.cmsCancelApplication.Text = "Cancel Application";
            this.cmsCancelApplication.Click += new System.EventHandler(this.cmsCancelApplication_Click);
            // 
            // cmsscheduletest
            // 
            this.cmsscheduletest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmScheduleVisionTest,
            this.tsmScheduleWrittenTest,
            this.tsmScheduleStreetTest});
            this.cmsscheduletest.Enabled = false;
            this.cmsscheduletest.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsscheduletest.Image = global::DVLM.Properties.Resources.schedule_test1;
            this.cmsscheduletest.Name = "cmsscheduletest";
            this.cmsscheduletest.Size = new System.Drawing.Size(368, 38);
            this.cmsscheduletest.Text = "Schedule test";
            // 
            // tsmScheduleVisionTest
            // 
            this.tsmScheduleVisionTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmScheduleVisionTest.Image = global::DVLM.Properties.Resources.eye_scan;
            this.tsmScheduleVisionTest.Name = "tsmScheduleVisionTest";
            this.tsmScheduleVisionTest.Size = new System.Drawing.Size(231, 26);
            this.tsmScheduleVisionTest.Text = "Schedule Vision Test";
            this.tsmScheduleVisionTest.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // tsmScheduleWrittenTest
            // 
            this.tsmScheduleWrittenTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmScheduleWrittenTest.Image = global::DVLM.Properties.Resources.notes;
            this.tsmScheduleWrittenTest.Name = "tsmScheduleWrittenTest";
            this.tsmScheduleWrittenTest.Size = new System.Drawing.Size(231, 26);
            this.tsmScheduleWrittenTest.Text = "Schedule Written Test";
            this.tsmScheduleWrittenTest.Click += new System.EventHandler(this.tsmScheduleWrittenTest_Click);
            // 
            // tsmScheduleStreetTest
            // 
            this.tsmScheduleStreetTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmScheduleStreetTest.Image = global::DVLM.Properties.Resources.driving_test;
            this.tsmScheduleStreetTest.Name = "tsmScheduleStreetTest";
            this.tsmScheduleStreetTest.Size = new System.Drawing.Size(231, 26);
            this.tsmScheduleStreetTest.Text = "Schedule Street Test";
            this.tsmScheduleStreetTest.Click += new System.EventHandler(this.tsmScheduleStreetTest_Click);
            // 
            // cmsIssueDrivingLicenseFirstTime
            // 
            this.cmsIssueDrivingLicenseFirstTime.Enabled = false;
            this.cmsIssueDrivingLicenseFirstTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsIssueDrivingLicenseFirstTime.Image = global::DVLM.Properties.Resources.drivers_license;
            this.cmsIssueDrivingLicenseFirstTime.Name = "cmsIssueDrivingLicenseFirstTime";
            this.cmsIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(368, 38);
            this.cmsIssueDrivingLicenseFirstTime.Text = "Issue Driving License (First Time)";
            this.cmsIssueDrivingLicenseFirstTime.Click += new System.EventHandler(this.cmsIssueDrivingLicenseFirstTime_Click);
            // 
            // cmsShowLicense
            // 
            this.cmsShowLicense.Enabled = false;
            this.cmsShowLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsShowLicense.Image = global::DVLM.Properties.Resources.driving_license17;
            this.cmsShowLicense.Name = "cmsShowLicense";
            this.cmsShowLicense.Size = new System.Drawing.Size(368, 38);
            this.cmsShowLicense.Text = "Show License";
            this.cmsShowLicense.Click += new System.EventHandler(this.cmsShowLicense_Click);
            // 
            // showPersonToolStripMenuItem
            // 
            this.showPersonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPersonToolStripMenuItem.Image = global::DVLM.Properties.Resources.history_book;
            this.showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            this.showPersonToolStripMenuItem.Size = new System.Drawing.Size(368, 38);
            this.showPersonToolStripMenuItem.Text = "Show Person License History";
            this.showPersonToolStripMenuItem.Click += new System.EventHandler(this.showPersonToolStripMenuItem_Click);
            // 
            // Local_Driving_License_Applications_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 637);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddNewLDLA);
            this.Controls.Add(this.cbFilterLDLA);
            this.Controls.Add(this.txtSearchLDLA);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.gridvLDLA);
            this.Controls.Add(this.lblModer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Local_Driving_License_Applications_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local_Driving_License_Applications_Form";
            this.Load += new System.EventHandler(this.Local_Driving_License_Applications_Form_Load);
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridvLDLA)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnAddNewLDLA;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterLDLA;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchLDLA;
        private Guna.UI2.WinForms.Guna2GradientPanel panelUsers;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label lblNumberOfLDLA;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView gridvLDLA;
        private System.Windows.Forms.Label lblModer;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsShowApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsEditApplication;
        private System.Windows.Forms.ToolStripMenuItem cmsCancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cmsDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem cmsscheduletest;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmsIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cmsShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem showPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleStreetTest;
    }
}