using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshalling.RemoteObjects
{
    public delegate void ContactCreatedHandler(Contact contact);

    public class ContactEventProxy : MarshalByRefObject, IContactEventProxy
    {
        public event ContactCreatedHandler ContactCreated = delegate { };
        public event EventHandler ContactCreationFailed = delegate { };

        public override object InitializeLifetimeService()
        {
            return null; // Keeps object alive until explicitly destroyed
        }
        
        public void HandleContactCreated(Contact contact)
        {
            if (ContactCreated != null)
                ContactCreated(contact);
        }

        public void HandleContactCreationFailed(object sender, EventArgs args)
        {
            if (ContactCreated != null)
                ContactCreationFailed(sender, args);
        }
    }
}
