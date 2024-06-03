
using ChatApplication.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net.Http;

namespace ChatApplication
{

    public delegate ChatU MessageAlignInvoke();
    public delegate void NewMessageArrivedInvoke(Message message);

    public static class NetworkManager
    {

        public static string PcMacAddress = "";
        public static string ServerHostName = "Spare-A1";
        public static string PcHostName = "";
        public static string ServerIpAddress = "122.178.54.205";
        public static MessageAlignInvoke MessageAlignInvoke;
        public static NewMessageArrivedInvoke NewMessageArrivedInvoke;
        public static event EventHandler<Contact> OnlineStatusInvoke;
        private static TcpListener tcpListener;
        public static TcpClient server;
        public static string PcIpAddress;
        public static int PortNumber = 12345;
        public static Dictionary<string, TcpClient> NetworkStreamClientDictionary = new Dictionary<string, TcpClient>();
        public static string GetPcMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress().ToString();
                }
            }
            return "";
        }
        public static string GetPcIPAddress(string hostName)
        {
            try
            {
                IPAddress[] iparray = Dns.GetHostAddresses(hostName);
                foreach (IPAddress ip in iparray)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
            }
            catch { }
            return "";
        }
        public static async Task<string> GetPublicIpAddressAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync("http://api.ipify.org");
                    response.EnsureSuccessStatusCode();
                    string ipAddress = await response.Content.ReadAsStringAsync();
                    return ipAddress.Trim();
                }
                catch (Exception ex)
                {

                    return null;
                }
            }
        }
        public static void NetWorkSetUp()
        {
            PcHostName = Dns.GetHostName();
          //  string publicIpAddress = GetPublicIpAddressAsync().Result;
            PcIpAddress = GetPcIPAddress(PcHostName);
            ServerIpAddress = GetPcIPAddress(ServerHostName);
            PcMacAddress = GetPcMacAddress();
            Thread tread = new Thread(new ThreadStart(StartServerConnection));
            tread.Priority = ThreadPriority.Highest;
            tread.Start();
        }
        //Server Connection for recieve Request
        public static void StartServerConnection()
        {
            tcpListener = new TcpListener(IPAddress.Any, PortNumber);
            tcpListener.Start();
            AcceptClient();
        }
        private async static void AcceptClient()
        {
            TcpClient client = await tcpListener.AcceptTcpClientAsync();
            if (!NetworkStreamClientDictionary.ContainsKey(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString()))
            {
                NetworkStreamClientDictionary.Add(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString(), client);
                Contact contact = ContactsManager.getContactByIpAddress(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
                if (contact != null)
                {
                    contact.IsOnline = true;
                    OnlineStatusInvoke?.Invoke(new object(), contact);
                }

                HandleClient(client);
            }
            else
            {
                // HandleClient(client);
            }
            AcceptClient();
        }
        private async static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] numberOfBytes = new byte[5];
            int bytesRead = 100;
            while (true)
            {
                try
                {
                    Message msg = null;
                    await stream.ReadAsync(numberOfBytes, 0, 5);
                    int lengthOfData = Convert.ToInt32(Encoding.UTF8.GetString(numberOfBytes));
                    byte[] data = new byte[lengthOfData];
                    if ((bytesRead = await stream.ReadAsync(data, 0, lengthOfData)) > 0)
                    {
                        msg = JsonConvert.DeserializeObject<Message>(Encoding.UTF8.GetString(data));
                        if (!msg.IsFile)
                        {
                            if (msg.FromHostName != PcHostName && msg.MessageText != "")
                            {
                                msg.IsSent = true;
                                Message messageObj = MessagesManager.CreateMessage(msg);
                                NewMessageArrivedInvoke?.Invoke(messageObj);
                            }
                        }
                        else
                        {
                            byte[] fileData = new byte[msg.FileSize];
                            string filePath = Path.Combine(FilesManager.FileSaveDirectoryPath, Path.GetFileName(msg.FileName));
                            using (FileStream fileStream = File.Create(filePath))
                            {
                                while ((bytesRead = stream.Read(fileData, 0, fileData.Length)) > 0)
                                {
                                    fileStream.Write(fileData, 0, bytesRead);
                                    if (fileStream.Length >= msg.FileSize) break;
                                }
                            }
                            if (msg.FromHostName != PcHostName)
                            {
                                msg.IsSent = true;
                                filePath = filePath.Replace("\\", "/");
                                msg.FileName = filePath;
                                Message messageObj = MessagesManager.CreateMessage(msg);
                                NewMessageArrivedInvoke?.Invoke(messageObj);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (client != null)
                    {
                        Contact contact = ContactsManager.getContactByIpAddress(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
                        
                        contact.IsOnline = false;
                        OnlineStatusInvoke?.Invoke(new object(), contact);
                        NetworkStreamClientDictionary.Remove(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
                        break;
                    }
                }
            }

        }

        public static async Task MessageSent(Message message, Contact contact)
        {
            TcpClient server = null;
            if (!NetworkStreamClientDictionary.ContainsKey(contact.IpAddress))
            {
                server = new TcpClient();
                server.Connect(contact.IpAddress, PortNumber);
                HandleClient(server);
                NetworkStreamClientDictionary.Add(contact.IpAddress, server);
                contact.IsOnline = true;
                OnlineStatusInvoke?.Invoke(new object(), contact);
            }
            else
            {
                server = NetworkStreamClientDictionary[contact.IpAddress];
                if (!NetworkStreamClientDictionary[contact.IpAddress].GetStream().CanWrite)
                {
                    server.Connect(contact.IpAddress, PortNumber);
                    HandleClient(server);
                }
            }
            string msg = JsonConvert.SerializeObject(message);
            //if (!(server == null || !server.Connected))
            //{
            NetworkStream stream = server.GetStream();
            byte[] data = Encoding.ASCII.GetBytes(msg);
            byte[] numberOfBytes = new byte[5];
            byte[] Bytes = Encoding.UTF8.GetBytes("" + data.Length);
            Array.Copy(Bytes, numberOfBytes, Bytes.Length);
            stream.WriteAsync(numberOfBytes, 0, numberOfBytes.Length);
            stream.WriteAsync(data, 0, data.Length);
            //}
        }
        public static async Task FileSent(Message fileMessage, string filePath, Contact contact)
        {
            TcpClient server;
            if (!NetworkStreamClientDictionary.ContainsKey(contact.IpAddress))
            {
                server = new TcpClient();
                server.Connect(contact.IpAddress, PortNumber);
                HandleClient(server);
                NetworkStreamClientDictionary.Add(contact.IpAddress, server);
                contact.IsOnline = true;
                OnlineStatusInvoke?.Invoke(new object(), contact);
            }
            else
            {
                server = NetworkStreamClientDictionary[contact.IpAddress];
                if (!NetworkStreamClientDictionary[contact.IpAddress].GetStream().CanWrite) {
                    server.Connect(contact.IpAddress, PortNumber);
                    HandleClient(server);
                }
                   
            }
            NetworkStream stream = server.GetStream();
            string metadataJson = JsonConvert.SerializeObject(fileMessage);
            byte[] metadataBytes = Encoding.UTF8.GetBytes(metadataJson);
            byte[] numberOfBytes = new byte[5];
            byte[] Bytes = Encoding.UTF8.GetBytes("" + metadataBytes.Length);
            Array.Copy(Bytes, numberOfBytes, Bytes.Length);
            stream.Write(numberOfBytes, 0, numberOfBytes.Length);
            stream.Write(metadataBytes, 0, metadataBytes.Length);
            using (FileStream fileStream = File.OpenRead(filePath))
            {
                fileStream.CopyTo(stream);
            }
        }

        public static async Task ConnectToPC(Contact contact)
        {
            if (!NetworkStreamClientDictionary.ContainsKey(contact.IpAddress))
            {
                try
                {
                    TcpClient server = new TcpClient();
                    server.Connect(contact.IpAddress, PortNumber);
                    HandleClient(server);
                    if (!NetworkStreamClientDictionary.ContainsKey(contact.IpAddress))
                    {
                        NetworkStreamClientDictionary.Add(contact.IpAddress, server);
                        contact.IsOnline = true;
                        OnlineStatusInvoke?.Invoke(new object(), contact);
                    }

                }
                catch
                {
                    contact.IsOnline = false;
                    OnlineStatusInvoke?.Invoke(new object(), contact);
                }
            }
            else
            {
                contact.IsOnline = true;
                OnlineStatusInvoke?.Invoke(new object(), contact);
            }
        }
        public static bool IsPcOnline(string ipAddress, int port)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(ipAddress);
            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

