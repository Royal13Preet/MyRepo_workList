using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ipaddress
{
    public class Program
    {
        static void Main(string[] args)
        {
            String strHostName = string.Empty;
            strHostName = Dns.GetHostName();

            Console.WriteLine("Local Machine's Host Name: " + strHostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {0} : {1} ", i + 1, addr[i].ToString());
            }
        }

    }
}
