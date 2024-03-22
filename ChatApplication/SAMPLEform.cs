using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;




namespace ChatApplication
{
    public partial class SAMPLEform : Form
    {
        private static TcpListener listener;
        private static TcpClient server;
        private static TcpClient client;
        private string selectedIP;
        private int selectedSenterId;
        private Thread ListenerThread;

        public SAMPLEform()
        {

            ChatApplicationDatabaseManager.DatabaseConnection();
            InitializeComponent();

            ListenerThread = new Thread(StartServerConnection);
            // ListenerThread.Start();
            StartServerConnection();
            Log("Server started. Waiting for connections...");

            AcceptClient();



            Checker();
            
        }
        private async void Checker()
        {
            Task<bool> task1 = Task.Run(() => IsClientOnline("192.168.3.59", 12345));
            Task<bool> task2 = Task.Run(() => IsClientOnline("192.168.3.52", 12345));
            Task<bool> task3 = Task.Run(() => IsClientOnline("192.168.3.50", 12345));

            bool c1 = await task1;
            bool c2 = await task2;
            bool c3 = await task3;


            
           if (c1) Mathanbtn.BackColor = Color.LightGreen;
           if (c2) SivaBtn.BackColor = Color.LightGreen;
           if (c3) Subramanibtn.BackColor = Color.LightGreen;


        }
        public string GetPcIPAddress()
        {
            IPAddress[] iparray = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in iparray)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        }
        public string GetSenter(string SenterIP)
        {

            if (SenterIP.Equals("192.168.3.59")) return "Mathan";
            if (SenterIP.Equals("192.168.3.50")) return "Subramani";
            if (SenterIP.Equals("192.168.3.62")) return "Siva Suriya";
            return "";

        }
        //Server Connection for recieve Request

        public void StartServerConnection()
        {
            listener = new TcpListener(IPAddress.Any, 12345);
            listener.Start();
            AcceptClient();
        }

        public async void AcceptClient()
        {
            client = await listener.AcceptTcpClientAsync();
            HandleClient();
        }

        public async void HandleClient()
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;
            string data;
            try
            {
                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Log($"Received form {GetSenter(client.Client.RemoteEndPoint.ToString().Substring(0,12))} : {data}");
                }
            }
            catch
            {
                client.Close();
            }
                   

            AcceptClient();
        }

        //Requset to Server for Connection

        private static bool ConnectToServer(string ipAddress, int port)
        {
            server = new TcpClient();
            server.Connect(ipAddress, port);
            return true;
        }




        private void ConnectMadan_Click(object sender, EventArgs e)
        {
            server = new TcpClient();
            server.Connect("192.168.3.59", 12345);
            selectedIP = "192.168.3.59";
            selectedSenterId = 1;
            Log("Connected to Mathan server");
            
        }
        private void ConnectSubramani(object sender, EventArgs e)
        {
            server = new TcpClient();
            server.Connect("192.168.3.50", 12345);
            selectedIP = "192.168.3.50";
            selectedSenterId = 4;

            Log("Connected to Subramani server");
           

        }
        private async void ConnectSiva(object sender, EventArgs e)
        {
            server = new TcpClient();
            server.Connect("192.168.3.52", 8888);
            selectedIP = "192.168.3.52";
            selectedSenterId = 3;

            Log("Connected to Siva server.");
            int bytesRead;
            NetworkStream stream = server.GetStream();
            byte[] buffer = new byte[1024];
            while (true)
            {
                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string Message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Log($"Received : {Message}");
                }
            }

        }
       
        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (!(server == null || !server.Connected))
            {
                NetworkStream stream = server.GetStream();

                byte[] data = Encoding.ASCII.GetBytes(LogTextBox.Text);
                await stream.WriteAsync(data, 0, data.Length);
                Log($"Sent to {GetSenter(selectedIP.ToString())}: "+LogTextBox.Text);
                server.Close();
            }


            ChatApplicationDatabaseManager.CreateMessage(2, selectedSenterId, DateTime.Now, LogTextBox.Text, "No");
           
        }

        private void Log(string message)
        {
            MessageTextBox.AppendText(message + Environment.NewLine);
        }

        private bool IsClientOnline(string ipAddress, int port)
        {
            try
            {
                using (TcpClient tempClient = new TcpClient())
                {
                    tempClient.Connect(ipAddress, port);
                    return tempClient.Connected;
                }
            }
            catch (SocketException)
            {
                // If an exception occurs (e.g., connection refused), consider the client offline
                return false;
            }
        }



    }
}
