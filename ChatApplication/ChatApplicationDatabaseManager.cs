using DatabaseLibrary;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    internal class ChatApplicationDatabaseManager
    {
        public static DatabaseManager Manager;
        public static bool DatabaseConnection()
        {

            Manager = new MySqlHandler("192.168.3.50", "root", "$uppu424*", "chatApplication");
            var result = Manager.Connect();
            if (result.Result == true)
            {
                return result.Result;
            }
            return false;
        }
        // contact Method
        public static bool ContactCreate(string firstName,string lastName,string ipAddress) {
          
          var result= Manager.InsertData("CONTACT", new ParameterData[] {new ParameterData("FIRSTNAME",firstName),new ParameterData("LASTNAME",lastName),new ParameterData("IPADDRESS", ipAddress) });
            return result.Result;
        }
        public static bool ChangeContactName(int contactID,string firstName, string lastName)
        {
            var result = Manager.UpdateData("CONTACT", $"CONTACTID={contactID}", new ParameterData[] { new ParameterData("FIRSTNAME", firstName), new ParameterData("LASTNAME", lastName) });
            return result.Result;
        }
        public static string GetContactFirstname(string ipAddress)
        {
           var result= Manager.FetchSingleData("CONTACT", "FIRSTNAME", $"IPADDRESS='{ipAddress}'");

            return ""+result.Value; 
        }
        public static string GetContactID(string ipAddress)
        {
            var result = Manager.FetchSingleData("CONTACT", "CONTACTID", $"IPADDRESS='{ipAddress}'");

            return "" + result.Value;
        }
        public static string GetIpAddress(int contactId)
        {
            var result = Manager.FetchData("CONTACT", $"CONTACTID='{contactId}'");
            return result.Value["IPADDRESS"][0].ToString();
        }

        //Message Method
        public static bool CreateMessage(int fromID,int toID,DateTime dateAndTime,string message,string isGroup)
        {
            var result = Manager.InsertData("MESSAGE", new ParameterData[] { new ParameterData("FROMID", fromID), new ParameterData("TOID", toID), new ParameterData("DATEANDTIME", dateAndTime), new ParameterData("MESSAGETEXT", message), new ParameterData("ISGROUP", isGroup) });
            return result.Result;
        } 
        public static bool DeleteMessage(int messageID)
        {
            var result = Manager.DeleteData("MESSAGE", $"WHERE={messageID}");
            return result.Result;
        }

        public static Dictionary<string,List<object>> GetMessage(int fromId,int toID,string isGroup)
        {
            var result = Manager.FetchData("MESSAGE", $"FROMID={fromId} AND TOID={toID} AND ISGROUP='{isGroup}'",fields:new string[]{ "MESSAGETEXT","DATEANDTIME"});
            return result.Value;
        }
        
        //Group Method
        public static bool CreateGroup(string groupName)
        {
            var result = Manager.InsertData("GROUPS", new ParameterData[] { new ParameterData("GROUPNAME", groupName) });
            return result.Result;
        }
        public static int GetGroupID(string groupName)
        {
            var result = Manager.FetchSingleData("GROUPS", "GROUPID",$"GROUPNAME={groupName}");
            return Convert.ToInt32(result.Value.ToString());
        }
        public static string GetGroupName(string groupID)
        {
            var result = Manager.FetchSingleData("GROUPS", "GROUPNAME", $"GROUPID={groupID}");
            return result.Value.ToString();
        }
        public static bool DeleteGroup(int groupID)
        {
            var result = Manager.DeleteData("GROUPS",$"GROUPID={groupID}");
             Manager.DeleteData("GROUPMEMBER", $"GROUPID={groupID}");
          
            return result.Result;
        }
        public static bool DeleteGroup(string groupName)
        {
            var result = Manager.DeleteData("GROUPS", $"GROUPNAME={groupName}");
            return result.Result;
        }

        //GroupMember Method
        public static Dictionary<string, List<object>> GetGroupMembers(int groupID)
        {
            var result = Manager.FetchData("GROUPMEMBER", $"GROUPID={groupID}");
            return result.Value;
        }
        public static bool CreateGroupMember(int contactID,int groupID,DateTime dateAndTime,string isLeft)
        {
            var result = Manager.InsertData("GROUPMEMBER", new ParameterData[] { new ParameterData("CONTACTID", contactID), new ParameterData("GROUPID", groupID),new ParameterData("JOINEDDATEANDTIME", dateAndTime),new ParameterData("ISLEFT",isLeft)});
            return result.Result;
        }
        public static bool ISGROUPMEMBER(int contactID, int groupID)
        {
            var result=Manager.FetchData("GROUPMEMBER", $"GROUPID={groupID} AND CONTACTID={contactID}");
            if (result.Value.Count > 0)
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
