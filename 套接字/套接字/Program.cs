using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace 套接字
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint iep = new IPEndPoint(ip, 1234);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Console.WriteLine("Blocking {0}",socket.Blocking);
            Console.WriteLine("Connected {0}",socket.Connected);
            socket.Bind(iep);
            Console.WriteLine("Lock EndPoint {0}", socket.LocalEndPoint.ToString());
        }
    }
}
