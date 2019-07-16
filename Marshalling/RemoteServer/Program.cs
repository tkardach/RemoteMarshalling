using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Marshalling.RemoteObjects;
using System.Collections;

namespace Marshalling.RemoteServer
{
    class Program
    {
        private static ObjRef modelReference;
        static void Main(string[] args)
        {
            // Initialize the server side of the TCP connection
            BinaryServerFormatterSinkProvider provider = new BinaryServerFormatterSinkProvider();
            provider.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
           
            // Create the server properties
            IDictionary props = new Hashtable();
            props["port"] = 6969;
            props["name"] = "AddressBookServer";

            TcpChannel channel = new TcpChannel(props, null, provider);

            // Create the model that will be used and maintained by the server
            var model = new ContactModel();

            Console.WriteLine("Starting server AddressBookServer");

            try
            {
                // Register the channel to ChannelServices
                ChannelServices.RegisterChannel(channel, true);

                // Marshal the ContactModel so that clients may use it
                modelReference = RemotingServices.Marshal(model, props["name"].ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }
            
            Console.WriteLine("Press return to exit the server...");
            Console.ReadLine();
        }
    }
}
