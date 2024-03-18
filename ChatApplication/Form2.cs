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
using System.Text;

namespace ChatApplication
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        UdpClient server;
        IPEndPoint remoteIp;
        int remotePort = 55555;
        int port = 44444;

        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            server = new UdpClient(port);
            remoteIp = new IPEndPoint(IPAddress.Parse(IPtextBox.Text), remotePort);
            server.BeginReceive(new AsyncCallback(onReceive), server);

        }

        private void onReceive(IAsyncResult ar)
        {
            byte[] buff = server.EndReceive(ar, ref remoteIp);
            server.BeginReceive(new AsyncCallback(onReceive), server);

            ControlInvoke(messageShowTB, () =>
            {
                messageShowTB.AppendText(":>>" + Encoding.ASCII.GetString(buff) + Environment.NewLine);
            });
        }

        private void sentBtn_Click(object sender, EventArgs e)
        {
            server.Connect(remoteIp);
            server.Send(Encoding.ASCII.GetBytes(messageTB.Text), messageTB.Text.Length);
            messageTB.Clear();
        }
        delegate void UniversalvoidDelegate();
        public static void ControlInvoke(Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(() => ControlInvoke(control, action)));
            }
            else
            {
                action();
            }
        }
    }
}
