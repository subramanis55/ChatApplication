using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class GroupMember
    {
        public Contact Contact { get; set; }
        public DateTime JoinDate
        {
            set;
            get;
        }
       public GroupMember( DateTime joinDate, Contact contact) {
           Contact= contact;
            JoinDate= joinDate;
        }
    }
}
