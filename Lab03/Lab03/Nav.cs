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
    }
}
