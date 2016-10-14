using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
namespace IP地址和主机名
{
    class Program
    {
        static void Main(string[] args)
        {
            //得到主机名 
            string HostName = Dns.GetHostName();
            Console.WriteLine("主机名：{0}", HostName);
            IPHostEntry myhost = Dns.GetHostByName(HostName);
            foreach (IPAddress ip in myhost.AddressList)
            {
                Console.WriteLine("IP地址:{0}", ip.ToString());

            }
            IPAddress ip1 = IPAddress.Parse("127.0.0.1");
            IPAddress ip2 = IPAddress.Loopback;
            IPAddress ip3 = IPAddress.Broadcast;
            IPAddress ip4 = IPAddress.Any;
            IPAddress ip5 = IPAddress.None;
            Console.WriteLine("ip1 address:{0}", ip1);
            Console.WriteLine("ip2 Loopback:{0}", ip2);
            Console.WriteLine("ip3 Broadcast:{0}", ip3);
            Console.WriteLine("ip4 Any:{0}", ip4);
            Console.WriteLine("ip5 None:{0}", ip5);
            IPEndPoint iep = new IPEndPoint(ip1, 8000);
            Console.WriteLine("The IpEndPort is {0}", iep.ToString());
            Console.WriteLine("The AddresssFamily:{0} ",iep.AddressFamily);//网络类型是
            Console.WriteLine("最大端口是:{0}",IPEndPoint.MaxPort);
            Console.WriteLine("最小端口是:{0}", IPEndPoint.MinPort);




        }
    }
}
