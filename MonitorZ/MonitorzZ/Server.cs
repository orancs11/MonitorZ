using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace MonitorzZ;
/*
 *  Create server for clients to get connected
 *  
 */


public class Server
{
    private const int PORT = 3000;
    private String HostName { get; set; }
    private IPHostEntry localhost { get; set; }
    private IPAddress Ip { get; set; }
    private IPEndPoint EndPoint { get; set; }
    private Socket Listener { get; set; }
    private readonly List<IClient> ConnectedMachines = new();
    

    public Server()
    {
        HostName = Dns.GetHostName();
        localhost = FindEntry(HostName).Result;
        Ip = localhost.AddressList[0];
        EndPoint = new(Ip, PORT);
        Listener = new(
            EndPoint.AddressFamily,
            SocketType.Stream,
            ProtocolType.Tcp);
        Initialize();
    }

    private async Task<IPHostEntry> FindEntry(String hostname)
    {
        return await Dns.GetHostEntryAsync(hostname);
    }

    private void Initialize()
    {
        Listener.Bind(EndPoint);
        Listener.Listen();
    }

    public async Task<Socket> OpenConnection()
    {
        return await Listener.AcceptAsync();
    }
}