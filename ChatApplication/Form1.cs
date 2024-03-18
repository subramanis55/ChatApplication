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

namespace ChatApplication
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string receive;
        public string texttosend;
        public Form1()
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
            
            try
            {
                IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(clientIPTB.Text), int.Parse(clientPortTB.Text));
                client.Connect(iPEnd);
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
                MessageBox.Show("sending fail");
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
//using System;
//using System.ComponentModel;
//using System.IO;
//using System.Net;
//using System.Net.Sockets;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ChatApplication
//{
//    public partial class Form1 : Form
//    {
//        private TcpListener listener;
//        private TcpClient client;
//        private StreamReader str;
//        private StreamWriter stw;
//        private string receive;
//        private string textToSend;

//        public Form1()
//        {
//            InitializeComponent();
//            // Initialize the TcpListener on form load
//            listener = new TcpListener(IPAddress.Any, int.Parse(ServerPortTB.Text));
//            listener.Start();
//            Task.Run(() => ListenForClients());
//        }

//        private async Task ListenForClients()
//        {
//            // Continuously listen for client connections
//            while (true)
//            {
//                try
//                {
//                    this.client = await listener.AcceptTcpClientAsync();
//                    // Start handling client messages
//                    HandleClientMessages();
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show(ex.Message);
//                }
//            }
//        }

//        private async Task HandleClientMessages()
//        {
//            using (str = new StreamReader(client.GetStream()))
//            {
//                while (client.Connected)
//                {
//                    try
//                    {
//                        receive = await str.ReadLineAsync();
//                        messageShowTB.AppendText("Received: " + receive + "\n");
//                    }
//                    catch (Exception ex)
//                    {
//                        MessageBox.Show(ex.Message);
//                    }
//                }
//            }
//        }

//        private void ConnectionBtn_Click(object sender, EventArgs e)
//        {
//            client = new TcpClient();
//            try
//            {
//                IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(clientIPTB.Text), int.Parse(clientPortTB.Text));
//                client.Connect(iPEnd);
//                messageShowTB.AppendText("Connected to server\n");
//                stw = new StreamWriter(client.GetStream());
//                stw.AutoFlush = true;
//                backgroundWorker1.RunWorkerAsync();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void SentBtn_Click(object sender, EventArgs e)
//        {
//            if (!string.IsNullOrWhiteSpace(messageTB.Text))
//            {
//                textToSend = messageTB.Text;
//                backgroundWorker2.RunWorkerAsync();
//                messageTB.Clear();
//            }
//        }

//        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
//        {
//            if (client != null && client.Connected)
//            {
//                stw.WriteLine(textToSend);
//                messageShowTB.AppendText("You: " + textToSend + "\n");
//            }
//            else
//            {
//                MessageBox.Show("Not connected to server");
//            }
//        }

//        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
//        {
//            // This method handles receiving messages from the server
//            while (client.Connected)
//            {
//                try
//                {
//                    receive = str.ReadLine();
//                    if (!string.IsNullOrEmpty(receive))
//                    {
//                        this.Invoke((MethodInvoker)delegate
//                        {
//                            messageShowTB.AppendText("Server: " + receive + "\n");
//                        });
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show(ex.Message);
//                }
//            }
//        }


//    }
//}

