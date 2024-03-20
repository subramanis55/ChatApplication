using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public static  class ChatApplicationNetworkManager
    {
        public static string GetPcIPAddress()
        {
            IPAddress[] iparray=Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress ip in iparray)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        } 
    }
}
