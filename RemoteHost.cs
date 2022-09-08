using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MathiasVansteensel.GIP._2022_2023.CrossPlatform.Networking;
public class RemoteHost
{
    const string UrlRegex = @"(\b[a-z]*):\/\/(.{1,253}(\.\w+))\/(.+\/)?";
    const byte RegexHostNameGroup = 2;

    public IPAddress IPAdress { get; set; }
    public short Port { get; set; }
    public string HostName { get; set; }

    public RemoteHost(IPAddress ipAdress, short port)
    {
        IPAdress = ipAdress;
        Port = port;
        HostName = Dns.GetHostEntry(ipAdress).HostName;
    }

    public RemoteHost(string url, short port) //TODO: check rework regex to allow ip adresses in url form
    {
        IPAdress = Dns.GetHostEntry(url).AddressList[0];
        Port = port;
        Group regexHostNameMatch = Regex.Match(url, UrlRegex).Groups[RegexHostNameGroup];
        bool isHostNameValid = regexHostNameMatch.Success;
        HostName = isHostNameValid ? regexHostNameMatch.Value : throw new UriFormatException($"'{url}' is not a valid URL");
    }
}
