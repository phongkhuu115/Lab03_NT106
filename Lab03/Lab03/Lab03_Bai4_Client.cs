using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Lab03_Bai4_Client : Form
    {
        public Lab03_Bai4_Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage("Me: " + sendBox.Text);
        }
        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8088);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không kết nối được server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void Send()
        {
            if (sendBox.Text != string.Empty)
                client.Send(Serialize(nameBox.Text + ": " + sendBox.Text));
        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[4096];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch
            {
                Close();
            }

        }
        void AddMessage(string s)
        {
            chatBox.Items.Add(new ListViewItem() { Text = s });
            sendBox.Clear();
        }
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void Lab03_Bai4_Client_Load(object sender, EventArgs e)
        {

        }
    }
}

