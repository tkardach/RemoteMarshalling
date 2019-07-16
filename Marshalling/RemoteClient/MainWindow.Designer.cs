namespace Marshalling.RemoteClient
{
    partial class MainWindow
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
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnViewContacts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(57, 30);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(102, 23);
            this.btnAddContact.TabIndex = 0;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Clicked);
            // 
            // btnViewContacts
            // 
            this.btnViewContacts.Location = new System.Drawing.Point(57, 59);
            this.btnViewContacts.Name = "btnViewContacts";
            this.btnViewContacts.Size = new System.Drawing.Size(102, 23);
            this.btnViewContacts.TabIndex = 1;
            this.btnViewContacts.Text = "View Contacts";
            this.btnViewContacts.UseVisualStyleBackColor = true;
            this.btnViewContacts.Click += new System.EventHandler(this.btnViewContacts_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 117);
            this.Controls.Add(this.btnViewContacts);
            this.Controls.Add(this.btnAddContact);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnViewContacts;
    }
}