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

namespace Lab03
{
    public partial class Lab03_Bai1_Client : Form
    {
        public Lab03_Bai1_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                UdpClient udpClient = new UdpClient();
                Byte[] sendBytes = Encoding.ASCII.GetBytes(tbMessage.Text);
                udpClient.Send(sendBytes, sendBytes.Length, tbIPRemote.Text, int.Parse(tbPort.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Vui long nhap IP va Port");
            }
           
        }
    }
}
