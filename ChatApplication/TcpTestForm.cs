using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplicationTest
{
    public partial class TcpTestForm : Form
    {
        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string receive;
        public string texttosend;

        public TcpTestForm()
        {
            InitializeComponent();
            IPAddress[] localIp = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIp)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPtextBox.Text = address.ToString();
                }
            }
        }

        private void startBtnClick(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPortTB.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            stw = new StreamWriter(client.GetStream());
            stw.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(clientIPTB.Text), int.Parse(clientPortTB.Text));
            try
            {
                messageShowTB.AppendText("Connected to server+ \n");
                stw = new StreamWriter(client.GetStream());
                str = new StreamReader(client.GetStream());
                stw.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = str.ReadLine();
                    this.messageShowTB.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        messageShowTB.AppendText("receive:" + receive + "\n");
                    }));
                    receive = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                stw.WriteLine(texttosend);
                this.messageShowTB.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        messageShowTB.AppendText("You:" + texttosend + "\n");
                    }));
            }
            else
            {
                MessageBox.Show("Connection fail");
            }
            backgroundWorker2.CancelAsync();
        }

        private void SentBtn_Click(object sender, EventArgs e)
        {
            if (messageTB.Text != "")
            {
                texttosend = messageTB.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            messageTB.Text = "";
        }
    }
}
