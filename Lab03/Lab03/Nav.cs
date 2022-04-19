using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Nav : Form
    {
        public Nav()
        {
            InitializeComponent();
        }

        private void btnServe2_Click(object sender, EventArgs e)
        {
            Lab03_Bai2_Server server = new Lab03_Bai2_Server();
            server.ShowDialog();
        }

        private void btnClient1_Click(object sender, EventArgs e)
        {
            Lab03_Bai1_Client frmClient1 = new Lab03_Bai1_Client();
            frmClient1.Show();
        }

        private void btnServer1_Click(object sender, EventArgs e)
        {
            Lab03_Bai1_Server frmServer1 = new Lab03_Bai1_Server();
            frmServer1.Show();
        }

        private void svBtn4_Click(object sender, EventArgs e)
        {
            Lab03_Bai4_Server form = new Lab03_Bai4_Server();
            form.Show();
        }

        private void clnBtn4_Click(object sender, EventArgs e)
        {
            Lab03_Bai4_Client form = new Lab03_Bai4_Client();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nav_Load(object sender, EventArgs e)
        {

        }

        private void btnTCPServer_Click(object sender, EventArgs e)
        {
            Form tcpServer = new Lab03_Bai3_Server();
            tcpServer.Show();
        }

        private void btnTCPClient_Click(object sender, EventArgs e)
        {
            Form tcpClient = new Lab03_Bai4_Client();
            tcpClient.Show();
        }
    }
}
