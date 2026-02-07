namespace DVLM.Login
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.cbRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnshowHidePass = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtLoginPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLoginUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.cbRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRememberMe.CheckedState.BorderRadius = 0;
            this.cbRememberMe.CheckedState.BorderThickness = 0;
            this.cbRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRememberMe.ForeColor = System.Drawing.Color.Green;
            this.cbRememberMe.Location = new System.Drawing.Point(517, 279);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(167, 28);
            this.cbRememberMe.TabIndex = 33;
            this.cbRememberMe.Text = "Rememeber Me";
            this.cbRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbRememberMe.UncheckedState.BorderRadius = 0;
            this.cbRememberMe.UncheckedState.BorderThickness = 0;
            this.cbRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbRememberMe.UseVisualStyleBackColor = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::DVLM.Properties.Resources.Login_Card2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(370, 548);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 32;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnshowHidePass
            // 
            this.btnshowHidePass.BackColor = System.Drawing.Color.Transparent;
            this.btnshowHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnshowHidePass.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnshowHidePass.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnshowHidePass.Image = ((System.Drawing.Image)(resources.GetObject("btnshowHidePass.Image")));
            this.btnshowHidePass.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnshowHidePass.ImageRotate = 0F;
            this.btnshowHidePass.Location = new System.Drawing.Point(794, 227);
            this.btnshowHidePass.Name = "btnshowHidePass";
            this.btnshowHidePass.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnshowHidePass.Size = new System.Drawing.Size(74, 45);
            this.btnshowHidePass.TabIndex = 30;
            this.btnshowHidePass.Click += new System.EventHandler(this.btnshowHidePass_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Animated = true;
            this.txtLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtLoginPassword.BorderRadius = 7;
            this.txtLoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginPassword.DefaultText = "";
            this.txtLoginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.Black;
            this.txtLoginPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtLoginPassword.IconLeft")));
            this.txtLoginPassword.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtLoginPassword.Location = new System.Drawing.Point(378, 227);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PlaceholderText = "Password";
            this.txtLoginPassword.SelectedText = "";
            this.txtLoginPassword.Size = new System.Drawing.Size(409, 45);
            this.txtLoginPassword.TabIndex = 29;
            this.txtLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Animated = true;
            this.txtLoginUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginUserName.BorderColor = System.Drawing.Color.Transparent;
            this.txtLoginUserName.BorderRadius = 7;
            this.txtLoginUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginUserName.DefaultText = "";
            this.txtLoginUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUserName.ForeColor = System.Drawing.Color.Black;
            this.txtLoginUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginUserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtLoginUserName.IconLeft")));
            this.txtLoginUserName.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtLoginUserName.Location = new System.Drawing.Point(378, 165);
            this.txtLoginUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.PlaceholderText = "User Name";
            this.txtLoginUserName.SelectedText = "";
            this.txtLoginUserName.Size = new System.Drawing.Size(409, 45);
            this.txtLoginUserName.TabIndex = 28;
            this.txtLoginUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogin.Location = new System.Drawing.Point(474, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.Lime;
            this.btnLogin.Size = new System.Drawing.Size(210, 65);
            this.btnLogin.TabIndex = 27;
            this.btnLogin.Text = "Log in";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(935, 548);
            this.Controls.Add(this.cbRememberMe);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnshowHidePass);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnshowHidePass;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginUserName;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox cbRememberMe;
    }
}