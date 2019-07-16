# RemoteMarshalling

This is an example of using Marshalling to transport objects between applications. In this example we have a server hosting a model, and a client which will update the model and update the view according to the model.
The client and server will exist in different applications, and will need to marshall information to eachother to pass necessary information.

The example application is a simple address book. You can create a contact in the client view and it will add it to the model on the server.

Important techniques used:
<ul>
  <li>.NET Framework Remoting with Marshalling</li>
  <li>Event proxies to handle marshalled events between client and server</li>
  <li>Model View Controller Architecture</li>
  
