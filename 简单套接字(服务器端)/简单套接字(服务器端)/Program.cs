using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace 简单套接字_服务器端_
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;

                IPHostEntry local = Dns.GetHostByName(Dns.GetHostName());
                Console.WriteLine(local.AddressList[0]);
                IPEndPoint iep = new IPEndPoint(local.AddressList[0], 8080);
                Socket serversocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serversocket.Bind(iep);
                //TcpListener tcplistener = new TcpListener(iep);
                serversocket.Listen(10);
                //tcplistener.Start();
                Socket myClient = serversocket.Accept();//不能放在while里面！！
                
                while(true)
                {


                  

                        try
                        {
                            byte[] data = new byte[128];
                            myClient.Receive(data);
                            StringBuilder strbuilder = new StringBuilder(System.Text.Encoding.UTF8.GetString(data).TrimEnd('\0'));
                            Console.WriteLine(strbuilder);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                        //myClient.Close();

                    }

                    
                   
               
               // Console.Read();
  


        }
    }
}

