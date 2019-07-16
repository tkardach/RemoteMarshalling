using System.Collections.Generic;
using System.Windows.Forms;
using Marshalling.RemoteObjects;

namespace Marshalling.RemoteClient
{
    public partial class AddressBook : Form, IAddressBookView
    {
        private IContactController _controller;

        public AddressBook(IContactController controller)
        {
            InitializeComponent();
            _controller = controller;
            _controller.ConnectView(this);
        }

        public void ClearContacts()
        {
            if (InvokeRequired)
                this.BeginInvoke(new MethodInvoker(() => { ClearContacts(); }));
            else
                ContactList.Controls.Clear();
        }

        public void CreateContact(Contact contact)
        {
            if (InvokeRequired)
                this.BeginInvoke(new MethodInvoker(() => { CreateContact(contact); }));
            else
                ContactList.Controls.Add(new ContactView(contact.LastFirstName, contact.Number, contact.Email));
        }

        public void UpdateContacts(IList<Contact> contacts)
        {
            if (InvokeRequired)
                this.BeginInvoke(new MethodInvoker(() => { UpdateContacts(contacts); }));
            else
            {
                foreach (var item in contacts)
                    ContactList.Controls.Add(new ContactView(item.LastFirstName, item.Number, item.Email));
            }
        }

        private void AddressBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
