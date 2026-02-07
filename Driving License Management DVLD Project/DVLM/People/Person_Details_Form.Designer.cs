namespace DVLM.People
{
    partial class Person_Details_Form
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
            this.CtrlPersonCard = new DVLM.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // lblModer
            // 
            this.lblModer.AutoSize = true;
            this.lblModer.BackColor = System.Drawing.Color.Transparent;
            this.lblModer.Font = new System.Drawing.Font("PoetsenOne", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModer.ForeColor = System.Drawing.Color.Red;
            this.lblModer.Location = new System.Drawing.Point(546, 9);
            this.lblModer.Name = "lblModer";
            this.lblModer.Size = new System.Drawing.Size(209, 35);
            this.lblModer.TabIndex = 15;
            this.lblModer.Text = "Person Details";
            // 
            // CtrlPersonCard
            // 
            this.CtrlPersonCard.Location = new System.Drawing.Point(12, 59);
            this.CtrlPersonCard.Name = "CtrlPersonCard";
            this.CtrlPersonCard.Size = new System.Drawing.Size(1194, 423);
            this.CtrlPersonCard.TabIndex = 17;
            // 
            // Person_Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1232, 511);
            this.Controls.Add(this.CtrlPersonCard);
            this.Controls.Add(this.lblModer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Person_Details_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person_Details_Form";
            this.Load += new System.EventHandler(this.Person_Details_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblModer;
        private ctrlPersonCard CtrlPersonCard;
    }
}