namespace Marshalling.RemoteClient
{
    partial class ContactView
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
            this.lblLastFirstName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLastFirstName
            // 
            this.lblLastFirstName.AutoSize = true;
            this.lblLastFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastFirstName.Location = new System.Drawing.Point(30, 19);
            this.lblLastFirstName.Name = "lblLastFirstName";
            this.lblLastFirstName.Size = new System.Drawing.Size(79, 20);
            this.lblLastFirstName.TabIndex = 0;
            this.lblLastFirstName.Text = "Last, First";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(30, 39);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(65, 20);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(30, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblLastFirstName);
            this.Name = "ContactView";
            this.Size = new System.Drawing.Size(280, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastFirstName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblEmail;
    }
}
