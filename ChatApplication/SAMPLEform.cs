using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace ChatApplication
{
    public partial class SAMPLEform : Form
    {
        public SAMPLEform()
        {
            InitializeComponent();
            listener = new TcpListener(IPAddress.Any, 12345);
            listener.Start();
            Log("Server started. Waiting for connections...");

            AcceptClient();
        }
        private TcpListener listener;
        private TcpClient Client;
        static List<TcpClient> clients = new List<TcpClient>();
        private TcpClient MClient;
        
        private string selectedIP;
        private int selectedSenterId;


        private void StartServerButton_Click(object sender, EventArgs e)
        {
            //listener = new TcpListener(IPAddress.Any, 12345);
            //listener.Start();
            //Log("Server started. Waiting for connections...");

            //AcceptClient();
        }

        private async void AcceptClient()
        {
            Client = await listener.AcceptTcpClientAsync();
            clients.Add(Client);
            Log("Client connected.");

            HandleClient();
        }

        private async void HandleClient()
        {
            NetworkStream stream = Client.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Log($"Received: {data}");

                // Echo back to the client
                byte[] response = Encoding.ASCII.GetBytes("Server: " + data);
                await stream.WriteAsync(response, 0, response.Length);
            }

            Client.Close();
            Log("Client disconnected.");
            AcceptClient(); // Wait for another client
        }


        private void ConnectMadan_Click(object sender, EventArgs e)
        {
            MClient = new TcpClient();
            MClient.Connect("192.168.3.59", 12345);
            selectedIP = "192.168.3.59";
            selectedSenterId = 1;
            Log("Connected to server.");
        }
        private void ConnectSubramani(object sender, EventArgs e)
        {
            MClient = new TcpClient();
            MClient.Connect("192.168.3.50", 12345);
            selectedIP = "192.168.3.50";
            selectedSenterId = 4;

            Log("Connected to server.");
            
        }
        private void ConnectSiva(object sender, EventArgs e)
        {
            MClient = new TcpClient();
            MClient.Connect("192.168.3.52", 12345);
            selectedIP = "192.168.3.52";
            selectedSenterId = 3;

            Log("Connected to server.");
            
        }
        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (MClient == null || !MClient.Connected)
            {
                MessageBox.Show("Not connected to the server.");
                return;
            }

            NetworkStream stream = MClient.GetStream();
            string message = LogTextBox.Text;

            byte[] data = Encoding.ASCII.GetBytes(message);
            await stream.WriteAsync(data, 0, data.Length);

            Log($"Sent: {message}");

            // Receive response from server
            byte[] responseBuffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(responseBuffer, 0, responseBuffer.Length);
            string response = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);
            //   public static bool CreateMessage(int fromID, int toID, DateTime dateAndTime, string message, string isGroup)
            
            ChatApplicationDatabaseManager.CreateMessage(2,selectedSenterId,DateTime.Now,LogTextBox.Text,"No");
           // Log($"Received: {response}");
        }

        private void Log(string message)
        {
            MessageTextBox.AppendText(message + Environment.NewLine);
        }



        
    }
}
