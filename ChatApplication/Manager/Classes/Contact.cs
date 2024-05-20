using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class Contact
    {

        public string MacAddress
        {
            set;
            get;
        }
        public string HostName
        {
            set;
            get;
        }
        public string IpAddress
      {
            set;
            get;
     }
     public string FirstName
        {
            set;
            get;
        }
     public string LastName
        {
            set;
            get;
        }
       
        public string DpPicture
        { 
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
        public DateTime LastOnlineTime
        {
            set;
            get;
        }
        public bool IsOnline{
            set;
            get;
        }
        public Contact(string macAddress,string hostName,string ipAddress,string firstName,string lastName,string dpPicture,DateTime lastOnlineTime,int newMessagecount,bool isArchived)
        {
            MacAddress = macAddress;
            HostName = hostName;
            FirstName = firstName;
            LastName = lastName;
            IpAddress = ipAddress;
            DpPicture = dpPicture;
            LastOnlineTime= lastOnlineTime;
            NewMessageCount = newMessagecount;
            IsArchived = isArchived;
      }
      public Contact(){

      }
    }
}
