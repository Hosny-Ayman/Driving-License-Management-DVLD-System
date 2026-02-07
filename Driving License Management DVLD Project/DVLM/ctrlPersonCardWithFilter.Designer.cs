namespace DVLM
{
    partial class ctrlPersonCardWithFilter
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
            this.gbctrlFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindPerson = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchUserFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctrlPersonCard1 = new DVLM.ctrlPersonCard();
            this.gbctrlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbctrlFilter
            // 
            this.gbctrlFilter.BorderColor = System.Drawing.Color.Black;
            this.gbctrlFilter.Controls.Add(this.btnAddNewPerson);
            this.gbctrlFilter.Controls.Add(this.btnFindPerson);
            this.gbctrlFilter.Controls.Add(this.txtSearchUserFilter);
            this.gbctrlFilter.Controls.Add(this.cbFilter);
            this.gbctrlFilter.Controls.Add(this.label1);
            this.gbctrlFilter.CustomBorderColor = System.Drawing.Color.Black;
            this.gbctrlFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbctrlFilter.ForeColor = System.Drawing.Color.White;
            this.gbctrlFilter.Location = new System.Drawing.Point(3, 3);
            this.gbctrlFilter.Name = "gbctrlFilter";
            this.gbctrlFilter.Size = new System.Drawing.Size(1192, 103);
            this.gbctrlFilter.TabIndex = 0;
            this.gbctrlFilter.Text = "Filter";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbFilter.Location = new System.Drawing.Point(143, 50);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(212, 36);
            this.cbFilter.TabIndex = 13;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter By :";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewPerson.BorderRadius = 15;
            this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPerson.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewPerson.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddNewPerson.Image = global::DVLM.Properties.Resources.incorporation;
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewPerson.Location = new System.Drawing.Point(740, 43);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.PressedColor = System.Drawing.Color.Lime;
            this.btnAddNewPerson.Size = new System.Drawing.Size(73, 54);
            this.btnAddNewPerson.TabIndex = 34;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnFindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindPerson.BorderRadius = 15;
            this.btnFindPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindPerson.FillColor = System.Drawing.Color.Transparent;
            this.btnFindPerson.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFindPerson.ForeColor = System.Drawing.Color.Black;
            this.btnFindPerson.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFindPerson.Image = global::DVLM.Properties.Resources.FindPerson;
            this.btnFindPerson.ImageSize = new System.Drawing.Size(50, 50);
            this.btnFindPerson.Location = new System.Drawing.Point(651, 43);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.PressedColor = System.Drawing.Color.Lime;
            this.btnFindPerson.Size = new System.Drawing.Size(73, 54);
            this.btnFindPerson.TabIndex = 33;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click_1);
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
            this.txtSearchUserFilter.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUserFilter.ForeColor = System.Drawing.Color.Black;
            this.txtSearchUserFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchUserFilter.IconLeft = global::DVLM.Properties.Resources.team;
            this.txtSearchUserFilter.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtSearchUserFilter.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtSearchUserFilter.Location = new System.Drawing.Point(373, 52);
            this.txtSearchUserFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchUserFilter.Name = "txtSearchUserFilter";
            this.txtSearchUserFilter.PlaceholderText = "";
            this.txtSearchUserFilter.SelectedText = "";
            this.txtSearchUserFilter.Size = new System.Drawing.Size(271, 36);
            this.txtSearchUserFilter.TabIndex = 31;
            this.txtSearchUserFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchUserFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchUserFilter_KeyPress);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(3, 112);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(1194, 423);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.gbctrlFilter);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(1202, 538);
            this.Load += new System.EventHandler(this.ctrlFilter_Load);
            this.gbctrlFilter.ResumeLayout(false);
            this.gbctrlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbctrlFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchUserFilter;
        private Guna.UI2.WinForms.Guna2Button btnFindPerson;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
        private ctrlPersonCard ctrlPersonCard1;
    }
}
