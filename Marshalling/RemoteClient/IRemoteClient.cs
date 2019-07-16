using Marshalling.RemoteObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalling.RemoteClient
{
    public interface IContactController
    {
        void ClearCreateContact();
        void CreateContact(string firstName, string lastName, string number);
        void CreateContact(string firstName, string lastName, string number, string email);
        void ConnectView(ICreateContactView view);
        void ConnectView(IAddressBookView view);
    }

    public interface ICreateContactView
    {
        void ClearView();
    }

    public interface IAddressBookView
    {
        void CreateContact(Contact contact);
        void ClearContacts();
        void UpdateContacts(IList<Contact> contacts);
    }
}
