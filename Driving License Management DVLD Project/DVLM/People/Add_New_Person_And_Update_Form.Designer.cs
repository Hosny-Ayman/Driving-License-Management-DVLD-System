namespace DVLM.People
{
    partial class Add_New_Person_Form
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
            this.lblModer = new System.Windows.Forms.Label();
            this.ctrlAddNewPerson1 = new DVLM.ctrlAddNewPerson();
            this.SuspendLayout();
            // 
            // lblModer
            // 
            this.lblModer.AutoSize = true;
            this.lblModer.BackColor = System.Drawing.Color.Transparent;
            this.lblModer.Font = new System.Drawing.Font("PoetsenOne", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModer.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblModer.Location = new System.Drawing.Point(472, 9);
            this.lblModer.Name = "lblModer";
            this.lblModer.Size = new System.Drawing.Size(234, 35);
            this.lblModer.TabIndex = 14;
            this.lblModer.Text = "Add New Person";
            // 
            // ctrlAddNewPerson1
            // 
            this.ctrlAddNewPerson1.Location = new System.Drawing.Point(12, 47);
            this.ctrlAddNewPerson1.Name = "ctrlAddNewPerson1";
            this.ctrlAddNewPerson1.PersonID = 0;
            this.ctrlAddNewPerson1.Size = new System.Drawing.Size(1241, 601);
            this.ctrlAddNewPerson1.TabIndex = 0;
            this.ctrlAddNewPerson1.GetPersonID += new System.Action<int>(this.ctrlAddNewPerson1_GetPersonID);
            // 
            // Add_New_Person_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1273, 648);
            this.Controls.Add(this.lblModer);
            this.Controls.Add(this.ctrlAddNewPerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_New_Person_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Person And Update";
            this.Load += new System.EventHandler(this.Add_New_Person_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlAddNewPerson ctrlAddNewPerson1;
        private System.Windows.Forms.Label lblModer;
    }
}