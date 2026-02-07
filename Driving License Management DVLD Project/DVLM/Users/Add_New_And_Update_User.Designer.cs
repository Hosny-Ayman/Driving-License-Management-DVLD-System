namespace DVLM.Users
{
    partial class Add_New_And_Update_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_And_Update_User));
            this.lblUserFrom = new System.Windows.Forms.Label();
            this.tabctPerson = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new DVLM.ctrlPersonCardWithFilter();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtconfrimpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHideAndShowConfirmPasswordd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHideAndShowPasswordd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.chkIsActivee = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblUserid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tabctPerson.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserFrom
            // 
            this.lblUserFrom.AutoSize = true;
            this.lblUserFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblUserFrom.Font = new System.Drawing.Font("PoetsenOne", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFrom.ForeColor = System.Drawing.Color.Blue;
            this.lblUserFrom.Location = new System.Drawing.Point(491, 9);
            this.lblUserFrom.Name = "lblUserFrom";
            this.lblUserFrom.Size = new System.Drawing.Size(244, 42);
            this.lblUserFrom.TabIndex = 28;
            this.lblUserFrom.Text = "Add New User";
            this.lblUserFrom.Click += new System.EventHandler(this.lblUserFrom_Click);
            // 
            // tabctPerson
            // 
            this.tabctPerson.Controls.Add(this.tabPage1);
            this.tabctPerson.Controls.Add(this.tabPage2);
            this.tabctPerson.ItemSize = new System.Drawing.Size(180, 40);
            this.tabctPerson.Location = new System.Drawing.Point(12, 54);
            this.tabctPerson.Name = "tabctPerson";
            this.tabctPerson.SelectedIndex = 0;
            this.tabctPerson.Size = new System.Drawing.Size(1235, 654);
            this.tabctPerson.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabctPerson.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabctPerson.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabctPerson.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabctPerson.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabctPerson.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabctPerson.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabctPerson.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabctPerson.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabctPerson.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabctPerson.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabctPerson.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabctPerson.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabctPerson.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabctPerson.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabctPerson.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabctPerson.TabIndex = 29;
            this.tabctPerson.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabctPerson.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tabctPerson.SelectedIndexChanged += new System.EventHandler(this.tabctPerson_SelectedIndexChanged);
            this.tabctPerson.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabctPerson_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1227, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.SearchUserFilter = "";
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1208, 548);
            this.ctrlPersonCardWithFilter1.TabIndex = 21;
            this.ctrlPersonCardWithFilter1.PersonSelect += new System.Action<int>(this.ctrlPersonCardWithFilter1_PersonSelect);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.BorderRadius = 15;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Enabled = false;
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNext.Image = global::DVLM.Properties.Resources.next1;
            this.btnNext.ImageSize = new System.Drawing.Size(120, 120);
            this.btnNext.Location = new System.Drawing.Point(1089, 553);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedColor = System.Drawing.Color.Lime;
            this.btnNext.Size = new System.Drawing.Size(125, 47);
            this.btnNext.TabIndex = 20;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtpassword);
            this.tabPage2.Controls.Add(this.txtconfrimpassword);
            this.tabPage2.Controls.Add(this.txtUsername);
            this.tabPage2.Controls.Add(this.btnHideAndShowConfirmPasswordd);
            this.tabPage2.Controls.Add(this.btnHideAndShowPasswordd);
            this.tabPage2.Controls.Add(this.chkIsActivee);
            this.tabPage2.Controls.Add(this.lblUserid);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.guna2PictureBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1227, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Animated = true;
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtpassword.BorderRadius = 7;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtpassword.IconLeft")));
            this.txtpassword.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtpassword.Location = new System.Drawing.Point(322, 186);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(409, 45);
            this.txtpassword.TabIndex = 62;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtconfrimpassword
            // 
            this.txtconfrimpassword.Animated = true;
            this.txtconfrimpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtconfrimpassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtconfrimpassword.BorderRadius = 7;
            this.txtconfrimpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfrimpassword.DefaultText = "";
            this.txtconfrimpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtconfrimpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtconfrimpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfrimpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconfrimpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfrimpassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfrimpassword.ForeColor = System.Drawing.Color.Black;
            this.txtconfrimpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconfrimpassword.IconLeft = global::DVLM.Properties.Resources.approve;
            this.txtconfrimpassword.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtconfrimpassword.Location = new System.Drawing.Point(322, 264);
            this.txtconfrimpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfrimpassword.Name = "txtconfrimpassword";
            this.txtconfrimpassword.PlaceholderText = "Confrim Password";
            this.txtconfrimpassword.SelectedText = "";
            this.txtconfrimpassword.Size = new System.Drawing.Size(409, 45);
            this.txtconfrimpassword.TabIndex = 61;
            this.txtconfrimpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtconfrimpassword.UseSystemPasswordChar = true;
            this.txtconfrimpassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtconfrimpassword_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderRadius = 7;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsername.IconLeft")));
            this.txtUsername.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtUsername.Location = new System.Drawing.Point(322, 108);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "User Name";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(409, 45);
            this.txtUsername.TabIndex = 60;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHideAndShowConfirmPasswordd
            // 
            this.btnHideAndShowConfirmPasswordd.BackColor = System.Drawing.Color.Transparent;
            this.btnHideAndShowConfirmPasswordd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHideAndShowConfirmPasswordd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHideAndShowConfirmPasswordd.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHideAndShowConfirmPasswordd.Image = ((System.Drawing.Image)(resources.GetObject("btnHideAndShowConfirmPasswordd.Image")));
            this.btnHideAndShowConfirmPasswordd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHideAndShowConfirmPasswordd.ImageRotate = 0F;
            this.btnHideAndShowConfirmPasswordd.Location = new System.Drawing.Point(738, 264);
            this.btnHideAndShowConfirmPasswordd.Name = "btnHideAndShowConfirmPasswordd";
            this.btnHideAndShowConfirmPasswordd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHideAndShowConfirmPasswordd.Size = new System.Drawing.Size(74, 45);
            this.btnHideAndShowConfirmPasswordd.TabIndex = 59;
            this.btnHideAndShowConfirmPasswordd.Click += new System.EventHandler(this.btnHideAndShowConfirmPasswordd_Click);
            // 
            // btnHideAndShowPasswordd
            // 
            this.btnHideAndShowPasswordd.BackColor = System.Drawing.Color.Transparent;
            this.btnHideAndShowPasswordd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHideAndShowPasswordd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHideAndShowPasswordd.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHideAndShowPasswordd.Image = ((System.Drawing.Image)(resources.GetObject("btnHideAndShowPasswordd.Image")));
            this.btnHideAndShowPasswordd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHideAndShowPasswordd.ImageRotate = 0F;
            this.btnHideAndShowPasswordd.Location = new System.Drawing.Point(738, 186);
            this.btnHideAndShowPasswordd.Name = "btnHideAndShowPasswordd";
            this.btnHideAndShowPasswordd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHideAndShowPasswordd.Size = new System.Drawing.Size(74, 45);
            this.btnHideAndShowPasswordd.TabIndex = 58;
            this.btnHideAndShowPasswordd.Click += new System.EventHandler(this.btnHideAndShowPasswordd_Click);
            // 
            // chkIsActivee
            // 
            this.chkIsActivee.AutoSize = true;
            this.chkIsActivee.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActivee.CheckedState.BorderRadius = 0;
            this.chkIsActivee.CheckedState.BorderThickness = 0;
            this.chkIsActivee.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActivee.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActivee.Location = new System.Drawing.Point(482, 316);
            this.chkIsActivee.Name = "chkIsActivee";
            this.chkIsActivee.Size = new System.Drawing.Size(114, 34);
            this.chkIsActivee.TabIndex = 57;
            this.chkIsActivee.Text = "Is Active";
            this.chkIsActivee.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActivee.UncheckedState.BorderRadius = 0;
            this.chkIsActivee.UncheckedState.BorderThickness = 0;
            this.chkIsActivee.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.BackColor = System.Drawing.Color.Transparent;
            this.lblUserid.Font = new System.Drawing.Font("Montserrat SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserid.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUserid.Location = new System.Drawing.Point(553, 61);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(70, 27);
            this.lblUserid.TabIndex = 48;
            this.lblUserid.Text = "[?????]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(389, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 33);
            this.label6.TabIndex = 46;
            this.label6.Text = "User ID :";
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox6.Image = global::DVLM.Properties.Resources.student_card;
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(502, 37);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(36, 64);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox6.TabIndex = 47;
            this.guna2PictureBox6.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.guna2Button2.Location = new System.Drawing.Point(399, 710);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Lime;
            this.guna2Button2.Size = new System.Drawing.Size(125, 47);
            this.guna2Button2.TabIndex = 31;
            this.guna2Button2.Text = "Close";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Image = global::DVLM.Properties.Resources.save2;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(610, 710);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Lime;
            this.guna2Button1.Size = new System.Drawing.Size(125, 47);
            this.guna2Button1.TabIndex = 30;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Add_New_And_Update_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 760);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.tabctPerson);
            this.Controls.Add(this.lblUserFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_New_And_Update_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_And_Update_User";
            this.Load += new System.EventHandler(this.Add_New_And_Update_User_Load);
            this.tabctPerson.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserFrom;
        private Guna.UI2.WinForms.Guna2TabControl tabctPerson;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Label lblUserid;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsActivee;
        private Guna.UI2.WinForms.Guna2ImageButton btnHideAndShowConfirmPasswordd;
        private Guna.UI2.WinForms.Guna2ImageButton btnHideAndShowPasswordd;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2TextBox txtconfrimpassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
    }
}