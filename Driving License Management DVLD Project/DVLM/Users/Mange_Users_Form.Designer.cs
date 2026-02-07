namespace DVLM.Users
{
    partial class Mange_Users_Form
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
            this.lblModer = new System.Windows.Forms.Label();
            this.gridvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelUsers = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblNumberOfUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterUsers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchUsers = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.smShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.smAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.smEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.smDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.smChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModer
            // 
            this.lblModer.AutoSize = true;
            this.lblModer.BackColor = System.Drawing.Color.Transparent;
            this.lblModer.Font = new System.Drawing.Font("PoetsenOne", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModer.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblModer.Location = new System.Drawing.Point(472, 9);
            this.lblModer.Name = "lblModer";
            this.lblModer.Size = new System.Drawing.Size(215, 42);
            this.lblModer.TabIndex = 27;
            this.lblModer.Text = "Mange User";
            // 
            // gridvUsers
            // 
            this.gridvUsers.AllowUserToAddRows = false;
            this.gridvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridvUsers.ColumnHeadersHeight = 40;
            this.gridvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridvUsers.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridvUsers.Location = new System.Drawing.Point(12, 284);
            this.gridvUsers.Name = "gridvUsers";
            this.gridvUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridvUsers.RowHeadersVisible = false;
            this.gridvUsers.RowHeadersWidth = 50;
            this.gridvUsers.RowTemplate.Height = 30;
            this.gridvUsers.Size = new System.Drawing.Size(1042, 344);
            this.gridvUsers.TabIndex = 28;
            this.gridvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridvUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.gridvUsers.ThemeStyle.ReadOnly = true;
            this.gridvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridvUsers.ThemeStyle.RowsStyle.Height = 30;
            this.gridvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smShowDetails,
            this.toolStripMenuItem1,
            this.smAddNewUser,
            this.smEditUser,
            this.smDeleteUser,
            this.smChangePassword,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 244);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 6);
            // 
            // panelUsers
            // 
            this.panelUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelUsers.Controls.Add(this.guna2PictureBox3);
            this.panelUsers.Controls.Add(this.lblNumberOfUsers);
            this.panelUsers.Controls.Add(this.label1);
            this.panelUsers.FillColor = System.Drawing.Color.Red;
            this.panelUsers.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelUsers.Location = new System.Drawing.Point(486, 107);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(208, 169);
            this.panelUsers.TabIndex = 29;
            // 
            // lblNumberOfUsers
            // 
            this.lblNumberOfUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfUsers.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUsers.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfUsers.Location = new System.Drawing.Point(3, 136);
            this.lblNumberOfUsers.Name = "lblNumberOfUsers";
            this.lblNumberOfUsers.Size = new System.Drawing.Size(197, 23);
            this.lblNumberOfUsers.TabIndex = 6;
            this.lblNumberOfUsers.Text = "0";
            this.lblNumberOfUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Of Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFilterUsers
            // 
            this.cbFilterUsers.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterUsers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterUsers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterUsers.ItemHeight = 30;
            this.cbFilterUsers.Location = new System.Drawing.Point(342, 65);
            this.cbFilterUsers.Name = "cbFilterUsers";
            this.cbFilterUsers.Size = new System.Drawing.Size(219, 36);
            this.cbFilterUsers.TabIndex = 31;
            this.cbFilterUsers.SelectedIndexChanged += new System.EventHandler(this.cbFilterUsers_SelectedIndexChanged);
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoCompleteCustomSource.AddRange(new string[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbIsActive.ItemHeight = 30;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(580, 65);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(140, 36);
            this.cbIsActive.TabIndex = 33;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(218, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 33);
            this.label6.TabIndex = 44;
            this.label6.Text = "Filter By :";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1019, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 47;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewUser.BorderRadius = 15;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewUser.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Image = global::DVLM.Properties.Resources.add_user;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(70, 70);
            this.btnAddNewUser.Location = new System.Drawing.Point(12, 9);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.PressedColor = System.Drawing.Color.Lime;
            this.btnAddNewUser.Size = new System.Drawing.Size(117, 87);
            this.btnAddNewUser.TabIndex = 32;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // txtSearchUsers
            // 
            this.txtSearchUsers.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchUsers.DefaultText = "";
            this.txtSearchUsers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchUsers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchUsers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchUsers.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUsers.ForeColor = System.Drawing.Color.Black;
            this.txtSearchUsers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchUsers.IconLeft = global::DVLM.Properties.Resources.team33;
            this.txtSearchUsers.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtSearchUsers.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtSearchUsers.Location = new System.Drawing.Point(580, 65);
            this.txtSearchUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchUsers.Name = "txtSearchUsers";
            this.txtSearchUsers.PlaceholderText = "";
            this.txtSearchUsers.SelectedText = "";
            this.txtSearchUsers.Size = new System.Drawing.Size(271, 36);
            this.txtSearchUsers.TabIndex = 30;
            this.txtSearchUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchUsers.TextChanged += new System.EventHandler(this.txtSearchUsers_TextChanged);
            this.txtSearchUsers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchUsers_KeyPress);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::DVLM.Properties.Resources.team33;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(64, 46);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(75, 75);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 8;
            this.guna2PictureBox3.TabStop = false;
            // 
            // smShowDetails
            // 
            this.smShowDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smShowDetails.Image = global::DVLM.Properties.Resources.ShowDetails;
            this.smShowDetails.Name = "smShowDetails";
            this.smShowDetails.Size = new System.Drawing.Size(212, 38);
            this.smShowDetails.Text = "Show Details";
            this.smShowDetails.Click += new System.EventHandler(this.shoToolStripMenuItem_Click);
            // 
            // smAddNewUser
            // 
            this.smAddNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smAddNewUser.Image = global::DVLM.Properties.Resources.add_user;
            this.smAddNewUser.Name = "smAddNewUser";
            this.smAddNewUser.Size = new System.Drawing.Size(212, 38);
            this.smAddNewUser.Text = "Add New User";
            this.smAddNewUser.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // smEditUser
            // 
            this.smEditUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smEditUser.Image = global::DVLM.Properties.Resources.edit;
            this.smEditUser.Name = "smEditUser";
            this.smEditUser.Size = new System.Drawing.Size(212, 38);
            this.smEditUser.Text = "Edit";
            this.smEditUser.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // smDeleteUser
            // 
            this.smDeleteUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smDeleteUser.Image = global::DVLM.Properties.Resources.deletePerson;
            this.smDeleteUser.Name = "smDeleteUser";
            this.smDeleteUser.Size = new System.Drawing.Size(212, 38);
            this.smDeleteUser.Text = "Delete";
            this.smDeleteUser.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // smChangePassword
            // 
            this.smChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smChangePassword.Image = global::DVLM.Properties.Resources.changepassword3;
            this.smChangePassword.Name = "smChangePassword";
            this.smChangePassword.Size = new System.Drawing.Size(212, 38);
            this.smChangePassword.Text = "ChangePassword";
            this.smChangePassword.Click += new System.EventHandler(this.smChangePassword_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailToolStripMenuItem.Image = global::DVLM.Properties.Resources.mail;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // Mange_Users_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 630);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.cbFilterUsers);
            this.Controls.Add(this.txtSearchUsers);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.gridvUsers);
            this.Controls.Add(this.lblModer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mange_Users_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mange_Users_Form";
            this.Load += new System.EventHandler(this.Add_New_User_And_Update_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModer;
        private Guna.UI2.WinForms.Guna2DataGridView gridvUsers;
        private Guna.UI2.WinForms.Guna2GradientPanel panelUsers;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label lblNumberOfUsers;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterUsers;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchUsers;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem smEditUser;
        private System.Windows.Forms.ToolStripMenuItem smChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smDeleteUser;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}