namespace Marshalling.RemoteClient
{
    partial class AddressBook
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
            this.ContactList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ContactList
            // 
            this.ContactList.AutoScroll = true;
            this.ContactList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ContactList.Location = new System.Drawing.Point(13, 13);
            this.ContactList.Name = "ContactList";
            this.ContactList.Size = new System.Drawing.Size(300, 422);
            this.ContactList.TabIndex = 0;
            this.ContactList.WrapContents = false;
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 446);
            this.Controls.Add(this.ContactList);
            this.Name = "AddressBook";
            this.Text = "Address Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddressBook_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ContactList;
    }
}

