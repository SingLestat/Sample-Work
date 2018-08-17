using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream stream;

        public Form1()
        {
            InitializeComponent();

            client = new TcpClient("fe80::fc80:322:9e5f:fda9%11", 333);
            stream = client.GetStream();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            int byteSize = Encoding.ASCII.GetByteCount(txtUserName.Text + ": " + txtMessage.Text);
            byte[] sendMsg = new byte[byteSize];

            sendMsg = Encoding.ASCII.GetBytes(txtUserName.Text + ": " + txtMessage.Text);
            stream.Write(sendMsg, 0, sendMsg.Length);

            rtChat.Text += txtUserName.Text + ": " + txtMessage.Text + "\n";
            txtMessage.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task task = Task.Run(() => Networking());

            task.Start();
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }

            rtChat.AppendText(value);
        }


        private void Networking()
        {
            while(true)
            {
                byte[] buffer = new byte[100];

                int bufferRead = stream.Read(buffer, 0, buffer.Length);

                AppendTextBox(Encoding.ASCII.GetString(buffer, 0, bufferRead) + "\n");
            }
        }

        private void txtMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                btnSendMsg_Click(sender, e);
            }
        }
    }
}
