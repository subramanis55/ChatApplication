using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class Group
    {
        public string GroupName{
            set;
            get;
        }
        public int GroupID{
            set;
            get;
        }
        public DateTime CreatedDateAndTime
        {
            set;
            get;
        }
        public string DpPicture 
        {
            set;
            get;
        }
        public string AdminHostName{
            set;
            get;
        }
        public int NewMessageCount
        {
            set;
            get;
        }
        public bool IsArchived
        {
            set;
            get;
        }
        public List<GroupMember> GroupMembers;
        public Group(int groupID,string groupName,string dpPicture,string adminHostName, int newMessagecount, bool isArchived,DateTime createdDateAndTime,List<GroupMember> groupMembers)
        {
            GroupName = groupName;
            GroupID = groupID;
            DpPicture = dpPicture;
            GroupMembers = groupMembers;
            AdminHostName = adminHostName;
            NewMessageCount = newMessagecount;
            IsArchived = isArchived;
            CreatedDateAndTime = createdDateAndTime;
        }
        public Group(){

        }
    }
}
