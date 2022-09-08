using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Microsoft.Win32.SafeHandles;

namespace MathiasVansteensel.GIP._2022_2023.CrossPlatform.Networking;

public enum NetworkProtocol
{
    UDP,
    TCP,
    HTTP
}

internal class NetworkClient
{
    bool IsAlive(, NetworkProtocol protocol = NetworkProtocol.HTTP) 
    {
        switch (protocol)
        {
            case NetworkProtocol.UDP:
                using (UdpClient client = new(,))
                {

                }
                break;
            case NetworkProtocol.TCP:
                break;
            case NetworkProtocol.HTTP:
                break;
            default:
                break;
        }
    }
}
