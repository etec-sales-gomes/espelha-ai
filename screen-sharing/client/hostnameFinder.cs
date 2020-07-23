using System.Net;
using System.Net.Sockets;

namespace client
{
    class hostnameFinder
    {
        public string hostname(string hostname)
        {
            try
            {
                IPAddress[] ipaddress = Dns.GetHostAddresses(hostname);
                return ipaddress[ipaddress.Length - 1].ToString();
            }
            catch (SocketException)
            {
                return null;
            }
        }
    }
}
