using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Manager
{
    public static class MessagesManager
    {
        public static Queue<Message> UnSentMessages = new Queue<Message>();
        public static List<Message> Message_List = new List<Message>();

        //Message Method


        public static Message CreateMessage(Message message)
        {
            var result = DatabaseManager.Manager.InsertData("MESSAGES", new ParameterData[] { new ParameterData("FROMHOSTNAME", message.FromHostName), new ParameterData("TOHOSTNAME", message.ToHostName), new ParameterData("GROUPID", message.GroupId), new ParameterData("DATEANDTIME", message.DateAndTime), new ParameterData("MESSAGE", message.MessageText), new ParameterData("ISSENT", message.IsSent == false ? 0 : 1), new ParameterData("ISFILE", message.IsFile == false ? 0 : 1), new ParameterData("FILENAME", message.FileName) });
            return GetMessage(message.FromHostName, message.ToHostName, message.DateAndTime);
        }
        public static bool DeleteMessage(int messageID)
        {
            var result = DatabaseManager.Manager.DeleteData("MESSAGES", $"MESSAGEID={messageID}");
            return result.Result;
        }
        public static bool DeleteMessageFromGroup(int groupID)
        {
            var result = DatabaseManager.Manager.DeleteData("MESSAGES", $"GROUPID={groupID}");
            return result.Result;
        }
        public static bool FilePathChange(int messageID, string filePath)
        {
            var result = DatabaseManager.Manager.UpdateData("MESSAGES", $"MESSAGEID={messageID}", new ParameterData("FILENAME", filePath), new ParameterData("MESSAGE", Path.GetFileName(filePath)));
            return result.Result;
        }
        public static List<Message> GetMessages(string hostName1, string hostName2)
        {
            var result = DatabaseManager.Manager.FetchData("MESSAGES", $"((FromHostName='{hostName1}' AND TOHOSTNAME='{hostName2}') OR (FromHostName='{hostName2}' AND TOHOSTNAME='{hostName1}'))AND GROUPID=0", orderBy: "DATEANDTIME");
            List<Message> temp_MessageList = new List<Message>();
            if (result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["MESSAGEID"].Count; i++)
                {
                    temp_MessageList.Add(new Message((int)result.Value["MESSAGEID"][i], result.Value["FromHostName"][i].ToString(), result.Value["TOHOSTNAME"][i].ToString(), (result.Value["GROUPID"][i] is DBNull) ? 0 : ((int)result.Value["GROUPID"][i]), (DateTime)result.Value["DATEANDTIME"][i], result.Value["MESSAGE"][i].ToString(), (bool)result.Value["ISSENT"][i], (bool)result.Value["ISFILE"][i], result.Value["FILENAME"][i].ToString()));
                }
            }
            return temp_MessageList;
        }
        public static List<Message> GetMessages(string hostName1, string hostName2, ref int MessageReadCount, ref bool IsAllMessagesReaded, int MessagesTakeCount)
        {
            List<Message> temp_List = new List<Message>();
            var result = DatabaseManager.Manager.FetchData("MESSAGES", $"((FROMHOSTNAME='{ hostName1}' AND TOHOSTNAME='{hostName2}') OR (FROMHOSTNAME='{hostName2}' AND TOHOSTNAME='{hostName1}'))AND GROUPID=0", MessageReadCount, MessagesTakeCount, orderBy: "DATEANDTIME DESC");
            if (result.Value != null && result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["MESSAGEID"].Count; i++)
                {
                    temp_List.Add(new Message((int)result.Value["MESSAGEID"][i], result.Value["FROMHOSTNAME"][i].ToString(), result.Value["TOHOSTNAME"][i].ToString(), (result.Value["GROUPID"][i] is DBNull) ? 0 : ((int)result.Value["GROUPID"][i]), (DateTime)result.Value["DATEANDTIME"][i], result.Value["MESSAGE"][i].ToString(), (bool)result.Value["ISSENT"][i], (bool)result.Value["ISFILE"][i], result.Value["FILENAME"][i].ToString()));
                }

                if (result.Value != null && result.Value["MESSAGEID"].Count < MessagesTakeCount)
                {
                    MessageReadCount = MessageReadCount + result.Value["MESSAGEID"].Count;
                    IsAllMessagesReaded = true;
                }
                else
                    MessageReadCount = MessageReadCount + MessagesTakeCount;
            }
            else
            {
                IsAllMessagesReaded = true;
            }
            return temp_List;
        }
        public static List<Message> GetMessages(int groupId, DateTime joinDateTime, ref int MessageReadCount, ref bool IsAllMessagesReaded, int MessagesTakeCount)
        {

            List<Message> temp_List = new List<Message>();
            var result = DatabaseManager.Manager.FetchData("MESSAGES", $"GROUPID={groupId} AND DATEANDTIME>='{joinDateTime.ToString("yyyy-MM-dd HH:mm:ss")}'", MessageReadCount, MessagesTakeCount, orderBy: "DATEANDTIME DESC");

            if (result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["MESSAGEID"].Count; i++)
                {
                    temp_List.Add(new Message((int)result.Value["MESSAGEID"][i], result.Value["FROMHOSTNAME"][i].ToString(), result.Value["TOHOSTNAME"][i].ToString(), (result.Value["GROUPID"][i] is DBNull) ? 0 : ((int)result.Value["GROUPID"][i]), (DateTime)result.Value["DATEANDTIME"][i], result.Value["MESSAGE"][i].ToString(), (bool)result.Value["ISSENT"][i], (bool)result.Value["ISFILE"][i], result.Value["FILENAME"][i].ToString()));
                }
                if (result.Value != null && result.Value["MESSAGEID"].Count < MessagesTakeCount)
                {
                    MessageReadCount = MessageReadCount + result.Value["MESSAGEID"].Count;
                    IsAllMessagesReaded = true;
                }
                else
                    MessageReadCount = MessageReadCount + MessagesTakeCount;
            }
            else
            {
                IsAllMessagesReaded = true;
            }
            return temp_List;
        }
        public static Message GetMessage(string hostName1, string hostName2, DateTime dateTime)
        {
            try
            {
                var result = DatabaseManager.Manager.FetchData("MESSAGES", $"(FROMHOSTNAME='{hostName1}' AND TOHOSTNAME='{hostName2}') AND (DATEANDTIME='{dateTime.ToString("yyyy-MM-dd HH:mm:ss")}')");
                return new Message((int)result.Value["MESSAGEID"][0], result.Value["FROMHOSTNAME"][0].ToString(), result.Value["TOHOSTNAME"][0].ToString(), (result.Value["GROUPID"][0] is DBNull) ? 0 : ((int)result.Value["GROUPID"][0]), (DateTime)result.Value["DATEANDTIME"][0], result.Value["MESSAGE"][0].ToString(), (bool)result.Value["ISSENT"][0], (bool)result.Value["ISFILE"][0], result.Value["FILENAME"][0].ToString());
            }
            catch
            {
                return null;
            }
        }
        public static Message GetMessage(string hostName, int groupId, DateTime dateTime)
        {
            try
            {
                var result = DatabaseManager.Manager.FetchData("MESSAGES", $"(FROMHOSTNAME='{hostName}' AND GROUP='{groupId}') AND (DATEANDTIME='{dateTime.ToString("yyyy-MM-dd HH:mm:ss")}')");
                return new Message((int)result.Value["MESSAGEID"][0], result.Value["FROMHOSTNAME"][0].ToString(), (result.Value["TOHOSTNAME"][0] is DBNull) ? "" : result.Value["GROUPID"][0].ToString(), (result.Value["GROUPID"][0] is DBNull) ? 0 : ((int)result.Value["GROUPID"][0]), (DateTime)result.Value["DATEANDTIME"][0], result.Value["MESSAGE"][0].ToString(), (bool)result.Value["ISSENT"][0], (bool)result.Value["ISFILE"][0], result.Value["FILENAME"][0].ToString());
            }
            catch
            {
                return null;
            }
        }
        public static List<Message> GetMessages(string hostName, int groupId)
        {
            var result = DatabaseManager.Manager.FetchData("MESSAGES", $"FROMHOSTNAME='{hostName}' AND GROUPIID={groupId}) ", fields: new string[] { "FROMHOSTNAME", "MESSAGE", "DATEANDTIME" }, orderBy: "DATEANDTIME");
            List<Message> temp_MessageList = new List<Message>();
            if (result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["MESSAGEID"].Count; i++)
                {
                    temp_MessageList.Add(new Message((int)result.Value["MESSAGEID"][i], result.Value["FROMHOSTNAME"][i].ToString(), (result.Value["TOHOSTNAME"][0] is DBNull) ? "" : result.Value["GROUPID"][0].ToString(), (result.Value["GROUPID"][i] is DBNull) ? 0 : ((int)result.Value["GROUPID"][i]), (DateTime)result.Value["DATEANDTIME"][i], result.Value["MESSAGE"][i].ToString(), (bool)result.Value["ISSENT"][i], (bool)result.Value["ISFILE"][i], result.Value["FILENAME"][i].ToString()));
                }
            }
            return temp_MessageList;
        }
        public static void UpdateIsSent(Message message)
        {
            try
            {
                var result = DatabaseManager.Manager.UpdateData("MESSAGES", $"MESSAGEID={message.MessageId}", new ParameterData("ISSENT", true));
            }
            catch
            {

            }
        }
        public static Message GetLastSentedMessage(string FromHostName, string ToHostName)
        {
            try
            {
                var result = DatabaseManager.Manager.FetchData("MESSAGES", $"((FROMHOSTNAME = '{FromHostName}' AND TOHOSTNAME = '{ToHostName} ') OR (FROMHOSTNAME = '{ToHostName}' AND TOHOSTNAME = '{FromHostName} ') )AND GROUPID=0", orderBy: "MESSAGEID DESC");
                return new Message((int)result.Value["MESSAGEID"][0], result.Value["FROMHOSTNAME"][0].ToString(), (result.Value["TOHOSTNAME"][0] is DBNull) ? "" : result.Value["GROUPID"][0].ToString(), (result.Value["GROUPID"][0] is DBNull) ? 0 : ((int)result.Value["GROUPID"][0]), (DateTime)result.Value["DATEANDTIME"][0], result.Value["MESSAGE"][0].ToString(), (bool)result.Value["ISSENT"][0], (bool)result.Value["ISFILE"][0], result.Value["FILENAME"][0].ToString());
            }
            catch
            {
                return null;
            }
        }
        public static Message GetLastSentedMessage(int groupId)
        {
            try
            {
                var result = DatabaseManager.Manager.FetchData("MESSAGES", $"GROUPID={groupId}", orderBy: "MESSAGEID DESC");
                return new Message((int)result.Value["MESSAGEID"][0], result.Value["FROMHOSTNAME"][0].ToString(), (result.Value["TOHOSTNAME"][0] is DBNull) ? "" : result.Value["GROUPID"][0].ToString(), (result.Value["GROUPID"][0] is DBNull) ? 0 : ((int)result.Value["GROUPID"][0]), (DateTime)result.Value["DATEANDTIME"][0], result.Value["MESSAGE"][0].ToString(), (bool)result.Value["ISSENT"][0], (bool)result.Value["ISFILE"][0], result.Value["FILENAME"][0].ToString());
            }
            catch
            {
                return null;
            }
        }
        //UNSENTMESSAGES 
        public static List<Message> GetUnSentMessages()
        {
            var result = DatabaseManager.Manager.FetchData("MESSAGES", $"ISSENT={false} AND GROUPID={0}", orderBy: "DATEANDTIME");
            List<Message> temp_MessageList = new List<Message>();

            try
            {
                if (result.Value.Count > 0)
                {
                    for (int i = 0; i < result.Value["MESSAGEID"].Count; i++)
                    {
                        temp_MessageList.Add(new Message((int)result.Value["MESSAGEID"][i], result.Value["FROMHOSTNAME"][i].ToString(), result.Value["TOHOSTNAME"][i].ToString(), (result.Value["GROUPID"][i] is DBNull) ? 0 : ((int)result.Value["GROUPID"][i]), (DateTime)result.Value["DATEANDTIME"][i], result.Value["MESSAGE"][i].ToString(), (bool)result.Value["ISSENT"][i], false, ""));
                    }
                }
            }
            catch
            {

            }
            return temp_MessageList;
        }
        //UNSENTGROUPMESSAGES 
        public static bool CreateUnSentGroupMessage(Message message)
        {
            var result = DatabaseManager.Manager.InsertData("UNSENTGROUPMESSAGES", new ParameterData[] { new ParameterData("MESSAGEID", message.MessageId), new ParameterData("FROMHOSTNAME", message.FromHostName), new ParameterData("TOHOSTNAME", message.ToHostName), new ParameterData("GROUPID", message.GroupId), new ParameterData("DATEANDTIME", message.DateAndTime), new ParameterData("MESSAGE", message.MessageText), new ParameterData("ISSENT", message.IsSent == false ? 0 : 1) });

            return result.Result;
        }
        public static bool DeleteUnSentGroupMessage(Message message)
        {
            var result = DatabaseManager.Manager.DeleteData("UNSENTGROUPMESSAGES", $"MESSAGEID={message.MessageId} AND TOHOSTNAME='{message.ToHostName}' AND GROUPID={message.GroupId}");
            return result.Result;
        }
        public static List<Message> GetUnSentGroupMessages()
        {
            var result = DatabaseManager.Manager.FetchData("UNSENTGROUPMESSAGES", "GroupID>0", orderBy: "DATEANDTIME");
            List<Message> temp_MessageList = new List<Message>();
            try
            {
                if (result.Value.Count > 0)
                {
                    for (int i = 0; i < result.Value["MESSAGEID"].Count; i++)
                    {
                        temp_MessageList.Add(new Message((int)result.Value["MESSAGEID"][i], result.Value["FROMHOSTNAME"][i].ToString(), result.Value["TOHOSTNAME"][i].ToString(), (result.Value["GROUPID"][i] is DBNull) ? 0 : ((int)result.Value["GROUPID"][i]), (DateTime)result.Value["DATEANDTIME"][i], result.Value["MESSAGE"][i].ToString(), (bool)result.Value["ISSENT"][i], false, ""));
                    }
                }
            }
            catch
            {

            }
            return temp_MessageList;
        }
        public static bool IsUnSentGroupMessage(Message message)
        {
            var result = DatabaseManager.Manager.ValueExists("UNSENTGROUPMESSAGES", "MESSAGAEID", "" + message.MessageId);
            return result.Result;
        }
        public static bool DeleteAllMessage(string ipAddress1, string ipAddress2)
        {
            var result = DatabaseManager.Manager.DeleteData("MESSAGES", $"((FROMHOSTNAME='{ipAddress1}' AND TOHOSTNAME='{ipAddress2}') OR (FROMHOSTNAME='{ipAddress2}' AND TOHOSTNAME='{ipAddress1}'))AND GROUPID=0", orderBy: "DATEANDTIME");

            return result.Result;
        }
        public static bool DeleteAllMessage(int GroupId)
        {
            var result = DatabaseManager.Manager.DeleteData("MESSAGES", $"GROUPID={GroupId}");

            return result.Result;
        }
        public static bool DeleteAllMessagesInDataBase()
        {
            var result = DatabaseManager.Manager.TruncateTable("MESSAGES");
            return result.Result;
        }
        public static Message CreateMessageAndGetMessage(string fromIpAddress, string toIpAddress, DateTime dateAndTime, string message)
        {
            var result = DatabaseManager.Manager.InsertData("MESSAGES", new ParameterData[] { new ParameterData("FROMHOSTNAME", fromIpAddress), new ParameterData("TOHOSTNAME", toIpAddress), new ParameterData("DATEANDTIME", dateAndTime), new ParameterData("MESSAGE", message), new ParameterData("ISSENT", 1) });
            return GetMessage(fromIpAddress, toIpAddress, dateAndTime);
        }
    }
}
