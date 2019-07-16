using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalling.RemoteObjects
{
    public interface IContactModel : IContactEvents
    {
        void CreateContact(string firstName, string lastName, string number);
        void CreateContact(string firstName, string lastName, string number, string email);
        List<Contact> GetContacts();
    }

    public interface IContactEventProxy : IContactEvents
    {
        void HandleContactCreated(Contact contact);
        void HandleContactCreationFailed(object sender, EventArgs args);
    }

    public interface IContactEvents
    {
        event ContactCreatedHandler ContactCreated;
        event EventHandler ContactCreationFailed;
    }
}
