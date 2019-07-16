using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalling.RemoteObjects
{

    public class ContactModel : MarshalByRefObject, IContactModel
    {
        public event ContactCreatedHandler ContactCreated = delegate { };
        public event EventHandler ContactCreationFailed = delegate { };

        List<Contact> _contacts;

        public ContactModel()
        {
            _contacts = new List<Contact>();
        }

        public List<Contact> GetContacts()
        {
            return _contacts;
        }

        public void CreateContact(string firstName, string lastName, string number)
        {
            if ((string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName)) || string.IsNullOrEmpty(number))
                SafeInvokeContactCreationFailed(this, EventArgs.Empty);
            AddContact(new Contact(firstName, lastName, number));
        }

        public void CreateContact(string firstName, string lastName, string number, string email)
        {
            if ((string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName)) || (string.IsNullOrEmpty(number) && string.IsNullOrEmpty(email)))
                SafeInvokeContactCreationFailed(this, EventArgs.Empty);
            AddContact(new Contact(firstName, lastName, number, email));
        }

        private void AddContact(Contact contact)
        {
            _contacts.Add(contact);
            SafeInvokeContactCreated(contact);
        }

        /// <summary>
        /// Safely handles all ContactCreatedHandler event invocation
        /// </summary>
        /// <param name="contact">Contact event argument</param>
        private void SafeInvokeContactCreated(Contact contact)
        {
            if (ContactCreated == null) return;

            ContactCreatedHandler listener = null;
            Delegate[] dels = ContactCreated.GetInvocationList();

            foreach (Delegate del in dels)
            {
                try
                {
                    listener = (ContactCreatedHandler)del;
                    listener.Invoke(contact);
                }
                catch (Exception e)
                {
                    ContactCreated -= listener;
                }
            }
        }

        /// <summary>
        /// Safely handles ContactCreationFailed event invocation
        /// </summary>
        /// <param name="contact"></param>
        private void SafeInvokeContactCreationFailed(object sender, EventArgs args)
        {
            if (ContactCreationFailed == null) return;

            EventHandler listener = null;
            Delegate[] dels = ContactCreationFailed.GetInvocationList();

            foreach (Delegate del in dels)
            {
                try
                {
                    listener = (EventHandler)del;
                    listener.Invoke(sender, args);
                }
                catch (Exception e)
                {
                    ContactCreationFailed -= listener;
                }
            }
        }
    }
}
