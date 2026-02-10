namespace MonitorzZ;

/*
 * Represents local machines that will be connected to the server
 * 
 */

public interface IClient
{
    public bool Connect(string port, string ip);
    public bool Disconnect();
    public bool SendData();
}