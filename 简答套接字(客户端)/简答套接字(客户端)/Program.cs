using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace 简答套接字_客户端_
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
             String input;
            try
            {
                Console.WriteLine("请输入服务端ip地址");
                string getip = Console.ReadLine();
                IPAddress remoteip = IPAddress.Parse(getip);
                IPEndPoint iep = new IPEndPoint(remoteip, 8080);
                Socket Clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Clientsocket.Connect(iep);
                if (Clientsocket.Connected == true)
                {
                    Console.WriteLine("连接服务器成功!");
                }
                else
                {
                    Console.WriteLine("连接失败");
                }
                while (true)
                {

                        byte[] data = new byte[128];
                        string str = Console.ReadLine();
                        data = System.Text.Encoding.UTF8.GetBytes(str);
                        Clientsocket.Send(data);


                  
                   
                    //Console.WriteLine(System.Text.Encoding.ASCII.GetString(data));
                    //Clientsocket.Shutdown(SocketShutdown.Both);
                    //Clientsocket.Close();
                   // Console.Read();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        

        }
    }
}
