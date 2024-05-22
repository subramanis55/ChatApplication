using ChatApplication.Manager;

using DatabaseLibrary;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    internal class DatabaseManager
    {
        public static DatabaseLibrary.DatabaseManager Manager = new MySqlHandler();
        public static bool IsConnectedToServer;
        public static string LocalDataBaseName = "ChatApplication";
        public static string ServerDataBaseName = "ChatApplication";
        public static string LocalDataBasePassword = "";
        public static string ServerDataBasePassword = "";
        public static bool DataBaseSetUp()
        {
            DefaultDatabaseCreateConnection();
            SetPermissionToAll();
            // database create
            if (IsDataBaseExists(LocalDataBaseName))
            {
                DatabaseManager.ChatApplicationLocalConnection();
            }
            else
            {
                CreateDataBase(LocalDataBaseName);
                DatabaseManager.ChatApplicationLocalConnection();
            }
            if (Manager.IsConnected)
            {
                if (!IsTableExists("CONTACTS"))
                {
                    CreateContactsTable();
                }
                if (!IsTableExists("MESSAGES"))
                {
                    CreateMessagesTable();
                }
                if (!IsTableExists("GROUPS"))
                {
                    CreateGroupsTable();
                }
                if (!IsTableExists("GROUPMEMBERS"))
                {
                    CreateGroupMembersTable();
                }
                if (!IsTableExists("UNSENTGROUPMESSAGE"))
                {
                    CreateUnsentGroupMessagesTable();
                }
                if (!IsTableExists("SETTING"))
                    CreateSettingTable();

                return true;
            }
            else
            {
                SettingManager.notificationThrowManager.CreateNotification("Data base Connection fail!", NotificationType.Information);
                return false;
            }
        }
        public static void SetPermissionToAll()
        {
            Manager.ExecuteNonQuery(new MySqlCommand("GRANT ALL PRIVILEGES ON *.* TO 'root'@'%' IDENTIFIED BY '' WITH GRANT OPTION;"));
        }
        public static void DataBaseTablesUpdateFromServer()
        {
            if (NetworkManager.ServerHostName != NetworkManager.PcHostName)
            {
                UpdateServerContactsInPcDatabase();
                UpdateServerGroupsInPcDatabase();
            }
        }
        public static bool UpdateServerContactsInPcDatabase()
        {
            if (ChatApplicationServerConnection())
            {
                List<Contact> ContactList = ContactsManager.GetContactsFromServer();

                if (DatabaseManager.ChatApplicationLocalConnection())
                {
                    if (ContactList.Count > 0)
                    {
                        // TruncateTable("CONTACTS");
                        ContactsManager.UpdateContactDetailsFromServer(ContactList);
                        return true;
                    }
                }
            }
            else
            {
                SettingManager.notificationThrowManager.CreateNotification("Server not respond for update\n contact!", NotificationType.Information);
                DatabaseManager.ChatApplicationLocalConnection();
            }
            return false;
        }
        public static bool UpdateServerGroupsInPcDatabase()
        {
            if (ChatApplicationServerConnection())
            {
                List<Group> GroupList = GroupsManager.GetGroupsFromServer();
                if (DatabaseManager.ChatApplicationLocalConnection())
                {
                    GroupsManager.UpdateGroupsDetailsFromServer(GroupList);
                    return true;
                }
            }
            else
            {

                DatabaseManager.ChatApplicationLocalConnection();
            }
            return false;
        }
        public static bool ChatApplicationServerConnection()
        {

            var result = Manager.ChangeConnection($"{NetworkManager.ServerIpAddress}", "root", ServerDataBasePassword, ServerDataBaseName);
            Manager.Connect();
            if (result.Result)
                IsConnectedToServer = true;
            return result.Result;
        }
        public static bool ChatApplicationLocalConnection()
        {
            var result = Manager.ChangeConnection($"localhost", "root", LocalDataBasePassword, LocalDataBaseName);
            Manager.Connect();
            if (result.Result)
                IsConnectedToServer = false;
            return result.Result;
        }
        public static bool DefaultDatabaseCreateConnection()
        {
            var result = Manager.ChangeConnection($"localhost", "root", LocalDataBasePassword, "mysql");
            Manager.Connect();
            if (result.Result)
                IsConnectedToServer = false;
            return result.Result;
        }
        public static bool DatabaseChangeConnection(string dataBaseName)
        {
            var result = Manager.ChangeConnection($"localhost", "root", LocalDataBasePassword, dataBaseName);
            if (result.Result)
                IsConnectedToServer = false;
            return result.Result;
        }

        //Create DataBase
        public static bool CreateDataBase(string name)
        {
            var result = Manager.CreateDatabase(name);
            return result.Result;
        }
        public static bool IsDataBaseExists(string DataBaseName)
        {
            var result = Manager.DatabaseExists(DataBaseName);
            return result.Result;
        }

        // Create Tables
        public static bool IsTableExists(string TableName)
        {
            var result = Manager.TableExists(TableName);
            return result.Result;
        }
        public static bool CreateMessagesTable()
        {
            // string query = "CREATE TABLE MESSAGES(MESSAGEID INT PRIMARY KEY AUTO_INCREMENT,FROMIPADDRESS VARCHAR(50),TOIPADDRESS VARCHAR(50),GROUPID INT,DATEANDTIME DATETIME,MESSAGE VARCHAR(1500),ISSENT VARCHAR(10));";
            //var result = Manager.ExecuteNonQuery(new MySqlCommand(query));
            var result = Manager.CreateTable("MESSAGES", new ColumnDetails[]{ new ColumnDetails("MESSAGEID",BaseDatatypes.INT,notNull:true,isAutoIncrement:true), new ColumnDetails("FROMHOSTNAME", BaseDatatypes.VARCHAR,length:50,notNull:false),new ColumnDetails("TOHOSTNAME", BaseDatatypes.VARCHAR,length:50,notNull:false), new ColumnDetails("GROUPID", BaseDatatypes.INT,notNull:false)
      , new ColumnDetails("DATEANDTIME", BaseDatatypes.DATETIME), new ColumnDetails("MESSAGE", BaseDatatypes.VARCHAR,length:10000), new ColumnDetails("ISSENT", BaseDatatypes.BOOLEAN),new ColumnDetails("ISFILE", BaseDatatypes.BOOLEAN,defaultValue:"0"),new ColumnDetails("FILENAME", BaseDatatypes.VARCHAR,length:500,defaultValue:"") });
            return result.Result;
        }
        public static bool CreateStaredMessagesTable()
        {
            // string query = "CREATE TABLE MESSAGES(MESSAGEID INT PRIMARY KEY AUTO_INCREMENT,FROMIPADDRESS VARCHAR(50),TOIPADDRESS VARCHAR(50),GROUPID INT,DATEANDTIME DATETIME,MESSAGE VARCHAR(1500),ISSENT VARCHAR(10));";
            //var result = Manager.ExecuteNonQuery(new MySqlCommand(query));
            var result = Manager.CreateTable("MESSAGES", new ColumnDetails[]{ new ColumnDetails("MESSAGEID",BaseDatatypes.INT,notNull:true), new ColumnDetails("FROMHOSTNAME", BaseDatatypes.VARCHAR,length:50,notNull:false),new ColumnDetails("TOHOSTNAME", BaseDatatypes.VARCHAR,length:50,notNull:false), new ColumnDetails("GROUPID", BaseDatatypes.INT,notNull:false)
      , new ColumnDetails("DATEANDTIME", BaseDatatypes.DATETIME), new ColumnDetails("MESSAGE", BaseDatatypes.VARCHAR,length:10000), new ColumnDetails("ISSENT", BaseDatatypes.BOOLEAN),new ColumnDetails("ISFILE", BaseDatatypes.BOOLEAN,defaultValue:"0"),new ColumnDetails("FILENAME", BaseDatatypes.VARCHAR,length:500,defaultValue:"") });
            return result.Result;
        }
        public static bool CreateUnsentGroupMessagesTable()
        {
            var result = Manager.CreateTable("UNSENTGROUPMESSAGES", new ColumnDetails[]{ new ColumnDetails("MESSAGEID",BaseDatatypes.INT,notNull:true,isAutoIncrement:false),new ColumnDetails("FROMHOSTNAME", BaseDatatypes.VARCHAR,length:50,notNull:false),new ColumnDetails("TOHOSTNAME", BaseDatatypes.VARCHAR,length:50,notNull:false), new ColumnDetails("GROUPID", BaseDatatypes.INT,notNull:false)
           , new ColumnDetails("DATEANDTIME", BaseDatatypes.DATETIME), new ColumnDetails("MESSAGE", BaseDatatypes.VARCHAR,length:10000), new ColumnDetails("ISSENT", BaseDatatypes.BOOLEAN) });
            return result.Result;
        }
        public static bool CreateSettingTable()
        {
            var result = Manager.CreateTable("SETTING", new ColumnDetails[] { new ColumnDetails("CHATPAGEBACKGROUNDCOLOR", BaseDatatypes.VARCHAR, length: 20), new ColumnDetails("THEMENUMBER", BaseDatatypes.INT, notNull: true), new ColumnDetails("MUTETHEMESSAGENOTIFICATION", BaseDatatypes.BOOLEAN, notNull: true) });
            SettingManager.InsertSettingValues(Color.FromArgb(250, 246, 243), 0);
            return result.Result;
        }
        public static bool CreateContactsTable()
        {
            string query = "CREATE TABLE CONTACTS( MACADDRESS VARCHAR(50) ,HOSTNAME VARCHAR(50) PRIMARY KEY,IPADDRESS VARCHAR(50) ,FIRSTNAME VARCHAR(50),LASTNAME VARCHAR(50),DPPICTURE VARCHAR(55000),LASTONLINETIME DATETIME,NEWMESSAGECOUNT INT,ISARCHIVED TINYINT);";
            var result = Manager.ExecuteNonQuery(new MySqlCommand(query));
            return result.Result;
        }
        public static bool CreateGroupsTable()
        {
            string query = "CREATE TABLE GROUPS (GROUPID INT PRIMARY KEY AUTO_INCREMENT, GROUPNAME VARCHAR(40),DPPICTURE VARCHAR(55000),ADMINHOSTNAME VARCHAR(50),NEWMESSAGECOUNT INT,ISARCHIVED TINYINT,CREATEDDATEANDTIME DATETIME);";
            var result = Manager.ExecuteNonQuery(new MySqlCommand(query));
            return result.Result;
        }
        public static bool CreateGroupMembersTable()
        {
            string query = "CREATE TABLE GROUPMEMBERS(GROUPID INT, HOSTNAME VARCHAR(50),JOINDATE DATETIME,FOREIGN KEY(GROUPID) REFERENCES GROUPS(GROUPID));";
            var result = Manager.ExecuteNonQuery(new MySqlCommand(query));
            return result.Result;
        }
        public static bool TruncateTable(string tableName)
        {
            var result = Manager.ExecuteNonQuery(new MySqlCommand($"DELETE FROM {tableName}"));
            return result.Result;
        }

    }
}
