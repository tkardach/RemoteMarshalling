using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Marshalling.RemoteClient
{
    public partial class MainWindow : Form
    {
        private CreateContact _createContactForm;
        private AddressBook _addressBookForm;

        public MainWindow(IDictionary<Type, Form> forms)
        {
            InitializeComponent();

            // Find the CreateContact form in the list and assign it to the local variable
            if (forms.ContainsKey(typeof(CreateContact)))
                _createContactForm = forms[typeof(CreateContact)] as CreateContact;

            // Find the AddressBook form in the list and assign it to the local variable
            if (forms.ContainsKey(typeof(AddressBook)))
                _addressBookForm = forms[typeof(AddressBook)] as AddressBook;
        }

        /// <summary>
        /// Opens the address book if it is available
        /// </summary>
        private void btnAddContact_Clicked(object sender, EventArgs e)
        {
            if (_createContactForm == null || _createContactForm.IsDisposed) return;
            if (_createContactForm.Visible) _createContactForm.Focus();
            _createContactForm.Show();
        }

        /// <summary>
        /// Opens the create contact window if it is available
        /// </summary>
        private void btnViewContacts_Click(object sender, EventArgs e)
        {
            if (_addressBookForm == null || _addressBookForm.IsDisposed) return;
            if (_addressBookForm.Visible) _addressBookForm.Focus();
            _addressBookForm.Show();
        }
    }
}
