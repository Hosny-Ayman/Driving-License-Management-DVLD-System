namespace DVLM
{
    partial class ctrlLicenseCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearchUserFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfo1 = new DVLM.ctrlDriverLicenseInfo();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BorderColor = System.Drawing.Color.Black;
            this.gbFilter.Controls.Add(this.guna2ImageButton1);
            this.gbFilter.Controls.Add(this.txtSearchUserFilter);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.CustomBorderColor = System.Drawing.Color.Black;
            this.gbFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.Color.White;
            this.gbFilter.Location = new System.Drawing.Point(307, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(709, 82);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.Text = "Filter";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::DVLM.Properties.Resources.driving_license17;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(472, 43);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(50, 35);
            this.guna2ImageButton1.TabIndex = 82;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // txtSearchUserFilter
            // 
            this.txtSearchUserFilter.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchUserFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchUserFilter.DefaultText = "";
            this.txtSearchUserFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchUserFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchUserFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchUserFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchUserFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchUserFilter.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUserFilter.ForeColor = System.Drawing.Color.Black;
            this.txtSearchUserFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchUserFilter.IconLeft = global::DVLM.Properties.Resources.driving_license17;
            this.txtSearchUserFilter.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtSearchUserFilter.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtSearchUserFilter.Location = new System.Drawing.Point(172, 45);
            this.txtSearchUserFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchUserFilter.Name = "txtSearchUserFilter";
            this.txtSearchUserFilter.PlaceholderText = "";
            this.txtSearchUserFilter.SelectedText = "";
            this.txtSearchUserFilter.Size = new System.Drawing.Size(293, 33);
            this.txtSearchUserFilter.TabIndex = 81;
            this.txtSearchUserFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchUserFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchUserFilter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 33);
            this.label2.TabIndex = 79;
            this.label2.Text = "License ID :";
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(3, 84);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(1396, 490);
            this.ctrlDriverLicenseInfo1.TabIndex = 2;
            this.ctrlDriverLicenseInfo1.GetPersonIDAndDriverID += new System.Action<int, int>(this.ctrlDriverLicenseInfo1_GetPersonIDAndDriverID);
            this.ctrlDriverLicenseInfo1.IsActiveLicenseAndIsNotExpired += new System.Action<bool, bool>(this.ctrlDriverLicenseInfo1_IsActiveLicenseAndIsNotExpired);
            this.ctrlDriverLicenseInfo1.GetLicenseID += new System.Action<int>(this.ctrlDriverLicenseInfo1_GetLicenseID);
            // 
            // ctrlLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(1402, 571);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchUserFilter;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
    }
}
