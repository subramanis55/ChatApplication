using ChatApplication.Manager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            NetworkManager.NetWorkSetUp();
            DatabaseManager.DataBaseSetUp();
            DatabaseManager.DataBaseTablesUpdateFromServer();
            SettingManager.SettingSetUP();
            FilesManager.SetUp();
           // DatabaseManager.ChatApplicationServerConnection();           
            if (ContactsManager.IsContactExists(NetworkManager.PcHostName))
            {
                DatabaseManager.ChatApplicationLocalConnection();
                ContactsManager.ContactManagerSetup();
                GroupsManager.GroupsManagerSetUp();

                if (DatabaseManager.Manager.IsConnected)
                {                          
                    Application.Run(new MainForm());
                }
               else{
                    Application.Exit();
                }            
            }
            else
            {
                Application.Run(new LoginForm());          
            }        
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
