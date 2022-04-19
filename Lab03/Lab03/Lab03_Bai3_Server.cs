using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Lab03
{
    public partial class Lab03_Bai3_Server : Form
    {
        public Lab03_Bai3_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Hide();
            rtbData.Text = "Server is running on IP: 127.0.0.1, Port: 8080" + "\n";
            Thread thread = new Thread(new ThreadStart(StartThread));
            thread.Start();
        }

        private void StartThread()
        {
            byte[] recv = new byte[1024];
            Socket client;
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listen.Bind(ipep);
            listen.Listen(-1);
            client = listen.Accept();
            rtbData.Text += "A new client connected" + "\n";
            while (client.Connected)
            {
                client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv);
                rtbData.Text += s + "\n";
            }
            listen.Close();
        }

        private void rtbData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
