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
    public partial class Lab03_Bai1_Server : Form
    {
        public void InfoMessage(string mess)
        {
            tbReceived.Text += mess + "\r\n";
        }
        public void serverThread()
        {
            int port = 0;
            try
            {
                port = int.Parse(tbPort.Text);
                lbListen.Text = "Listen: ON";
            }
            catch(Exception)
            {
                MessageBox.Show("Vui lòng nhập port");
            }
                UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                string mess =  RemoteIpEndPoint.Address.ToString() + " : " + returnData.ToString();

                InfoMessage(mess);
            }
        }

        public Lab03_Bai1_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {   
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();            
        }
    }
}
