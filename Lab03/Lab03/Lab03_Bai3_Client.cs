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
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient tcpClient = new TcpClient();

                // 1. Ket noi
                tcpClient.Connect("127.0.0.1", 8080);
                Stream stream = tcpClient.GetStream();
                MessageBox.Show("Gửi thành công");
               
                // 2. Khoi tao message
                string message = "Hello server";
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                // 3. Gui message
                writer.WriteLine(message);                
                
                // 4. Dong ket noi
                stream.Close();
                tcpClient.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra server");
            }
        }

    

        private void Lab03_Bai3_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
