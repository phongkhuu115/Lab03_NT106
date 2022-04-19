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
            tbServer.Text = "Server running on 127.0.0.1:8080\n";
            try
            {
                IPAddress IPAddress = IPAddress.Parse("127.0.0.1");

                TcpListener tcpListener = new TcpListener(IPAddress, 8080);

                // 1. Khoi dong server
                tcpListener.Start();
                tbServer.Text += "New client connected\n";

                Socket socket = tcpListener.AcceptSocket();           

                var stream = new NetworkStream(socket);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;
                
                // 2. Nhan message
                string message = reader.ReadLine();
                tbServer.Text += message + "\n";
                
                // 3. Ngat ket noi
                stream.Close();
                socket.Close();
                tcpListener.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }


        private void rtbData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
