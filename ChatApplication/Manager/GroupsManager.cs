using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.Manager
{
    public static class GroupsManager
    {
        public static List<Group> Groups_List;
        public static Group CurrentGroup;
        public static void GroupsManagerSetUp()
        {
            Groups_List = GetGroups();
        }
        //Group Method
        public static bool CreateGroup(Group group)
        {
            var result = DatabaseManager.Manager.InsertData("GROUPS", new ParameterData("GROUPID", group.GroupID), new ParameterData("GROUPNAME", group.GroupName), new ParameterData("DPPICTURE", group.DpPicture), new ParameterData("ADMINHOSTNAME", group.AdminHostName), new ParameterData("NEWMESSAGECOUNT", group.NewMessageCount), new ParameterData("ISARCHIVED", group.IsArchived), new ParameterData("CREATEDDATEANDTIME", group.CreatedDateAndTime));
            for (int i = 0; i < group.GroupMembers.Count; i++)
            {
                CreateGroupMember(group.GroupID, group.GroupMembers[i].Contact.HostName, group.GroupMembers[i].JoinDate);
            }
            return result.Result;
        }
        public static bool CreateGroupInServerDatabase(Group group)
        {
            var result = DatabaseManager.Manager.InsertData("GROUPS", new ParameterData("GROUPNAME", group.GroupName), new ParameterData("DPPICTURE", group.DpPicture), new ParameterData("ADMINHOSTNAME", group.AdminHostName), new ParameterData("NEWMESSAGECOUNT", group.NewMessageCount), new ParameterData("ISARCHIVED", group.IsArchived), new ParameterData("CREATEDDATEANDTIME", group.CreatedDateAndTime));
            int groupID = GetGroupID(group.GroupName, group.CreatedDateAndTime);
            for (int i = 0; i < group.GroupMembers.Count; i++)
            {
                CreateGroupMember(groupID, group.GroupMembers[i].Contact.HostName, group.GroupMembers[i].JoinDate);
            }
            return result.Result;
        }
        public static bool GroupExitsInDatabase(int groupId)
        {
            var result = DatabaseManager.Manager.ValueExists("GROUPS", "GROUPID", "" + groupId);
            return result.Result;
        }
        public static bool UpdateGroup(Group group)
        {
            var result = DatabaseManager.Manager.UpdateData("GROUPS", $"GROUPID='{group.GroupID}'", new ParameterData("GROUPNAME", group.GroupName), new ParameterData("DPPICTURE", group.DpPicture), new ParameterData("ADMINHOSTNAME", group.AdminHostName));
            DatabaseManager.Manager.DeleteData("GROUPMEMBERS", $"GROUPID={group.GroupID}");
            for (int i = 0; i < group.GroupMembers.Count; i++)
            {
                CreateGroupMember(group.GroupID, group.GroupMembers[i].Contact.HostName, group.GroupMembers[i].JoinDate);
            }
            return result.Result;
        }
        public static void UpdateGroupsDetailsFromServer(List<Group> groupsList)
        {
            for (int i = 0; i < groupsList.Count; i++)
            {
                groupsList[i].NewMessageCount = 0;
                groupsList[i].IsArchived = false;
                if (DatabaseManager.Manager.ValueExists("GROUPS", "GROUPID", groupsList[i].GroupID + ""))
                {
                    UpdateGroup(groupsList[i]);
                }
                else
                {
                    CreateGroup(groupsList[i]);
                }

            }
        }
        public static int GetGroupID(string groupName, DateTime createdDateAndTime)
        {
            var result = DatabaseManager.Manager.FetchSingleData("GROUPS", "GROUPID", $"GROUPNAME='{groupName}' AND CREATEDDATEANDTIME='{createdDateAndTime.ToString("yyyy-MM-dd HH:mm:ss")}'");
            return Convert.ToInt32(result.Value.ToString());
        }
        public static string GetGroupName(int groupID)
        {
            var result = DatabaseManager.Manager.FetchSingleData("GROUPS", "GROUPNAME", $"GROUPID={groupID}");
            return result.Value.ToString();
        }
        public static bool ChangeIsArchived(int groupId, bool isArchived)
        {
            var result = DatabaseManager.Manager.UpdateData("GROUPS", $"GROUPID='{groupId}'", new ParameterData("ISARCHIVED", isArchived));
            return result.Result;
        }
        public static bool ChangeGroupName(int groupId, string groupName)
        {
            var result = DatabaseManager.Manager.UpdateData("GROUPS", $"GROUPID='{groupId}'", new ParameterData("GROUPNAME", groupName));
            return result.Result;
        }
        public static bool DeleteGroup(int groupID)
        {
            var result = DatabaseManager.Manager.DeleteData("GROUPS", $"GROUPID={groupID}");
            MessagesManager.DeleteMessageFromGroup(groupID);
            DatabaseManager.Manager.DeleteData("GROUPMEMBERS", $"GROUPID={groupID}");

            return result.Result;
        }
        public static List<Group> GetGroupsFromServer()
        {
            var result = DatabaseManager.Manager.FetchData("GROUPMEMBERS", $"HOSTNAME ='{NetworkManager.PcHostName}'");
            List<Group> temp_Grouplist = new List<Group>();
            if (result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["GROUPID"].Count; i++)
                {
                    temp_Grouplist.Add(GetGroupFromServer(Convert.ToInt32(result.Value["GROUPID"][i].ToString())));
                }
            }
            return temp_Grouplist;
        }
        public static Group GetGroupFromServer(int groupId)
        {
            var result = DatabaseManager.Manager.FetchData("GROUPS", $"GROUPID={groupId}");
            return new Group((int)result.Value["GROUPID"][0], result.Value["GROUPNAME"][0].ToString(), result.Value["DPPICTURE"][0].ToString(), result.Value["ADMINHOSTNAME"][0].ToString(), (int)result.Value["NEWMESSAGECOUNT"][0], Convert.ToBoolean(result.Value["ISARCHIVED"][0]), (DateTime)result.Value["CREATEDDATEANDTIME"][0], GetGroupMembersFromServer((int)result.Value["GROUPID"][0]));
        }
        public static Group GetGroupFromLocalDataBase(int groupId)
        {
            var result = DatabaseManager.Manager.FetchData("GROUPS", $"GROUPID={groupId}");
            return new Group((int)result.Value["GROUPID"][0], result.Value["GROUPNAME"][0].ToString(), FilesManager.SaveFilesInDirectoryFolder(FilesManager.FilesPath_D["GROUPSDPPICTURE"], result.Value["GROUPNAME"][0].ToString() + "-" + ((DateTime)result.Value["CREATEDDATEANDTIME"][0]).ToString("yyyyMMddHHmmssfff"), result.Value["DPPICTURE"][0].ToString()), result.Value["ADMINHOSTNAME"][0].ToString(), (int)result.Value["NEWMESSAGECOUNT"][0], Convert.ToBoolean(result.Value["ISARCHIVED"][0]), (DateTime)result.Value["CREATEDDATEANDTIME"][0], GetGroupMembers((int)result.Value["GROUPID"][0]));
        }
        public static List<Group> GetGroups()
        {
            var result = DatabaseManager.Manager.FetchData("GROUPMEMBERS", $"HOSTNAME ='{NetworkManager.PcHostName}'");
            List<Group> temp_Grouplist = new List<Group>();
            if (result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["GROUPID"].Count; i++)
                {
                    temp_Grouplist.Add(GetGroupFromLocalDataBase(Convert.ToInt32(result.Value["GROUPID"][i].ToString())));
                }
            }
            return temp_Grouplist;
        }

        //GroupMember Method  
        public static List<GroupMember> GetGroupMembersFromServer(int groupID)
        {
            var result = DatabaseManager.Manager.FetchData("GROUPMEMBERS", $"GROUPID={groupID}");
            List<GroupMember> temp_MemberList = new List<GroupMember>();
            if (result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["GROUPID"].Count; i++)
                {
                    temp_MemberList.Add(new GroupMember((DateTime)result.Value["JOINDATE"][i], ContactsManager.getContactFromServerDatabase(result.Value["HOSTNAME"][i].ToString())));
                }
            }

            return temp_MemberList;
        }
        public static bool CreateGroupMember(int groupID, string hostName, DateTime joinDate)
        {
            var result = DatabaseManager.Manager.InsertData("GROUPMEMBERS", new ParameterData[] { new ParameterData("HOSTNAME", hostName), new ParameterData("GROUPID", groupID), new ParameterData("JOINDATE", joinDate) });
            return result.Result;
        }
        public static bool DeleteGroupMember(int groupID, string hostName)
        {
            var result = DatabaseManager.Manager.DeleteData("GROUPMEMBERS", $"GROUPID={groupID} AND HOSTNAME='{hostName}'");
            return result.Result;
        }
        public static GroupMember GetGroupMember(int groupID, string hostName)
        {
            var result = DatabaseManager.Manager.FetchData("GROUPMEMBERS", $"GROUPID={groupID} AND HOSTNAME='{hostName}'");

            return new GroupMember((DateTime)result.Value["JOINDATE"][0], ContactsManager.getContactInList(result.Value["HOSTNAME"][0].ToString()));
        }
        public static bool UpdateGroupAdminHostname(int groupId, string adminHostName)
        {
            var result = DatabaseManager.Manager.UpdateData("GROUPS", $"GROUPID={groupId}", new ParameterData("ADMINHOSTNAME", adminHostName));
            return result.Result;
        }
        public static List<GroupMember> GetGroupMembers(int groupID)
        {
            var result = DatabaseManager.Manager.FetchData("GROUPMEMBERS", $"GROUPID={groupID}");
            List<GroupMember> temp_MemberList = new List<GroupMember>();
            if (result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["GROUPID"].Count; i++)
                {
                    temp_MemberList.Add(new GroupMember((DateTime)result.Value["JOINDATE"][i], ContactsManager.getContactInList(result.Value["HOSTNAME"][i].ToString())));
                }
            }

            return temp_MemberList;
        }
        public static bool ChangeNewMessageCount(int groupId, int newMessageCount)
        {
            var result = DatabaseManager.Manager.UpdateData("GROUPS", $"GROUPID='{groupId}'", new ParameterData("NEWMESSAGECOUNT", newMessageCount));
            return result.Result;
        }
        public static bool ChangeGroupDppicture(int groupId,string dpPictureStringFormat)
        {
            var result = DatabaseManager.Manager.UpdateData("GROUPS", $"GROUPID={groupId}", new ParameterData("DPPICTURE", dpPictureStringFormat));
            return result.Result;
        }
    }
}
