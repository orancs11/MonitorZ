using System.Net.Sockets;
using MonitorzZ;

Server server = new Server();

Socket handler = server.OpenConnection().Result;