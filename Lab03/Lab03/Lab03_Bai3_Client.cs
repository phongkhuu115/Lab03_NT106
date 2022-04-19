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
using System.Net.WebSockets;
using System.IO;
using System.Net.Configuration;

namespace Lab03
{
    public partial class Lab03_Bai3_Client : Form
    {
        IPEndPoint ipep;
        Socket client;
        public Lab03_Bai3_Client()
        {
            InitializeComponent();
            Connect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string s = "Hello server!" + "\n";
            client.Send(Encoding.UTF8.GetBytes(s));
        }

        private void Connect()
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            client.Connect(ipep);
        }

        private void Lab03_Bai3_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
