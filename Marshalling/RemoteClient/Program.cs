using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Marshalling.RemoteObjects;
using System.Collections;

namespace Marshalling.RemoteClient
{
    static class Program
    {
        private const string SERVER_URI = "tcp://localhost:6969/AddressBookServer";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize client side of TCP communication

            var clientProv = new BinaryClientFormatterSinkProvider();
            var serverProv = new BinaryServerFormatterSinkProvider();

            // Necessary for event handling to work
            serverProv.TypeFilterLevel =
              System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            
            Hashtable props = new Hashtable();
            props["name"] = "remotingClient";
            props["port"] = 0;      // Use the first available port

            var channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, true);

            // Get the model from the server
            RemotingConfiguration.RegisterWellKnownClientType(
              new WellKnownClientTypeEntry(typeof(IContactModel), SERVER_URI));

            // Get the model from the server
            var model = (IContactModel)Activator.GetObject(typeof(IContactModel), SERVER_URI);
            
            // Create the EventProxy, used for handling events locally
            var proxy = new ContactEventProxy();

            // Initialize the controller (in MVC scheme)
            var controller = new RemoteClientController(proxy);

            // Connect the model to the controller
            controller.ConnectModel(model);

            // Create all of the views being used by the application
            IDictionary<Type, Form> forms = new Dictionary<Type, Form>();
            forms.Add(typeof(CreateContact), new CreateContact(controller));
            forms.Add(typeof(AddressBook), new AddressBook(controller));
            
            // Create the main window form
            Application.Run(new MainWindow(forms));
        }
    }
}
