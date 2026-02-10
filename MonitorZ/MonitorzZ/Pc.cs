using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MonitorzZ;

public class Pc : IClient
{
    
    [Required]
    private string Port { get; set; }
    [Required]
    private string Ip { get; set; }
    /*
     * Ram Usage
     * Ram Info
     * CPU usage
     * CPU info
     */

    public Pc(string port, string ip)
    {
        this.Port = port;
        this.Ip = ip;
    }

    public bool Connect(string port, string ip)
    {
        throw new NotImplementedException();
    }

    public bool Disconnect()
    {
        throw new NotImplementedException();
    }

    public bool SendData()
    {
        throw new NotImplementedException();
    }
}