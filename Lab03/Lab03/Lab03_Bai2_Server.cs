using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Lab03
{
    public partial class Lab03_Bai2_Server : Form
    {
        public Lab03_Bai2_Server()
        {
            InitializeComponent();
        }
        public void StartUnsafeThread()
        {
            int recv;
            byte[] data = new byte[1024];
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(serverIP, 8080);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(ipep);
            newsock.Listen(10);
            Socket client = newsock.Accept();
            while (true)
            {
                data = new byte[1024];
                recv = client.Receive(data);
                if (recv == 0) break;
                string rcvMessage = Encoding.ASCII.GetString(data, 0, recv);
                richTextBox1.Text += rcvMessage;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }
    }
}
