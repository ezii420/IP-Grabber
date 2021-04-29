using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IP_Grabber
{
    class Grabber
    {
        public static string GetIp()
        {
            string ip = new WebClient().DownloadString("https://ipv4bot.whatismyipaddress.com/");
            return ip;
        }
    }
}
