using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marshalling.RemoteObjects;

namespace Marshalling.RemoteClient
{
    [Serializable]
    class RemoteClientController : IContactController
    {
        private ICreateContactView _createContactView;
        private IAddressBookView _addressBookView;
        private IContactModel _contactModel;
        private IContactEventProxy _eventProxy;

        /// <summary>
        /// Client controller used to mediate between views and model
        /// </summary>
        /// <param name="eventProxy"></param>
        public RemoteClientController(IContactEventProxy eventProxy)
        {
            // Subscribe the event proxy events to local event handlers
            _eventProxy = eventProxy;
            _eventProxy.ContactCreated += new ContactCreatedHandler(contactModel_ContactCreated);
            _eventProxy.ContactCreationFailed += new EventHandler(contactModel_ContactCreationFailed);
        }

        /// <summary>
        /// Connect the ICreateContactView to the controller
        /// </summary>
        public void ConnectView(ICreateContactView view)
        {
            _createContactView = view;
        }


        /// <summary>
        /// Connect the IAddressBookView to the controller
        /// </summary>
        public void ConnectView(IAddressBookView view)
        {
            _addressBookView = view;
            _addressBookView.ClearContacts();
            _addressBookView.UpdateContacts(_contactModel.GetContacts());
        }

        /// <summary>
        /// Connect the model to the controller
        /// </summary>
        public void ConnectModel(IContactModel model)
        {
            // Save the model in a local variable
            _contactModel = model;

            // Subscribe the model's events to our event proxy handlers
            _contactModel.ContactCreated += new ContactCreatedHandler(_eventProxy.HandleContactCreated);
            _contactModel.ContactCreationFailed += new EventHandler(_eventProxy.HandleContactCreationFailed);
        }

        public void contactModel_ContactCreationFailed(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Creates a contact in the address book
        /// </summary>
        public void contactModel_ContactCreated(Contact contact)
        {
            _addressBookView.CreateContact(contact);
        }

        /// <summary>
        /// Clears the current parameters in the ICreateContactView
        /// </summary>
        public void ClearCreateContact()
        {
            _createContactView.ClearView();
        }

        public void CreateContact(string firstName, string lastName, string number)
        {
            _contactModel.CreateContact(firstName, lastName, number);
        }

        public void CreateContact(string firstName, string lastName, string number, string email)
        {
            _contactModel.CreateContact(firstName, lastName, number, email);
        }
    }
}
