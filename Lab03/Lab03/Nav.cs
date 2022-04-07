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
    }
}
