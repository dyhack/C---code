using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace 同步套接字编写服务器端
{
    
    public partial class Form1 : Form
    {
        private Socket socket;
        private Socket clientSocket;
        private Thread thread;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startlistenbutton_Click(object sender, EventArgs e)
        {
            this.startlistenbutton.Enabled = false;
            IPAddress ip = IPAddress.Parse(this.servertextBox.Text);
            IPEndPoint ipe = new IPEndPoint(ip, Int32.Parse(this.porttextBox.Text));
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipe);
            socket.Listen(10);
            clientSocket = socket.Accept();
            this.listBox1.Items.Add("与客户" + clientSocket.RemoteEndPoint.ToString() + "建立连接");
           //创建一个线程接受客户信息
           // thread = new Thread(new ThreadStart());
           //thread.Start();

        }
        private void AcceptMessage()
        {
            
        }




    }
}
